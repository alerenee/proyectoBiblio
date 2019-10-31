namespace proyectoBiblioteca
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.pbxPass = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTituloBajo = new System.Windows.Forms.LinkLabel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(135, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INICIAR SESIÓN";
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(95, 244);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(41, 38);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 1;
            this.pbxUsuario.TabStop = false;
            // 
            // pbxPass
            // 
            this.pbxPass.Image = ((System.Drawing.Image)(resources.GetObject("pbxPass.Image")));
            this.pbxPass.Location = new System.Drawing.Point(95, 297);
            this.pbxPass.Name = "pbxPass";
            this.pbxPass.Size = new System.Drawing.Size(41, 38);
            this.pbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPass.TabIndex = 2;
            this.pbxPass.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(165, 258);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(165, 311);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(184, 20);
            this.txtPass.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(77, 371);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIniciar.Size = new System.Drawing.Size(138, 54);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(243, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(138, 54);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblTituloBajo
            // 
            this.lblTituloBajo.AutoSize = true;
            this.lblTituloBajo.Location = new System.Drawing.Point(126, 455);
            this.lblTituloBajo.Name = "lblTituloBajo";
            this.lblTituloBajo.Size = new System.Drawing.Size(196, 13);
            this.lblTituloBajo.TabIndex = 7;
            this.lblTituloBajo.TabStop = true;
            this.lblTituloBajo.Text = "Si no tienes una cuenta, registrate aquí.";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(119, 57);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 165);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 489);
            this.ControlBox = false;
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTituloBajo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbxPass);
            this.Controls.Add(this.pbxUsuario);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.PictureBox pbxPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.LinkLabel lblTituloBajo;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

