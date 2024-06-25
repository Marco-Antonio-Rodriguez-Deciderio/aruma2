using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using SPA_ARUMA.SpaDataSetTableAdapters;




namespace SPA_ARUMA.Forms
{
    public partial class FormularioProductos : Form
    {
        private SpaDataSet.productosDataTable table;
        private SpaDataSetTableAdapters.productosTableAdapter adapter;


        public FormularioProductos()
        {
            InitializeComponent();
            table = new SpaDataSet.productosDataTable();
            adapter = new SpaDataSetTableAdapters.productosTableAdapter();

            var deleteCommand = new SqlCommand(
               "DELETE FROM productos WHERE id = @id", new SqlConnection(adapter.Connection.ConnectionString));
            deleteCommand.Parameters.Add("@id", SqlDbType.VarChar, 50, "id");
            adapter.Adapter.DeleteCommand = deleteCommand;

            var updateCommand = new SqlCommand(
        "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, existencia = @existencia, precio = @precio, imagen = @imagen WHERE id = @id",
        new SqlConnection(adapter.Connection.ConnectionString));
            updateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            updateCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 255, "descripcion");
            updateCommand.Parameters.Add("@existencia", SqlDbType.VarChar, 50, "existencia");
            updateCommand.Parameters.Add("@precio", SqlDbType.Decimal, 18, "precio");
            updateCommand.Parameters.Add("@imagen", SqlDbType.Image, int.MaxValue, "imagen");
            updateCommand.Parameters.Add("@id", SqlDbType.VarChar, 50, "id");
            adapter.Adapter.UpdateCommand = updateCommand;

        }

        public class Producto
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public string Existencia { get; set; }
        }

        public sealed class ProductoMap : ClassMap<Producto>
        {
            public ProductoMap()
            {
                Map(m => m.Id).Name("Id");
                Map(m => m.Nombre).Name("Nombre");
                Map(m => m.Descripcion).Name("Descripcion");
                Map(m => m.Precio).Name("Precio").TypeConverter<CustomDecimalConverter>();
                Map(m => m.Existencia).Name("Existencia");
            }
        }

        public class CustomDecimalConverter : DefaultTypeConverter
        {
            public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
            {
                if (decimal.TryParse(text, NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
                {
                    return result;
                }
                if (decimal.TryParse(text, NumberStyles.Currency, new CultureInfo("es-ES"), out result))
                {
                    return result;
                }

                // Manejar caso cuando el texto no se puede convertir
                return 0m; // O cualquier valor predeterminado que consideres adecuado
            }
        }

        private async Task CargarProductosDesdeCSV(string rutaArchivo)
        {
            try
            {
                var cultureInfo = CultureInfo.InvariantCulture;
                var csvConfiguration = new CsvConfiguration(cultureInfo)
                {
                    HasHeaderRecord = true,
                    Delimiter = ",",
                    BadDataFound = null
                };

                using (var reader = new StreamReader(rutaArchivo))
                using (var csv = new CsvReader(reader, csvConfiguration))
                {
                    csv.Context.RegisterClassMap<ProductoMap>();
                    var productos = csv.GetRecords<Producto>().ToList();

                    foreach (var producto in productos)
                    {
                        // Usar el ID directamente desde el archivo CSV
                        string id = producto.Id;
                        table.AddproductosRow(id, producto.Nombre, producto.Descripcion, producto.Precio.ToString(), producto.Existencia, null);
                    }

                    // Actualizar la base de datos
                    adapter.Update(table);
                    this.productosTableAdapter.Fill(this.spaDataSet.productos);

                    MessageBox.Show("Carga masiva de productos completada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos desde el archivo CSV: " + ex.Message);
            }
        }


        private async Task DescargarImagen(string urlImagen)
        {
            using (var httpClient = new HttpClient())
            {
                var bytes = await httpClient.GetByteArrayAsync(urlImagen);

                // Guardar la imagen en una carpeta local
                string nombreImagen = Path.GetFileName(urlImagen);
                string rutaGuardarImagen = Path.Combine(Directory.GetCurrentDirectory(), "imagenes", nombreImagen);

                File.WriteAllBytes(rutaGuardarImagen, bytes);
            }
        }



        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            try
            {
                if (spaDataSet == null)
                {
                    spaDataSet = new SpaDataSet();
                }

                if (productosTableAdapter == null)
                {
                    productosTableAdapter = new SpaDataSetTableAdapters.productosTableAdapter();
                }


                // Llena el DataTable
                this.productosTableAdapter.Fill(this.spaDataSet.productos);

                // Refrescar el DataGridView
                dataGridView1.DataSource = this.spaDataSet.productos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];
                    String id = (String)row.Cells[0].Value;

                    DataRow SeleccRegistro = null;
                    foreach (DataRow row2 in this.spaDataSet.productos.Rows)
                    {
                        if (row2["id"].ToString() == id)
                        {
                            SeleccRegistro = row2;
                            break;
                        }
                    }

                    if (SeleccRegistro != null)
                    {
                        txtid.Text = SeleccRegistro["id"].ToString();
                        txtnombre.Text = SeleccRegistro["nombre"].ToString();
                        txtdescripcion.Text = SeleccRegistro["descripcion"].ToString();
                        txtexistencia.Text = SeleccRegistro["existencia"].ToString();
                        txtprecio.Text = SeleccRegistro["precio"].ToString();

                        if (!SeleccRegistro.IsNull("imagen"))
                        {
                            using (MemoryStream ms = new MemoryStream((byte[])SeleccRegistro["imagen"]))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void btborrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];
                    String id = (String)row.Cells[0].Value;

                    DataRow SeleccRegistro = null;
                    foreach (DataRow row2 in this.spaDataSet.productos.Rows)
                    {
                        if (row2["id"].ToString() == id)
                        {
                            SeleccRegistro = row2;
                            break;
                        }
                    }

                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este elemento?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (result == DialogResult.Yes)
                    {
                        if (SeleccRegistro != null)
                        {
                            SeleccRegistro.Delete();
                            adapter.Update((SpaDataSet.productosDataTable)SeleccRegistro.Table);

                            this.adapter.Fill(this.spaDataSet.productos);

                            txtid.Text = "";
                            txtnombre.Text = "";
                            txtexistencia.Text = "";
                            txtdescripcion.Text = "";
                            txtprecio.Text = "";
                            pictureBox1.Image = Image.FromFile("C:\\Users\\Desarolladores\\Downloads\\insertarimg.png");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];
                    string id = (string)row.Cells[0].Value;

                    DataRow SeleccRegistro = null;
                    foreach (DataRow row2 in this.spaDataSet.productos.Rows)
                    {
                        if (row2["id"].ToString() == id)
                        {
                            SeleccRegistro = row2;
                            break;
                        }
                    }

                    if (SeleccRegistro != null)
                    {
                        SeleccRegistro["id"] = txtid.Text;
                        SeleccRegistro["nombre"] = txtnombre.Text;
                        SeleccRegistro["descripcion"] = txtdescripcion.Text;
                        SeleccRegistro["existencia"] = txtexistencia.Text;
                        SeleccRegistro["precio"] = txtprecio.Text;

                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                SeleccRegistro["imagen"] = ms.ToArray();
                            }
                        }
                        else
                        {
                            SeleccRegistro["imagen"] = DBNull.Value;
                        }

                        adapter.Update((SpaDataSet.productosDataTable)SeleccRegistro.Table);
                        this.productosTableAdapter.Fill(this.spaDataSet.productos);

                        MessageBox.Show("Datos actualizados exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila para editar.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el registro: " + ex.Message);
            }
        }




        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Generar un nuevo ID secuencial
                String id = txtid.Text;
                string nombre = txtnombre.Text;
                string descripcion = txtdescripcion.Text;
                string existencia = txtexistencia.Text;
                string precio = txtprecio.Text;

                byte[] imagen = null;

                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imagen = ms.ToArray();
                    }
                }

                var nuevoRegistro = table.NewproductosRow();
                nuevoRegistro.id = id;
                nuevoRegistro.nombre = nombre;
                nuevoRegistro.descripcion = descripcion;
                nuevoRegistro.existencia = existencia;
                nuevoRegistro.precio = precio;
                nuevoRegistro.imagen = imagen;

                table.AddproductosRow(nuevoRegistro);

                adapter.Update(table);

                this.productosTableAdapter.Fill(this.spaDataSet.productos);

                MessageBox.Show("El registro se guardó correctamente.");

                // Limpiar los campos
                txtid.Text = "";
                txtnombre.Text = "";
                txtexistencia.Text = "";
                txtdescripcion.Text = "";
                txtprecio.Text = "";
                pictureBox1.Image = Image.FromFile("C:\\Users\\Desarolladores\\Downloads\\insertarimg.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);
            }

        }

        private void btnSelec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtcantidad_Click(object sender, EventArgs e)
        {

        }

        private void txtprecio_Click(object sender, EventArgs e)
        {

        }


        private void getBuscar(String Dato)
        {
            try
            {
                var Filtrar = spaDataSet.productos.Where(producto =>
                 producto.nombre.IndexOf(Dato, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 producto.descripcion.IndexOf(Dato, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 producto.id.IndexOf(Dato, StringComparison.OrdinalIgnoreCase) >= 0
                 ).ToList();

                if (Filtrar.Count > 0)
                {
                    dataGridView1.DataSource = Filtrar.CopyToDataTable();
                }
                else
                {
                    dataGridView1.DataSource = null;    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message);
            }
        }


        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            String Dato = txtBuscar.Text;
            getBuscar(Dato);
        }

        private async void btnCargarProductos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos CSV (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = ofd.FileName;
                await CargarProductosDesdeCSV(rutaArchivo);
            }
        }
    }

}
        
    