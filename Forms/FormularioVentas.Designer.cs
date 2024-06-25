namespace SPA_ARUMA.Forms
{
    partial class FormularioVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spaDataSet = new SPA_ARUMA.SpaDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtid = new AltoControls.AltoTextBox();
            this.NombreC = new AltoControls.AltoTextBox();
            this.txtnombre = new AltoControls.AltoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexistencia = new AltoControls.AltoTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new AltoControls.AltoTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.altoButton2 = new AltoControls.AltoButton();
            this.altoButton3 = new AltoControls.AltoButton();
            this.productosTableAdapter = new SPA_ARUMA.SpaDataSetTableAdapters.productosTableAdapter();
            this.slideButton1 = new AltoControls.SlideButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Descuento = new System.Windows.Forms.Label();
            this.porcentaje = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SlideDesc = new AltoControls.SlideButton();
            this.txtDesc = new AltoControls.AltoTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEscaner = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion,
            this.precioo,
            this.existencia});
            this.dataGridView1.DataSource = this.productosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(851, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // precioo
            // 
            this.precioo.DataPropertyName = "precio";
            this.precioo.HeaderText = "precio";
            this.precioo.Name = "precioo";
            // 
            // existencia
            // 
            this.existencia.DataPropertyName = "existencia";
            this.existencia.HeaderText = "existencia";
            this.existencia.Name = "existencia";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.spaDataSetBindingSource;
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(608, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.AllowDrop = true;
            this.txtid.BackColor = System.Drawing.Color.Transparent;
            this.txtid.Br = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(236, 244);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(135, 33);
            this.txtid.TabIndex = 11;
            // 
            // NombreC
            // 
            this.NombreC.BackColor = System.Drawing.Color.Transparent;
            this.NombreC.Br = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.NombreC.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.NombreC.ForeColor = System.Drawing.Color.Black;
            this.NombreC.Location = new System.Drawing.Point(236, 301);
            this.NombreC.Name = "NombreC";
            this.NombreC.Size = new System.Drawing.Size(135, 33);
            this.NombreC.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Transparent;
            this.txtnombre.Br = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(236, 355);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(135, 33);
            this.txtnombre.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "NOMBRE DEL CLIENTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "PRODUCTO:";
            // 
            // txtexistencia
            // 
            this.txtexistencia.BackColor = System.Drawing.Color.Transparent;
            this.txtexistencia.Br = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtexistencia.Enabled = false;
            this.txtexistencia.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtexistencia.ForeColor = System.Drawing.Color.Black;
            this.txtexistencia.Location = new System.Drawing.Point(327, 595);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(63, 33);
            this.txtexistencia.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "EXISTENCIA:";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.Transparent;
            this.txtprecio.Br = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtprecio.ForeColor = System.Drawing.Color.Black;
            this.txtprecio.Location = new System.Drawing.Point(236, 415);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(135, 33);
            this.txtprecio.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "PRECIO:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.eliminar,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Importe,
            this.Fecha,
            this.hora});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(465, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(701, 271);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(53, 589);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton2.ForeColor = System.Drawing.Color.Black;
            this.altoButton2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.altoButton2.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.altoButton2.Location = new System.Drawing.Point(816, 573);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(130, 30);
            this.altoButton2.Stroke = false;
            this.altoButton2.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton2.TabIndex = 28;
            this.altoButton2.Text = "IMPRIMIR";
            this.altoButton2.Transparency = false;
            this.altoButton2.Click += new System.EventHandler(this.altoButton2_Click);
            // 
            // altoButton3
            // 
            this.altoButton3.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton3.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton3.BackColor = System.Drawing.Color.Transparent;
            this.altoButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton3.ForeColor = System.Drawing.Color.Black;
            this.altoButton3.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.altoButton3.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.altoButton3.Location = new System.Drawing.Point(615, 573);
            this.altoButton3.Name = "altoButton3";
            this.altoButton3.Radius = 10;
            this.altoButton3.Size = new System.Drawing.Size(152, 30);
            this.altoButton3.Stroke = false;
            this.altoButton3.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton3.TabIndex = 29;
            this.altoButton3.Text = "GUARDAR";
            this.altoButton3.Transparency = false;
            this.altoButton3.Click += new System.EventHandler(this.altoButton3_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // slideButton1
            // 
            this.slideButton1.BorderColor = System.Drawing.Color.LightGray;
            this.slideButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideButton1.IsOn = false;
            this.slideButton1.Location = new System.Drawing.Point(295, 472);
            this.slideButton1.Name = "slideButton1";
            this.slideButton1.Size = new System.Drawing.Size(66, 35);
            this.slideButton1.TabIndex = 30;
            this.slideButton1.Text = "slideButton1";
            this.slideButton1.TextEnabled = true;
            this.slideButton1.Click += new System.EventHandler(this.slideButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "¿SE APLICA DESCUENTO?";
            // 
            // Descuento
            // 
            this.Descuento.AutoSize = true;
            this.Descuento.BackColor = System.Drawing.Color.Transparent;
            this.Descuento.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuento.Location = new System.Drawing.Point(208, 643);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(114, 22);
            this.Descuento.TabIndex = 34;
            this.Descuento.Text = "DESCUENTO:";
            // 
            // porcentaje
            // 
            this.porcentaje.AutoSize = true;
            this.porcentaje.BackColor = System.Drawing.Color.Transparent;
            this.porcentaje.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje.Location = new System.Drawing.Point(390, 639);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(29, 26);
            this.porcentaje.TabIndex = 36;
            this.porcentaje.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "DESCUENTO A DISTRIBUIDOR:";
            // 
            // SlideDesc
            // 
            this.SlideDesc.BorderColor = System.Drawing.Color.LightGray;
            this.SlideDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideDesc.IsOn = false;
            this.SlideDesc.Location = new System.Drawing.Point(295, 523);
            this.SlideDesc.Name = "SlideDesc";
            this.SlideDesc.Size = new System.Drawing.Size(66, 35);
            this.SlideDesc.TabIndex = 38;
            this.SlideDesc.Text = "slideButton2";
            this.SlideDesc.TextEnabled = true;
            this.SlideDesc.Click += new System.EventHandler(this.slideButton2_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.Br = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(327, 634);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(63, 33);
            this.txtDesc.TabIndex = 35;
            this.txtDesc.Click += new System.EventHandler(this.txtDesc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1342, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "PRODUCTOS DISPONIBLES:";
            // 
            // txtEscaner
            // 
            this.txtEscaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtEscaner.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscaner.ForeColor = System.Drawing.Color.Black;
            this.txtEscaner.Location = new System.Drawing.Point(621, 76);
            this.txtEscaner.Multiline = true;
            this.txtEscaner.Name = "txtEscaner";
            this.txtEscaner.Size = new System.Drawing.Size(274, 28);
            this.txtEscaner.TabIndex = 40;
            this.txtEscaner.TextChanged += new System.EventHandler(this.txtEscaner_TextChanged_1);
            this.txtEscaner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEscaner_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(684, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "ESCANEA AQUÍ:";
            // 
            // idd
            // 
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            this.idd.Visible = false;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "ELIMINAR";
            this.eliminar.Name = "eliminar";
            this.eliminar.Text = "X";
            this.eliminar.Width = 91;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "PRODUCTO";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "PRECIO";
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "IMPORTE";
            this.Importe.Name = "Importe";
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 85;
            // 
            // hora
            // 
            this.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hora.HeaderText = "HORA";
            this.hora.Name = "hora";
            this.hora.Width = 79;
            // 
            // FormularioVentas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1376, 699);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEscaner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SlideDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.Descuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slideButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.altoButton3);
            this.Controls.Add(this.altoButton2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.NombreC);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "FormularioVentas";
            this.Load += new System.EventHandler(this.FormularioVentas_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularioVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spaDataSetBindingSource;
        private SpaDataSet spaDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private SpaDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AltoControls.AltoTextBox txtid;
        private AltoControls.AltoTextBox NombreC;
        private AltoControls.AltoTextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoTextBox txtexistencia;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AltoControls.AltoButton altoButton2;
        private AltoControls.AltoButton altoButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioo;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private AltoControls.SlideButton slideButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Descuento;
        private System.Windows.Forms.Label porcentaje;
        private System.Windows.Forms.Label label6;
        private AltoControls.SlideButton SlideDesc;
        private AltoControls.AltoTextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEscaner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
} 
#endregion