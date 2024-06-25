using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_ARUMA
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //Metodos

        private Color seleccionarColor()
        {
            int index = random.Next(Colores.ListaColores.Count);

            while (tempIndex == index)
            {
                index = random.Next(Colores.ListaColores.Count);
            }
            tempIndex = index;
            String color = Colores.ListaColores[index];
            return ColorTranslator.FromHtml(color);


        }

        private void ActivarBoton(object btnSender)
        {
            if (btnSender == null)
            {
                DesactivarBoton();
                if (currentButton != (Button)btnSender)
                {
                    Color color = seleccionarColor();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                   
                }
            }

        }

        private void DesactivarBoton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void abrirform(Form panel, object BtnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivarBoton(BtnSender);
            activeForm = panel;
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            this.pictureBox1.Controls.Add(panel);
            this.pictureBox1.Tag = panel;
            panel.BringToFront();
            panel.Show();
            LBTitulo.Text = panel.Text;
            Forma1();

        }


        private void productos_Click(object sender, EventArgs e)
        {
            abrirform(new Forms.FormularioProductos(), sender);
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            abrirform(new Forms.FormularioVentas(), sender);
            
            

        }

        private void reportes_Click(object sender, EventArgs e)
        {
            abrirform(new Forms.RegistroDSTRS(), sender);
        }

        private void Reset()
        {
            DesactivarBoton();
            LBTitulo.Text = "INICIO";
            currentButton = null;
          
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }

        private void Forma1()
        {
            if (activeForm != null)
            {
                activeForm.WindowState = FormWindowState.Normal;
                activeForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Forma1();
        }

        private void productos_MouseClick(object sender, MouseEventArgs e)
        {
     
        }

        private void productos_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirform(new Forms.Reportes(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirform(new Forms.RegistroDSTRS(), sender);
        }
    }
}
