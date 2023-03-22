namespace WinForm_Abarrotes_PDV
{
    partial class Form1
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
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(55, 137);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(199, 137);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(125, 27);
            txtDesc.TabIndex = 1;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(484, 137);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(125, 27);
            txtCodBarras.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(340, 137);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 2;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(623, 137);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(125, 27);
            txtImagen.TabIndex = 4;
            // 
            // comboPresentacion
            // 
            comboPresentacion.FormattingEnabled = true;
            comboPresentacion.Items.AddRange(new object[] { "CAJA", "KILO", "LITRO", "PIEZA" });
            comboPresentacion.Location = new Point(930, 137);
            comboPresentacion.Name = "comboPresentacion";
            comboPresentacion.Size = new Size(151, 28);
            comboPresentacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 101);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 101);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 7;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 101);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 101);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 9;
            label4.Text = "Cod Barrar";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(773, 138);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 101);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 11;
            label5.Text = "Imgen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(802, 101);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 12;
            label6.Text = "Marca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(970, 101);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 13;
            label7.Text = "Presentacion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(55, 208);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(1026, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 509);
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
            Name = "Form1";
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
    }
}