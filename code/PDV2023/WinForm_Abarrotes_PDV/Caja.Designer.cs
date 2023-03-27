namespace WinForm_Abarrotes_PDV
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            txtCodBarras = new TextBox();
            numericCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dGridVentas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtSubtotal = new TextBox();
            txtIva = new TextBox();
            txtTotal = new TextBox();
            txtEfectivo = new TextBox();
            btnPagar = new Button();
            btnCancelarpago = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridVentas).BeginInit();
            SuspendLayout();
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(59, 12);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(277, 23);
            txtCodBarras.TabIndex = 0;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(351, 12);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(35, 23);
            numericCantidad.TabIndex = 1;
            numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(401, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(37, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dGridVentas
            // 
            dGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridVentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dGridVentas.Location = new Point(21, 64);
            dGridVentas.Name = "dGridVentas";
            dGridVentas.RowTemplate.Height = 25;
            dGridVentas.Size = new Size(487, 194);
            dGridVentas.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "NOMBRE";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "PRECIO";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "CANT";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "SUBTOTAL";
            Column5.Name = "Column5";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(413, 264);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 4;
            // 
            // txtIva
            // 
            txtIva.Location = new Point(413, 293);
            txtIva.Name = "txtIva";
            txtIva.Size = new Size(100, 23);
            txtIva.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(413, 322);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 6;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(21, 293);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(100, 23);
            txtEfectivo.TabIndex = 7;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(88, 161, 200);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Image = (Image)resources.GetObject("btnPagar.Image");
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(195, 273);
            btnPagar.Margin = new Padding(4, 3, 4, 3);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(141, 43);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarpago
            // 
            btnCancelarpago.BackColor = Color.FromArgb(88, 161, 200);
            btnCancelarpago.FlatAppearance.BorderSize = 0;
            btnCancelarpago.FlatAppearance.MouseOverBackColor = Color.Green;
            btnCancelarpago.FlatStyle = FlatStyle.Flat;
            btnCancelarpago.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarpago.ForeColor = Color.White;
            btnCancelarpago.Image = (Image)resources.GetObject("btnCancelarpago.Image");
            btnCancelarpago.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarpago.Location = new Point(195, 322);
            btnCancelarpago.Margin = new Padding(4, 3, 4, 3);
            btnCancelarpago.Name = "btnCancelarpago";
            btnCancelarpago.Size = new Size(141, 43);
            btnCancelarpago.TabIndex = 9;
            btnCancelarpago.Text = "  Cancelar";
            btnCancelarpago.UseVisualStyleBackColor = false;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 81, 209);
            ClientSize = new Size(590, 418);
            Controls.Add(btnCancelarpago);
            Controls.Add(btnPagar);
            Controls.Add(txtEfectivo);
            Controls.Add(txtTotal);
            Controls.Add(txtIva);
            Controls.Add(txtSubtotal);
            Controls.Add(dGridVentas);
            Controls.Add(btnAgregar);
            Controls.Add(numericCantidad);
            Controls.Add(txtCodBarras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Caja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodBarras;
        private NumericUpDown numericCantidad;
        private Button btnAgregar;
        private DataGridView dGridVentas;
        private TextBox txtSubtotal;
        private TextBox txtIva;
        private TextBox txtTotal;
        private TextBox txtEfectivo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnPagar;
        private Button btnCancelarpago;
    }
}