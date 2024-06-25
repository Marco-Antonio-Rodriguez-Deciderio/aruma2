namespace SPA_ARUMA.Forms
{
    partial class RegistroDSTRS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDSTRS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_DISTRIBUIDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_emergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDSTRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaDataSet = new SPA_ARUMA.SpaDataSet();
            this.reg_DSTRSTableAdapter = new SPA_ARUMA.SpaDataSetTableAdapters.Reg_DSTRSTableAdapter();
            this.txtCorreo = new AltoControls.AltoTextBox();
            this.txtTelefonoE = new AltoControls.AltoTextBox();
            this.txtTelefono = new AltoControls.AltoTextBox();
            this.txtnombre = new AltoControls.AltoTextBox();
            this.txtidven = new AltoControls.AltoTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new AltoControls.AltoTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.regDSTRSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new AltoControls.AltoButton();
            this.btnEdit = new AltoControls.AltoButton();
            this.btborrar = new AltoControls.AltoButton();
            this.porcentajesss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDSTRSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDSTRSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DISTRIBUIDOR,
            this.nombre,
            this.telefono,
            this.telefono_emergencia,
            this.correo,
            this.descuento,
            this.direccion});
            this.dataGridView1.DataSource = this.regDSTRSBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(558, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID_DISTRIBUIDOR
            // 
            this.ID_DISTRIBUIDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_DISTRIBUIDOR.DataPropertyName = "ID_DISTRIBUIDOR";
            this.ID_DISTRIBUIDOR.HeaderText = "ID_DISTRIBUIDOR";
            this.ID_DISTRIBUIDOR.Name = "ID_DISTRIBUIDOR";
            this.ID_DISTRIBUIDOR.Width = 144;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "TELEFONO";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            // 
            // telefono_emergencia
            // 
            this.telefono_emergencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono_emergencia.DataPropertyName = "TELEFONO_EMERGENCIA";
            this.telefono_emergencia.HeaderText = "TELEFONO_EMERGENCIA";
            this.telefono_emergencia.Name = "telefono_emergencia";
            this.telefono_emergencia.Width = 194;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "CORREO";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "DESCUENTO";
            this.descuento.HeaderText = "DESCUENTO";
            this.descuento.Name = "descuento";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "DIRECCION";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            // 
            // regDSTRSBindingSource
            // 
            this.regDSTRSBindingSource.DataMember = "Reg_DSTRS";
            this.regDSTRSBindingSource.DataSource = this.spaDataSetBindingSource;
            // 
            // spaDataSetBindingSource
            // 
            this.spaDataSetBindingSource.DataSource = this.spaDataSet;
            this.spaDataSetBindingSource.Position = 0;
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
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.Br = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCorreo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(271, 542);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(135, 33);
            this.txtCorreo.TabIndex = 34;
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefonoE.Br = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTelefonoE.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoE.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoE.Location = new System.Drawing.Point(271, 478);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(135, 33);
            this.txtTelefonoE.TabIndex = 33;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Br = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTelefono.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(271, 417);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 33);
            this.txtTelefono.TabIndex = 32;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Transparent;
            this.txtnombre.Br = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(271, 356);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(135, 33);
            this.txtnombre.TabIndex = 31;
            // 
            // txtidven
            // 
            this.txtidven.BackColor = System.Drawing.Color.Transparent;
            this.txtidven.Br = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtidven.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidven.ForeColor = System.Drawing.Color.Black;
            this.txtidven.Location = new System.Drawing.Point(271, 297);
            this.txtidven.Name = "txtidven";
            this.txtidven.Size = new System.Drawing.Size(135, 33);
            this.txtidven.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Teléfono Emergencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID. Destribuidor:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.Br = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDesc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(271, 601);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(47, 33);
            this.txtDesc.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Descuento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 658);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDireccion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(271, 661);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDireccion.Size = new System.Drawing.Size(305, 155);
            this.txtDireccion.TabIndex = 39;
            // 
            // regDSTRSBindingSource1
            // 
            this.regDSTRSBindingSource1.DataMember = "Reg_DSTRS";
            this.regDSTRSBindingSource1.DataSource = this.spaDataSetBindingSource;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnGuardar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(1016, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Radius = 10;
            this.btnGuardar.Size = new System.Drawing.Size(101, 30);
            this.btnGuardar.Stroke = false;
            this.btnGuardar.StrokeColor = System.Drawing.Color.Gray;
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Transparency = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnEdit.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.Location = new System.Drawing.Point(862, 318);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(101, 30);
            this.btnEdit.Stroke = false;
            this.btnEdit.StrokeColor = System.Drawing.Color.Gray;
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Transparency = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btborrar
            // 
            this.btborrar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btborrar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btborrar.BackColor = System.Drawing.Color.Transparent;
            this.btborrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btborrar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btborrar.ForeColor = System.Drawing.Color.Black;
            this.btborrar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btborrar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btborrar.Location = new System.Drawing.Point(881, 365);
            this.btborrar.Name = "btborrar";
            this.btborrar.Radius = 10;
            this.btborrar.Size = new System.Drawing.Size(227, 30);
            this.btborrar.Stroke = false;
            this.btborrar.StrokeColor = System.Drawing.Color.Gray;
            this.btborrar.TabIndex = 42;
            this.btborrar.Text = "Borrar";
            this.btborrar.Transparency = false;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // porcentajesss
            // 
            this.porcentajesss.AutoSize = true;
            this.porcentajesss.BackColor = System.Drawing.Color.Transparent;
            this.porcentajesss.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentajesss.Location = new System.Drawing.Point(324, 608);
            this.porcentajesss.Name = "porcentajesss";
            this.porcentajesss.Size = new System.Drawing.Size(29, 26);
            this.porcentajesss.TabIndex = 43;
            this.porcentajesss.Text = "%";
            // 
            // RegistroDSTRS
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 767);
            this.Controls.Add(this.porcentajesss);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidven);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "RegistroDSTRS";
            this.Load += new System.EventHandler(this.RegistroDSTRS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDSTRSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDSTRSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spaDataSetBindingSource;
        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource regDSTRSBindingSource;
        private SpaDataSetTableAdapters.Reg_DSTRSTableAdapter reg_DSTRSTableAdapter;
        private AltoControls.AltoTextBox txtCorreo;
        private AltoControls.AltoTextBox txtTelefonoE;
        private AltoControls.AltoTextBox txtTelefono;
        private AltoControls.AltoTextBox txtnombre;
        private AltoControls.AltoTextBox txtidven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vendedor;
        private AltoControls.AltoTextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.BindingSource regDSTRSBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DISTRIBUIDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_emergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private AltoControls.AltoButton btnGuardar;
        private AltoControls.AltoButton btnEdit;
        private AltoControls.AltoButton btborrar;
        private System.Windows.Forms.Label porcentajesss;
    }
   }
#endregion