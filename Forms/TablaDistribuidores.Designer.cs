namespace SPA_ARUMA.Forms
{
    partial class TablaDistribuidores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regDSTRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaDataSet = new SPA_ARUMA.SpaDataSet();
            this.reg_DSTRSTableAdapter = new SPA_ARUMA.SpaDataSetTableAdapters.Reg_DSTRSTableAdapter();
            this.Id_Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDSTRSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Distribuidor,
            this.Nombre,
            this.Telefono,
            this.TelefonoE,
            this.Correo,
            this.Descuento,
            this.Direccion});
            this.dataGridView1.DataSource = this.regDSTRSBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // regDSTRSBindingSource
            // 
            this.regDSTRSBindingSource.DataMember = "Reg_DSTRS";
            this.regDSTRSBindingSource.DataSource = this.spaDataSet;
            // 
            // spaDataSet
            // 
            this.spaDataSet.DataSetName = "SpaDataSet";
            this.spaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reg_DSTRSTableAdapter
            // 
            this.reg_DSTRSTableAdapter.ClearBeforeFill = true;
            // 
            // Id_Distribuidor
            // 
            this.Id_Distribuidor.DataPropertyName = "ID_DISTRIBUIDOR";
            this.Id_Distribuidor.HeaderText = "ID_DISTRIBUIDOR";
            this.Id_Distribuidor.Name = "Id_Distribuidor";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NOMBRE";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TELEFONO";
            this.Telefono.HeaderText = "TELEFONO";
            this.Telefono.Name = "Telefono";
            // 
            // TelefonoE
            // 
            this.TelefonoE.DataPropertyName = "TELEFONO_EMERGENCIA";
            this.TelefonoE.HeaderText = "TELEFONO_EMERGENCIA";
            this.TelefonoE.Name = "TelefonoE";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CORREO";
            this.Correo.HeaderText = "CORREO";
            this.Correo.Name = "Correo";
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "DESCUENTO";
            this.Descuento.HeaderText = "DESCUENTO";
            this.Descuento.Name = "Descuento";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "DIRECCION";
            this.Direccion.HeaderText = "DIRECCION";
            this.Direccion.Name = "Direccion";
            // 
            // TablaDistribuidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaDistribuidores";
            this.Text = "TablaDistribuidores";
            this.Load += new System.EventHandler(this.TablaDistribuidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDSTRSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource regDSTRSBindingSource;
        private SpaDataSetTableAdapters.Reg_DSTRSTableAdapter reg_DSTRSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Distribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}