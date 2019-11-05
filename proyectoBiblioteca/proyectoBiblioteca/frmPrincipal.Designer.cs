namespace proyectoBiblioteca
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mspPrincipal = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penalizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspPrincipal
            // 
            this.mspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.penalizacionesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspPrincipal.Name = "mspPrincipal";
            this.mspPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mspPrincipal.TabIndex = 0;
            this.mspPrincipal.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.rolesToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.usuariosToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem1.Image")));
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesToolStripMenuItem.Image")));
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLibros,
            this.pedidosToolStripMenuItem1,
            this.prestamosToolStripMenuItem1,
            this.editorialesToolStripMenuItem,
            this.autoresToolStripMenuItem});
            this.librosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("librosToolStripMenuItem.Image")));
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.librosToolStripMenuItem.Text = "Biblioteca";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.LibrosToolStripMenuItem_Click);
            // 
            // tsmLibros
            // 
            this.tsmLibros.Image = ((System.Drawing.Image)(resources.GetObject("tsmLibros.Image")));
            this.tsmLibros.Name = "tsmLibros";
            this.tsmLibros.Size = new System.Drawing.Size(180, 22);
            this.tsmLibros.Text = "Libros";
            this.tsmLibros.Click += new System.EventHandler(this.LibrosToolStripMenuItem1_Click);
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pedidosToolStripMenuItem1.Image")));
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pedidosToolStripMenuItem1.Text = "Pedidos";
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("prestamosToolStripMenuItem1.Image")));
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editorialesToolStripMenuItem.Image")));
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorialesToolStripMenuItem.Text = "Editoriales";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autoresToolStripMenuItem.Image")));
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // penalizacionesToolStripMenuItem
            // 
            this.penalizacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("penalizacionesToolStripMenuItem.Image")));
            this.penalizacionesToolStripMenuItem.Name = "penalizacionesToolStripMenuItem";
            this.penalizacionesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.penalizacionesToolStripMenuItem.Text = "Penalizaciones";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // gestiónDeProveedoresToolStripMenuItem
            // 
            this.gestiónDeProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestiónDeProveedoresToolStripMenuItem.Image")));
            this.gestiónDeProveedoresToolStripMenuItem.Name = "gestiónDeProveedoresToolStripMenuItem";
            this.gestiónDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gestiónDeProveedoresToolStripMenuItem.Text = "Gestión de Proveedores";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mspPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ";
            this.mspPrincipal.ResumeLayout(false);
            this.mspPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspPrincipal;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLibros;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penalizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}