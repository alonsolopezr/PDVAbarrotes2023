namespace WinForm_Abarrotes_PDV
{
    partial class Guardar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guardar));
            txtNom = new TextBox();
            txtDesc = new TextBox();
            txtCodBarras = new TextBox();
            txtPrecio = new TextBox();
            txtImagen = new TextBox();
            comboPresentacion = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            txtProductos = new Label();
            button1 = new Button();
            btnCancelarGuardar = new Button();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(48, 103);
            txtNom.Margin = new Padding(3, 2, 3, 2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(110, 23);
            txtNom.TabIndex = 0;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(174, 103);
            txtDesc.Margin = new Padding(3, 2, 3, 2);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(110, 23);
            txtDesc.TabIndex = 1;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(424, 103);
            txtCodBarras.Margin = new Padding(3, 2, 3, 2);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(110, 23);
            txtCodBarras.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(298, 103);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(545, 103);
            txtImagen.Margin = new Padding(3, 2, 3, 2);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(110, 23);
            txtImagen.TabIndex = 4;
            // 
            // comboPresentacion
            // 
            comboPresentacion.FormattingEnabled = true;
            comboPresentacion.Items.AddRange(new object[] { "CAJA", "KILO", "LITRO", "PIEZA" });
            comboPresentacion.Location = new Point(814, 103);
            comboPresentacion.Margin = new Padding(3, 2, 3, 2);
            comboPresentacion.Name = "comboPresentacion";
            comboPresentacion.Size = new Size(133, 23);
            comboPresentacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 76);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 76);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 7;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(332, 76);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 8;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(439, 76);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 9;
            label4.Text = "Cod Barrar";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(676, 104);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(568, 76);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 11;
            label5.Text = "Imagen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(702, 76);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 12;
            label6.Text = "Marca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(835, 76);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 13;
            label7.Text = "Presentacion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(48, 291);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(898, 22);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtProductos
            // 
            txtProductos.AutoSize = true;
            txtProductos.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductos.Location = new Point(401, 9);
            txtProductos.Margin = new Padding(4, 0, 4, 0);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(157, 36);
            txtProductos.TabIndex = 15;
            txtProductos.Text = "Productos";
            txtProductos.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(88, 161, 200);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(516, 319);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(292, 52);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancelarGuardar
            // 
            btnCancelarGuardar.BackColor = Color.FromArgb(88, 161, 200);
            btnCancelarGuardar.FlatAppearance.BorderSize = 0;
            btnCancelarGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCancelarGuardar.FlatStyle = FlatStyle.Flat;
            btnCancelarGuardar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarGuardar.ForeColor = Color.White;
            btnCancelarGuardar.Image = (Image)resources.GetObject("btnCancelarGuardar.Image");
            btnCancelarGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarGuardar.Location = new Point(174, 318);
            btnCancelarGuardar.Margin = new Padding(4, 3, 4, 3);
            btnCancelarGuardar.Name = "btnCancelarGuardar";
            btnCancelarGuardar.Size = new Size(292, 52);
            btnCancelarGuardar.TabIndex = 31;
            btnCancelarGuardar.Text = "Cancelar";
            btnCancelarGuardar.UseVisualStyleBackColor = false;
            // 
            // Guardar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 81, 209);
            ClientSize = new Size(1015, 382);
            Controls.Add(btnCancelarGuardar);
            Controls.Add(button1);
            Controls.Add(txtProductos);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboPresentacion);
            Controls.Add(txtImagen);
            Controls.Add(txtCodBarras);
            Controls.Add(txtPrecio);
            Controls.Add(txtDesc);
            Controls.Add(txtNom);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Guardar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtDesc;
        private TextBox txtCodBarras;
        private TextBox txtPrecio;
        private TextBox txtImagen;
        private ComboBox comboPresentacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMarca;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGuardar;
        private Label txtProductos;
        private Button button1;
        private Button btnCancelarGuardar;
    }
}