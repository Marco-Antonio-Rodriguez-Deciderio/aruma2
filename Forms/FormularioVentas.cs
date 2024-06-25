using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SPA_ARUMA.Forms
{
    public partial class FormularioVentas : Form
    {

        private SpaDataSet.VentasDataTable table;
        private SpaDataSetTableAdapters.VentasTableAdapter adapter;
        private PrintDocument PD = new PrintDocument();
        private PrintPreviewDialog PPD = new PrintPreviewDialog();
        private int longpaper;
        private SpaDataSet.productosDataTable table1;
        private SpaDataSetTableAdapters.productosTableAdapter adapter1;

        public FormularioVentas()
        {
            InitializeComponent();
            table = new SpaDataSet.VentasDataTable();
            adapter = new SpaDataSetTableAdapters.VentasTableAdapter();
            PD.BeginPrint += new PrintEventHandler(PD_BeginPrint);
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            table1 = new SpaDataSet.productosDataTable();
            adapter1 = new SpaDataSetTableAdapters.productosTableAdapter();
            this.KeyPreview = true;



        }

        public string DescuentoTexto
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }

        }

        public string NombreDistribuidor
        {
            get { return NombreC.Text; }
            set { NombreC.Text = value; }
        }



        private void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            PageSettings pagesetup = new PageSettings();
            pagesetup.PaperSize = new PaperSize("Custom", 200, longpaper); // 200 -> 58mm width
            PD.DefaultPageSettings = pagesetup;
        }

        private int currentPageIndex = 0;

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                if (dataGridView2.RowCount == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.");
                    return;
                }

                Font f8 = new Font("Palatino Linotype", 6, FontStyle.Regular);
                Font f10 = new Font("Palatino Linotype", 10, FontStyle.Regular);
                Font f101 = new Font("Palatino Linotype", 5, FontStyle.Regular);
                Font f10b = new Font("Palatino Linotype", 8, FontStyle.Bold);
                Font f14 = new Font("Palatino Linotype", 14, FontStyle.Bold);

                int leftmargin = PD.DefaultPageSettings.Margins.Left;
                int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
                int rightmargin = PD.DefaultPageSettings.PaperSize.Width;

                StringFormat right = new StringFormat();
                StringFormat center = new StringFormat();
                StringFormat left = new StringFormat();
                right.Alignment = StringAlignment.Far;
                center.Alignment = StringAlignment.Center;
                left.Alignment = StringAlignment.Near;

                string line = "****************************************************************";

                Image logoImage = Properties.Resources.logo_ticket;
                e.Graphics.DrawImage(logoImage, (e.PageBounds.Width - 100) / 2, -15, 100, 55);

                e.Graphics.DrawString("ARUMA", f10, Brushes.Black, centermargin, 27, center);
                e.Graphics.DrawString("Ignacio Altamirano 7A Col.Ex-Hacienda De Santa Monica,", f101, Brushes.Black, 8, 45);
                e.Graphics.DrawString("Tlanepantla De Baz,Estado De México C.P 54050.", f101, Brushes.Black, 22, 55);
                e.Graphics.DrawString("Num. de teléfono: 5641733112 ", f8, Brushes.Black, 0, 75);

                e.Graphics.DrawString("Cajero", f8, Brushes.Black, 0, 85);
                e.Graphics.DrawString(":", f8, Brushes.Black, 33, 85);
                e.Graphics.DrawString("Lizeth Martínez González", f8, Brushes.Black, 38, 85);

                e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString() + " - Hora: " + DateTime.Now.ToShortTimeString(), f8, Brushes.Black, 0, 95);

                e.Graphics.DrawString("Cant.", f8, Brushes.Black, 0, 110);
                e.Graphics.DrawString("Productos", f8, Brushes.Black, 30, 110);
                e.Graphics.DrawString("Valor", f8, Brushes.Black, 140, 110, right);
                e.Graphics.DrawString("Total", f8, Brushes.Black, 185, 110, right);
                e.Graphics.DrawString(line, f10, Brushes.Black, 0, 120);



                int height = 0;
                int itemHeight = 15;
                int charsPerLine = 12; // Número de caracteres por línea

                int contentHeight = 145 + height; // Altura total del contenido en la página actual

                if (contentHeight > PD.DefaultPageSettings.PaperSize.Height)
                {
                    // Contenido excede el tamaño de la página, imprimir en la próxima página
                    e.HasMorePages = true;
                    currentPageIndex++;
                    return;
                }


                for (int row = 0; row < dataGridView2.RowCount; row++)
                {
                    string producto = dataGridView2.Rows[row].Cells["Producto"].Value?.ToString();
                    if (string.IsNullOrWhiteSpace(producto)) continue; // Saltar filas vacías

                    int cantidad = Convert.ToInt32(dataGridView2.Rows[row].Cells["Cantidad"].Value ?? 0);
                    if (cantidad == 0) continue; // Saltar filas con cantidad 0

                    decimal precio = 0;
                    if (dataGridView2.Rows[row].Cells["Precio"].Value != null)
                    {
                        precio = Convert.ToDecimal(dataGridView2.Rows[row].Cells["Precio"].Value);
                    }

                    decimal totalprice = precio * cantidad;

                    height += itemHeight;
                    e.Graphics.DrawString(cantidad.ToString(), f10, Brushes.Black, 0, 130 + height);

                    // Dividir el texto en líneas cada 14 caracteres
                    List<string> lines = SplitTextIntoLines(producto, charsPerLine);
                    float startY = 130 + height;
                    foreach (string lineText in lines)
                    {
                        e.Graphics.DrawString(lineText, f8, Brushes.Black, 30, startY, left);
                        startY += itemHeight; // Ajustar la posición de la siguiente línea
                    }

                    e.Graphics.DrawString("$" + precio.ToString("##,##0.00"), f8, Brushes.Black, 150, 130 + height, right);
                    e.Graphics.DrawString("$" + totalprice.ToString("##,##0.00"), f8, Brushes.Black, rightmargin - 10, 130 + height, right);

                    // Calcular la altura para la próxima fila basada en el texto envuelto
                    int linesCount = lines.Count;
                    height += (linesCount - 1) * itemHeight; // Ajustar altura para texto envuelto
                }
                e.Graphics.DrawString(line, f10, Brushes.Black, 0, 145 + height);

                int height2 = 145 + height;

                sumprice();

                decimal descuento = 0;
                decimal Cantidadescontada = 0;
                decimal Subtotal = t_price;

                if (!string.IsNullOrEmpty(txtDesc.Text) && decimal.TryParse(txtDesc.Text, out descuento))
                {
                    if (descuento > 0 && descuento <= 100)
                    {
                        Cantidadescontada = t_price * (descuento / 100); // Calcular la cantidad descontada
                        t_price -= Cantidadescontada; // Calcular el nuevo total con descuento
                    }
                    else
                    {
                        MessageBox.Show("El descuento ingresado no es válido. Por favor, ingresa un porcentaje válido entre 1 y 100.");
                        return; // Salir del método si el descuento no es válido
                    }
                }

                // Imprimir Subtotal
                e.Graphics.DrawString("Subtotal: $" + Subtotal.ToString("##,##0.00"), f10b, Brushes.Black, rightmargin - 10, 20 + height2, right);

                // Imprimir Descuento si aplica
                if (Cantidadescontada > 0)
                {
                    e.Graphics.DrawString("Descuento: $" + Cantidadescontada.ToString("##,##0.00"), f10b, Brushes.Black, rightmargin - 10, 40 + height2, right);
                    e.Graphics.DrawString("Total: $" + t_price.ToString("##,##0.00"), f10b, Brushes.Black, rightmargin - 10, 60 + height2, right);
                    height2 += 30;
                }
                else
                {
                    e.Graphics.DrawString("Total: $" + t_price.ToString("##,##0.00"), f10b, Brushes.Black, rightmargin - 10, 30 + height2, right);
                }

                // Imprimir cantidad de items
                e.Graphics.DrawString("Productos: " + t_qty.ToString(), f10b, Brushes.Black, 0, 8 + height2);

                e.Graphics.DrawString(" GRACIAS POR PREFERIRNOS", f10b, Brushes.Black, centermargin, 90 + height2, center);
                e.Graphics.DrawString("Si desea facturar comuniquese a este número:", f8, Brushes.Black, centermargin, 110 + height2, center);
                e.Graphics.DrawString("5641733112", f8, Brushes.Black, centermargin, 120 + height2, center);
                height = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de impresión: " + ex.Message);
            }

        }

        private decimal t_price;
        private int t_qty;

        private void sumprice()
        {
            decimal countprice = 0;
            int countqty = 0;

            for (int rowitem = 0; rowitem < dataGridView2.RowCount; rowitem++)
            {
                string producto = dataGridView2.Rows[rowitem].Cells["Producto"].Value?.ToString();
                if (string.IsNullOrWhiteSpace(producto)) continue; // Saltar filas vacías

                int cantidad = Convert.ToInt32(dataGridView2.Rows[rowitem].Cells["Cantidad"].Value ?? 0);
                if (cantidad == 0) continue; // Saltar filas con cantidad 0

                decimal precio = 0;
                if (dataGridView2.Rows[rowitem].Cells["Precio"].Value != null)
                {
                    precio = Convert.ToDecimal(dataGridView2.Rows[rowitem].Cells["Precio"].Value);
                }

                countprice += precio * cantidad;
                countqty += cantidad;
            }

            t_price = countprice;
            t_qty = countqty;
        }


        private List<string> SplitTextIntoLines(string text, int charsPerLine)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < text.Length; i += charsPerLine)
            {
                int length = Math.Min(charsPerLine, text.Length - i);
                lines.Add(text.Substring(i, length));
            }
            return lines;
        }


        private void FormularioVentas_Load(object sender, EventArgs e)
        {

        }

        private void FormularioVentas_Load_1(object sender, EventArgs e)
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



                txtDesc.Visible = false;
                Descuento.Visible = false;
                porcentaje.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
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
                        txtexistencia.Text = SeleccRegistro["existencia"].ToString();
                        txtprecio.Text = SeleccRegistro["precio"].ToString();

                        if (!SeleccRegistro.IsNull("imagen"))
                        {
                            using (MemoryStream ms = new MemoryStream((byte[])SeleccRegistro["imagen"]))
                            {
                                pictureBox2.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox2.Image = null;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta fila no se puede seleccionar");
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2 == null || NombreC == null || txtid == null || txtnombre == null || txtprecio == null || pictureBox2 == null)
                {
                    MessageBox.Show("Uno o más controles no están inicializados correctamente.");
                    return;
                }

                if (dataGridView2.Rows.Count > 0)
                {
                    string nombrecliente = NombreC.Text;
                    int cantidadTotal = 0;
                    decimal importeTotal = 0;
                    DateTime CCC = DateTime.Now;
                    DateTime fecha = CCC.Date;
                    TimeSpan hora = CCC.TimeOfDay;
                    decimal descuento = 0;
                    decimal CantidadDescontada = 0;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["Cantidad"].Value != null && row.Cells["Importe"].Value != null)
                        {
                            cantidadTotal += Convert.ToInt32(row.Cells["Cantidad"].Value);
                            importeTotal += Convert.ToDecimal(row.Cells["Importe"].Value);
                        }
                    }
                    if (!string.IsNullOrEmpty(txtDesc.Text))
                    {
                        if (decimal.TryParse(txtDesc.Text, out descuento))
                        {
                            if (descuento > 0 && descuento <= 100)
                            {
                                CantidadDescontada = importeTotal * (descuento / 100);
                                descuento = importeTotal - CantidadDescontada;
                                importeTotal = descuento;
                            }
                        }
                    }
                    var nuevoRegistro = table.NewVentasRow();
                    nuevoRegistro.nombre_cliente = nombrecliente;
                    nuevoRegistro.importeTotal = importeTotal;
                    nuevoRegistro.cantidad = cantidadTotal.ToString();
                    nuevoRegistro.fecha = fecha;
                    nuevoRegistro.hora = hora;

                    table.AddVentasRow(nuevoRegistro);
                    adapter.Update(table);




                    MessageBox.Show("El registro se guardó correctamente.");

                    // Limpiar los controles y DataGridView2
                    txtid.Text = "";
                    NombreC.Text = "";
                    txtnombre.Text = "";
                    txtprecio.Text = "";
                    dataGridView2.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("No hay productos en la lista para guardar.");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error: Referencia nula encontrada. Detalles: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var row = dataGridView1.SelectedRows[0];

                    if (row.Cells["id"].Value != null && row.Cells["nombre"].Value != null && row.Cells["precioo"].Value != null && row.Cells["existencia"].Value != null)
                    {
                        string id = row.Cells["id"].Value.ToString();
                        string nombre = row.Cells["nombre"].Value.ToString();
                        decimal precio = Convert.ToDecimal(row.Cells["precioo"].Value);
                        int existencia = Convert.ToInt32(row.Cells["existencia"].Value);
                        DateTime FechaC = DateTime.Now;
                        string fecha = FechaC.ToString("dd/MM/yyyy");
                        string hora = FechaC.ToString("HH:mm:ss");

                        bool productoExiste = false;
                        foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
                        {
                            if (dgvRow.Cells["idd"].Value != null && dgvRow.Cells["idd"].Value.ToString() == id)
                            {
                                int cantidadActual = Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                                if (cantidadActual + 1 <= existencia)
                                {
                                    dgvRow.Cells["Cantidad"].Value = cantidadActual + 1;
                                    dgvRow.Cells["Importe"].Value = (cantidadActual + 1) * precio;
                                }
                                else
                                {
                                    MessageBox.Show("No puede agregar más del producto en existencia.");
                                }
                                productoExiste = true;
                                break;
                            }
                        }

                        if (!productoExiste)
                        {
                            if (existencia >= 1)
                            {
                                int cantidad = 1;
                                decimal importe = cantidad * precio;
                                dataGridView2.Rows.Add(id, null, nombre, cantidad, precio, importe, fecha, hora);
                            }
                            else
                            {
                                MessageBox.Show("El producto no tiene existencia disponible.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto seleccionado tiene datos incompletos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var row = dataGridView1.SelectedRows[0];

                    string nombre = row.Cells["nombre"].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells["precioo"].Value);

                    foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
                    {
                        if (dgvRow.Cells["Producto"].Value != null && dgvRow.Cells["Producto"].Value.ToString() == nombre)
                        {
                            int cantidadActual = Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                            if (cantidadActual > 1)
                            {
                                dgvRow.Cells["Cantidad"].Value = cantidadActual - 1;
                                dgvRow.Cells["Importe"].Value = (cantidadActual - 1) * precio;
                            }
                            else
                            {
                                MessageBox.Show("No puede decrementar más la cantidad.");
                            }
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.");
            }
        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            try
            {
                changelongpaper();
                PD.Print();
                print();

                // Restar la existencia y guardarla en la base de datos
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["Producto"].Value != null && row.Cells["Cantidad"].Value != null)
                    {
                        string producto = row.Cells["Producto"].Value.ToString();
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        // Actualizar la existencia en la base de datos
                        UpdateExistencia(producto, cantidad);

                        // Actualizar la existencia en dataGridView1
                        UpdateDataGridView1(producto, cantidad);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir y actualizar existencia: " + ex.Message);
            }
        }

        private void UpdateExistencia(string producto, int cantidad)
        {
            try
            {
                // Obtener el producto de la base de datos
                var productRow = spaDataSet.productos.FirstOrDefault(p => p.nombre == producto);
                if (productRow != null)
                {
                    int existenciaActual = Convert.ToInt32(productRow.existencia);
                    if (existenciaActual >= cantidad)
                    {
                        // Restar la cantidad de existencia
                        productRow.existencia = (existenciaActual - cantidad).ToString();

                        // Asegurarse de que la fila se marca como modificada
                        spaDataSet.productos.AcceptChanges();
                        productRow.SetModified();

                        // Configurar el comando de actualización si no está configurado
                        if (this.productosTableAdapter.Adapter.UpdateCommand == null)
                        {
                            var updateCommand = new SqlCommand("UPDATE productos SET existencia = @existencia WHERE nombre = @nombre", this.productosTableAdapter.Connection);
                            updateCommand.Parameters.Add("@existencia", SqlDbType.Int, 32, "existencia");
                            updateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
                            this.productosTableAdapter.Adapter.UpdateCommand = updateCommand;
                        }

                        // Actualizar la base de datos
                        this.productosTableAdapter.Update(productRow);
                        this.productosTableAdapter.Fill(this.spaDataSet.productos);
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente existencia para {producto}. Existencia actual: {existenciaActual}");
                    }
                }
                else
                {
                    MessageBox.Show($"Producto {producto} no encontrado en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar existencia para {producto}: {ex.Message}");
            }
        }

        private void UpdateDataGridView1(string producto, int cantidad)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["nombre"].Value != null && row.Cells["nombre"].Value.ToString() == producto)
                {
                    int existenciaActual = Convert.ToInt32(row.Cells["existencia"].Value);
                    row.Cells["existencia"].Value = (existenciaActual - cantidad).ToString();
                    break;
                }
            }
        }


        private void changelongpaper()
        {
            int numberOfProducts = dataGridView2.RowCount;
            int additionalSpace = 200; // Ajusta según sea necesario
            longpaper = 10000 + (numberOfProducts * 50) + additionalSpace;
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            changelongpaper();
            PPD.Document = PD;
            PPD.ShowDialog();
            print();
        }

        private void print()
        {
            try
            {
                if (PPD.ShowDialog() == DialogResult.OK)
                {
                    PD.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing Error: " + ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == ((DataGridView)sender).Columns["eliminar"].Index && e.RowIndex >= 0)
                {
                    // Eliminar la fila correspondiente
                    ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                }
            }
            catch
            {
                MessageBox.Show("No hay registro para eliminar.");
            }
        }

        private void slideButton1_Click(object sender, EventArgs e)
        {
            if (slideButton1.IsOn)
            {
                txtDesc.Visible = true;
                Descuento.Visible = true;
                porcentaje.Visible = true;

            }
            else
            {
                txtDesc.Visible = false;
                Descuento.Visible = false;
                porcentaje.Visible = false;
                txtDesc.Text = "";
            }
        }


        private void slideButton2_Click(object sender, EventArgs e)
        {
            if (SlideDesc.IsOn)
            {
                TablaDistribuidores Abrir = new TablaDistribuidores();
                Abrir.ShowDialog();
                txtDesc.Visible = true;
                Descuento.Visible = true;
                porcentaje.Visible = true;
                txtDesc.Enabled = false;
                NombreC.Enabled = false;
                label2.Visible = false;
                slideButton1.Visible = false;

            }
            else
            {
                txtDesc.Visible = false;
                Descuento.Visible = false;
                porcentaje.Visible = false;
                txtDesc.Enabled = true;
                NombreC.Enabled = true;
                label2.Visible = true;
                slideButton1.Visible = true;
            }
        }

        private void txtDesc_Click(object sender, EventArgs e)
        {




        }

        private void FormularioVentas_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void txtEscaner_TextChanged_1(object sender, EventArgs e)
        {



        }

        private void txtEscaner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string productIdString = txtEscaner.Text.Trim();
                Debug.WriteLine("ID ingresado: " + productIdString);

                if (string.IsNullOrWhiteSpace(productIdString))
                {
                    MessageBox.Show("El campo ID no puede estar vacío.");
                    return;
                }

                if (!productIdString.All(char.IsDigit))
                {
                    MessageBox.Show("El ID ingresado no es válido. Ingrese un valor numérico.");
                    return;
                }

                long productId;
                if (!long.TryParse(productIdString, out productId))
                {
                    MessageBox.Show("El ID ingresado no es válido. Ingrese un valor numérico.");
                    return;
                }

                // Buscar el producto por ID en dataGridView1
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    long idValue;
                    if (row.Cells["id"].Value != null && long.TryParse(row.Cells["id"].Value.ToString(), out idValue) && idValue == productId)
                    {
                        string id = row.Cells["id"].Value.ToString();
                        string nombre = "";
                        decimal precio = 0;
                        int existencia = 0;

                        if (dataGridView1.Columns.Contains("nombre"))
                        {
                            nombre = row.Cells["nombre"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("La columna 'nombre' no existe.");
                            return;
                        }

                        if (dataGridView1.Columns.Contains("precioo"))
                        {
                            precio = Convert.ToDecimal(row.Cells["precioo"].Value);
                        }
                        else
                        {
                            MessageBox.Show("La columna 'precio' no existe.");
                            return;
                        }

                        if (dataGridView1.Columns.Contains("existencia"))
                        {
                            existencia = Convert.ToInt32(row.Cells["existencia"].Value);
                        }
                        else
                        {
                            MessageBox.Show("La columna 'existencia' no existe.");
                            return;
                        }

                        DateTime FechaC = DateTime.Now;
                        string fecha = FechaC.ToString("dd/MM/yyyy");
                        string hora = FechaC.ToString("HH:mm:ss");

                        bool productoExiste = false;
                        foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
                        {
                            if (dgvRow.Cells["idd"].Value != null && dgvRow.Cells["idd"].Value.ToString() == id)
                            {
                                int cantidadActual = Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                                if (cantidadActual + 1 <= existencia)
                                {
                                    dgvRow.Cells["Cantidad"].Value = cantidadActual + 1;
                                    dgvRow.Cells["Importe"].Value = (cantidadActual + 1) * precio;
                                }
                                else
                                {
                                    MessageBox.Show("No puede agregar más del producto en existencia.");
                                }
                                productoExiste = true;
                                break;
                            }
                        }

                        if (!productoExiste)
                        {
                            if (existencia >= 1)
                            {
                                int cantidad = 1;
                                decimal importe = cantidad * precio;
                                dataGridView2.Rows.Add(id, null, nombre, cantidad, precio, importe, fecha, hora);
                            }
                            else
                            {
                                MessageBox.Show("El producto no tiene existencia disponible.");
                            }
                        }

                        txtEscaner.Text = "";
                        break;
                    }
                }
            }
        }
    }
}
        
    






