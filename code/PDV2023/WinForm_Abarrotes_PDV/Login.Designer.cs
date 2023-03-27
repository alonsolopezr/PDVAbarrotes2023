namespace pruebaVENTA
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CancelarLogin = new System.Windows.Forms.Button();
            this.AceptarLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelarLogin
            // 
            this.CancelarLogin.FlatAppearance.BorderSize = 0;
            this.CancelarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarLogin.ForeColor = System.Drawing.Color.White;
            this.CancelarLogin.Image = ((System.Drawing.Image)(resources.GetObject("CancelarLogin.Image")));
            this.CancelarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarLogin.Location = new System.Drawing.Point(69, 299);
            this.CancelarLogin.Name = "CancelarLogin";
            this.CancelarLogin.Size = new System.Drawing.Size(168, 48);
            this.CancelarLogin.TabIndex = 0;
            this.CancelarLogin.Text = "Cancelar";
            this.CancelarLogin.UseVisualStyleBackColor = true;
            this.CancelarLogin.Click += new System.EventHandler(this.CancelarLogin_Click);
            // 
            // AceptarLogin
            // 
            this.AceptarLogin.FlatAppearance.BorderSize = 0;
            this.AceptarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AceptarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptarLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarLogin.ForeColor = System.Drawing.Color.White;
            this.AceptarLogin.Image = ((System.Drawing.Image)(resources.GetObject("AceptarLogin.Image")));
            this.AceptarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarLogin.Location = new System.Drawing.Point(308, 299);
            this.AceptarLogin.Name = "AceptarLogin";
            this.AceptarLogin.Size = new System.Drawing.Size(174, 48);
            this.AceptarLogin.TabIndex = 1;
            this.AceptarLogin.Text = "Aceptar";
            this.AceptarLogin.UseVisualStyleBackColor = true;
            this.AceptarLogin.Click += new System.EventHandler(this.AceptarLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(73, 135);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(115, 33);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Usuario:";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(173, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(129, 42);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Text = "LOGIN";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(12, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 33);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(194, 148);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(196, 20);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(194, 201);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(196, 20);
            this.textboxPassword.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(506, 413);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.AceptarLogin);
            this.Controls.Add(this.CancelarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarLogin;
        private System.Windows.Forms.Button AceptarLogin;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textboxPassword;
    }
}

