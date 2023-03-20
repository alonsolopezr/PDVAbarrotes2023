namespace WinForm_gamestore_pdv
{
    partial class FormProducto : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtCodBarra = new TextBox();
            comboConsola = new ComboBox();
            txtPrecio = new TextBox();
            pictureBoxImagen = new PictureBox();
            iconCrear = new FontAwesome.Sharp.IconPictureBox();
            iconAñadir = new FontAwesome.Sharp.IconPictureBox();
            iconImagen = new FontAwesome.Sharp.IconPictureBox();
            iconEditar = new FontAwesome.Sharp.IconPictureBox();
            iconBorrar = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            txtImagen = new TextBox();
            panelParaDataGrid = new Panel();
            dataGridProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            COD_BARRA = new DataGridViewTextBoxColumn();
            IMAGEN = new DataGridViewTextBoxColumn();
            UNIDAD = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBuscar = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCrear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconAñadir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBorrar).BeginInit();
            panelParaDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 83);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 1;
            label2.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 199);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(227, 28);
            label4.TabIndex = 3;
            label4.Text = "CODIGO DE BARRA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 256);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 5;
            label6.Text = "CONSOLA";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(269, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(269, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // txtCodBarra
            // 
            txtCodBarra.Enabled = false;
            txtCodBarra.Location = new Point(269, 138);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Size = new Size(206, 27);
            txtCodBarra.TabIndex = 8;
            // 
            // comboConsola
            // 
            comboConsola.Enabled = false;
            comboConsola.FormattingEnabled = true;
            comboConsola.Items.AddRange(new object[] { "XBOX", "PLAYSTATION", "WI", "NINTENDO", "PC" });
            comboConsola.Location = new Point(269, 256);
            comboConsola.Name = "comboConsola";
            comboConsola.Size = new Size(206, 28);
            comboConsola.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(269, 202);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(206, 27);
            txtPrecio.TabIndex = 10;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImage = WinForm_gamestore_pdv2.Properties.Resources.mando_png;
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImagen.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.ErrorImage = WinForm_gamestore_pdv2.Properties.Resources.mando_png;
            pictureBoxImagen.Location = new Point(275, 351);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(200, 161);
            pictureBoxImagen.TabIndex = 11;
            pictureBoxImagen.TabStop = false;
            // 
            // iconCrear
            // 
            iconCrear.BackColor = Color.FromArgb(128, 128, 255);
            iconCrear.BorderStyle = BorderStyle.Fixed3D;
            iconCrear.ForeColor = Color.Blue;
            iconCrear.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconCrear.IconColor = Color.Blue;
            iconCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCrear.IconSize = 47;
            iconCrear.Location = new Point(742, 220);
            iconCrear.Name = "iconCrear";
            iconCrear.Size = new Size(52, 47);
            iconCrear.SizeMode = PictureBoxSizeMode.StretchImage;
            iconCrear.TabIndex = 12;
            iconCrear.TabStop = false;
            iconCrear.Click += iconCrear_Click;
            // 
            // iconAñadir
            // 
            iconAñadir.BackColor = Color.Lime;
            iconAñadir.BorderStyle = BorderStyle.Fixed3D;
            iconAñadir.ForeColor = Color.Green;
            iconAñadir.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconAñadir.IconColor = Color.Green;
            iconAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAñadir.IconSize = 47;
            iconAñadir.Location = new Point(883, 220);
            iconAñadir.Name = "iconAñadir";
            iconAñadir.Size = new Size(52, 47);
            iconAñadir.TabIndex = 13;
            iconAñadir.TabStop = false;
            iconAñadir.Click += iconAñadir_Click;
            // 
            // iconImagen
            // 
            iconImagen.BackColor = SystemColors.ActiveCaption;
            iconImagen.BackgroundImageLayout = ImageLayout.None;
            iconImagen.BorderStyle = BorderStyle.Fixed3D;
            iconImagen.Enabled = false;
            iconImagen.ForeColor = SystemColors.ControlText;
            iconImagen.IconChar = FontAwesome.Sharp.IconChar.Camera;
            iconImagen.IconColor = SystemColors.ControlText;
            iconImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconImagen.IconSize = 49;
            iconImagen.Location = new Point(185, 407);
            iconImagen.Name = "iconImagen";
            iconImagen.Size = new Size(52, 49);
            iconImagen.TabIndex = 14;
            iconImagen.TabStop = false;
            // 
            // iconEditar
            // 
            iconEditar.BackColor = Color.FromArgb(255, 128, 0);
            iconEditar.BorderStyle = BorderStyle.Fixed3D;
            iconEditar.ForeColor = SystemColors.ControlText;
            iconEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconEditar.IconColor = SystemColors.ControlText;
            iconEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditar.IconSize = 47;
            iconEditar.Location = new Point(1024, 222);
            iconEditar.Name = "iconEditar";
            iconEditar.Size = new Size(52, 47);
            iconEditar.TabIndex = 15;
            iconEditar.TabStop = false;
            iconEditar.Click += iconEditar_Click;
            // 
            // iconBorrar
            // 
            iconBorrar.BackColor = Color.Red;
            iconBorrar.BorderStyle = BorderStyle.Fixed3D;
            iconBorrar.ForeColor = SystemColors.ControlText;
            iconBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconBorrar.IconColor = SystemColors.ControlText;
            iconBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBorrar.IconSize = 47;
            iconBorrar.Location = new Point(1168, 220);
            iconBorrar.Name = "iconBorrar";
            iconBorrar.Size = new Size(52, 47);
            iconBorrar.TabIndex = 16;
            iconBorrar.TabStop = false;
            iconBorrar.Click += iconBorrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 310);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 17;
            label7.Text = "IMAGEN";
            // 
            // txtImagen
            // 
            txtImagen.Enabled = false;
            txtImagen.Location = new Point(269, 313);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(206, 27);
            txtImagen.TabIndex = 18;
            // 
            // panelParaDataGrid
            // 
            panelParaDataGrid.BackColor = Color.Transparent;
            panelParaDataGrid.BorderStyle = BorderStyle.Fixed3D;
            panelParaDataGrid.Controls.Add(dataGridProductos);
            panelParaDataGrid.Location = new Point(661, 296);
            panelParaDataGrid.Name = "panelParaDataGrid";
            panelParaDataGrid.Size = new Size(938, 330);
            panelParaDataGrid.TabIndex = 19;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProductos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, descripcion, PRECIO, COD_BARRA, IMAGEN, UNIDAD });
            dataGridProductos.Location = new Point(3, 3);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(923, 301);
            dataGridProductos.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "DESCRIPCIÓN";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 125;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            PRECIO.Width = 125;
            // 
            // COD_BARRA
            // 
            COD_BARRA.HeaderText = "COD_BARRA";
            COD_BARRA.MinimumWidth = 6;
            COD_BARRA.Name = "COD_BARRA";
            COD_BARRA.ReadOnly = true;
            COD_BARRA.Width = 125;
            // 
            // IMAGEN
            // 
            IMAGEN.HeaderText = "IMAGEN";
            IMAGEN.MinimumWidth = 6;
            IMAGEN.Name = "IMAGEN";
            IMAGEN.ReadOnly = true;
            IMAGEN.Width = 125;
            // 
            // UNIDAD
            // 
            UNIDAD.HeaderText = "UNIDAD";
            UNIDAD.MinimumWidth = 6;
            UNIDAD.Name = "UNIDAD";
            UNIDAD.ReadOnly = true;
            UNIDAD.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtImagen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iconImagen);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtCodBarra);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(comboConsola);
            panel1.Location = new Point(2, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 536);
            panel1.TabIndex = 20;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.IndianRed;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = Color.IndianRed;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(1388, 118);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 21;
            iconPictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1137, 123);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(236, 27);
            txtBuscar.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(666, 14);
            label5.Name = "label5";
            label5.Size = new Size(377, 44);
            label5.TabIndex = 23;
            label5.Text = "ALTA DE PRODUCTOS";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1622, 638);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(iconPictureBox1);
            Controls.Add(panel1);
            Controls.Add(panelParaDataGrid);
            Controls.Add(iconBorrar);
            Controls.Add(iconEditar);
            Controls.Add(iconAñadir);
            Controls.Add(iconCrear);
            DoubleBuffered = true;
            Name = "FormProducto";
            Text = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCrear).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconAñadir).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBorrar).EndInit();
            panelParaDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCodBarra;
        private ComboBox comboConsola;
        private TextBox txtPrecio;
        private PictureBox pictureBoxImagen;
        private FontAwesome.Sharp.IconPictureBox iconCrear;
        private FontAwesome.Sharp.IconPictureBox iconAñadir;
        private FontAwesome.Sharp.IconPictureBox iconImagen;
        private FontAwesome.Sharp.IconPictureBox iconEditar;
        private FontAwesome.Sharp.IconPictureBox iconBorrar;
        private Label label7;
        private TextBox txtImagen;
        private Panel panelParaDataGrid;
        private DataGridView dataGridProductos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn COD_BARRA;
        private DataGridViewTextBoxColumn IMAGEN;
        private DataGridViewTextBoxColumn UNIDAD;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtBuscar;
        private Label label5;
    }
}