using SPA_ARUMA.SpaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_ARUMA.Forms
{
    public partial class RegistroDSTRS : Form
    {
        private SpaDataSet.Reg_DSTRSDataTable table;
        private SpaDataSetTableAdapters.Reg_DSTRSTableAdapter adapter;
        public RegistroDSTRS()
        {
            InitializeComponent();
            table = new SpaDataSet.Reg_DSTRSDataTable();
            adapter = new SpaDataSetTableAdapters.Reg_DSTRSTableAdapter();
        }

        private void RegistroDSTRS_Load(object sender, EventArgs e)
        {

            try
            {
                if (spaDataSet == null)
                {
                    spaDataSet = new SpaDataSet();
                }

                if (reg_DSTRSTableAdapter == null)
                {
                    reg_DSTRSTableAdapter = new SpaDataSetTableAdapters.Reg_DSTRSTableAdapter();
                }

                // Deshabilita temporalmente las restricciones
                spaDataSet.EnforceConstraints = false;

                // Llena el DataTable
                this.reg_DSTRSTableAdapter.Fill(this.spaDataSet.Reg_DSTRS);

                // Habilita nuevamente las restricciones
                spaDataSet.EnforceConstraints = true;

                dataGridView1.DataSource = this.spaDataSet.Reg_DSTRS;
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Se ha producido un error de restricción: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];
                    String id = (string)row.Cells[0].Value;
                    var SeleccRegistro = this.spaDataSet.Reg_DSTRS.FindByID_DISTRIBUIDOR(id);

                    if (SeleccRegistro != null)
                    {

                        txtidven.Text = SeleccRegistro.ID_DISTRIBUIDOR;
                        txtnombre.Text = SeleccRegistro.NOMBRE;
                        txtTelefono.Text = SeleccRegistro.TELEFONO.ToString();
                        txtTelefonoE.Text = SeleccRegistro.TELEFONO_EMERGENCIA.ToString();
                        txtCorreo.Text = SeleccRegistro.CORREO;
                        txtDesc.Text = SeleccRegistro.DESCUENTO.ToString();
                        txtDireccion.Text = SeleccRegistro.DIRECCION;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta fila no se puede seleccionar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                String id_destribuidor = txtidven.Text;
                string nombre = txtnombre.Text;
                string telefono = txtTelefono.Text;
                string telefonoe = txtTelefonoE.Text;
                string correo = txtCorreo.Text;
                string descuento = txtDesc.Text;
                string direccion = txtDireccion.Text;


                var nuevoRegistro = table.NewReg_DSTRSRow();
                nuevoRegistro.ID_DISTRIBUIDOR = id_destribuidor;
                nuevoRegistro.NOMBRE = nombre;
                nuevoRegistro.TELEFONO = telefono;
                nuevoRegistro.TELEFONO_EMERGENCIA = telefonoe;
                nuevoRegistro.CORREO = correo;
                nuevoRegistro.DESCUENTO = descuento;
                nuevoRegistro.DIRECCION = direccion;

                table.AddReg_DSTRSRow(nuevoRegistro);
                adapter.Update(table);
                this.reg_DSTRSTableAdapter.Fill(this.spaDataSet.Reg_DSTRS);

                MessageBox.Show("El registro se guardó correctamente.");

                // Limpiar los campos de entrada
                txtidven.Text = "";
                txtnombre.Text = "";
                txtTelefono.Text = "";
                txtTelefonoE.Text = "";
                txtCorreo.Text = "";
                txtDesc.Text = "";
                txtDireccion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
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

                    var SeleccRegistro = this.spaDataSet.Reg_DSTRS.FindByID_DISTRIBUIDOR(id);

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

                            adapter.Update((SpaDataSet.Reg_DSTRSDataTable)SeleccRegistro.Table);

                            // Actualizar el DataGridView para reflejar los cambios
                            this.adapter.Fill(this.spaDataSet.Reg_DSTRS);

                            // Limpiar los campos de entrada
                            txtidven.Text = "";
                            txtnombre.Text = "";
                            txtTelefono.Text = "";
                            txtTelefonoE.Text = "";
                            txtCorreo.Text = "";
                            txtDesc.Text = "";
                            txtDireccion.Text = "";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.SelectedRows[0];
                String id = (String)row.Cells[0].Value;

                var SeleccRegistro = this.spaDataSet.Reg_DSTRS.FindByID_DISTRIBUIDOR(id);   

                if (SeleccRegistro != null)
                {

                    SeleccRegistro.ID_DISTRIBUIDOR = txtidven.Text;
                    SeleccRegistro.NOMBRE = txtnombre.Text;
                    SeleccRegistro.TELEFONO = txtTelefono.Text;
                    SeleccRegistro.TELEFONO_EMERGENCIA = txtTelefonoE.Text;
                    SeleccRegistro.CORREO = txtCorreo.Text;
                    SeleccRegistro.DESCUENTO = txtDesc.Text;
                    SeleccRegistro.DIRECCION = txtDireccion.Text;

                    adapter.Update((SpaDataSet.Reg_DSTRSDataTable)SeleccRegistro.Table); // Usar selectedRow.Table en lugar de table

                    // Actualizar el DataGridView para reflejar los cambios
                    this.reg_DSTRSTableAdapter.Fill(this.spaDataSet.Reg_DSTRS);

                    MessageBox.Show("Datos actualizados exitosamente.");
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para editar.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }
    }
    }
