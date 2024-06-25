using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_ARUMA.Forms
{
    public partial class TablaDistribuidores : Form
    {
        public TablaDistribuidores()
        {
            InitializeComponent();
        }

        private void TablaDistribuidores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'spaDataSet.Reg_DSTRS' Puede moverla o quitarla según sea necesario.
            this.reg_DSTRSTableAdapter.Fill(this.spaDataSet.Reg_DSTRS);

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0)
            {
                var descuento = dataGridView1.Rows[e.RowIndex].Cells["Descuento"].Value.ToString();
                var nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                
                 FormularioVentas formularioVentas = Application.OpenForms["FormularioVentas"] as FormularioVentas;

                if (formularioVentas != null)
                {
                    formularioVentas.DescuentoTexto = descuento;
                    formularioVentas.NombreDistribuidor = nombre;
                }

                this.Close();
            }
        }
    }
}
