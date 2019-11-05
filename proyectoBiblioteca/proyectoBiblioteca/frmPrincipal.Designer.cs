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
            this.librosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penalizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeÚltimosMesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosMásPrestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectorDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClasificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspPrincipal
            // 
            this.mspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.librosToolStripMenuItem,
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
            this.librosToolStripMenuItem1,
            this.pedidosToolStripMenuItem1,
            this.prestamosToolStripMenuItem1,
            this.editorialesToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.penalizacionesToolStripMenuItem});
            this.librosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("librosToolStripMenuItem.Image")));
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.librosToolStripMenuItem.Text = "Biblioteca";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.LibrosToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem1
            // 
            this.librosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("librosToolStripMenuItem1.Image")));
            this.librosToolStripMenuItem1.Name = "librosToolStripMenuItem1";
            this.librosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.librosToolStripMenuItem1.Text = "Libros";
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
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeLibrosToolStripMenuItem,
            this.reportesDeProveedoresToolStripMenuItem,
            this.reporteDeEmpleadosToolStripMenuItem,
            this.gráficosToolStripMenuItem,
            this.comprasDeÚltimosMesesToolStripMenuItem,
            this.librosMásPrestadosToolStripMenuItem,
            this.lectorDelMesToolStripMenuItem,
            this.libroDelMesToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // penalizacionesToolStripMenuItem
            // 
            this.penalizacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("penalizacionesToolStripMenuItem.Image")));
            this.penalizacionesToolStripMenuItem.Name = "penalizacionesToolStripMenuItem";
            this.penalizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.penalizacionesToolStripMenuItem.Text = "Penalizaciones";
            // 
            // reporteDeLibrosToolStripMenuItem
            // 
            this.reporteDeLibrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porTemaToolStripMenuItem,
            this.porAutorToolStripMenuItem,
            this.porEspecialidadToolStripMenuItem,
            this.porClasificaciónToolStripMenuItem});
            this.reporteDeLibrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeLibrosToolStripMenuItem.Image")));
            this.reporteDeLibrosToolStripMenuItem.Name = "reporteDeLibrosToolStripMenuItem";
            this.reporteDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.reporteDeLibrosToolStripMenuItem.Text = "Reporte de libros";
            // 
            // reportesDeProveedoresToolStripMenuItem
            // 
            this.reportesDeProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesDeProveedoresToolStripMenuItem.Image")));
            this.reportesDeProveedoresToolStripMenuItem.Name = "reportesDeProveedoresToolStripMenuItem";
            this.reportesDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.reportesDeProveedoresToolStripMenuItem.Text = "Reportes de proveedores";
            // 
            // reporteDeEmpleadosToolStripMenuItem
            // 
            this.reporteDeEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeEmpleadosToolStripMenuItem.Image")));
            this.reporteDeEmpleadosToolStripMenuItem.Name = "reporteDeEmpleadosToolStripMenuItem";
            this.reporteDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.reporteDeEmpleadosToolStripMenuItem.Text = "Reporte de empleados";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gráficosToolStripMenuItem.Image")));
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gráficosToolStripMenuItem.Text = "Gráficos de prestamos";
            // 
            // comprasDeÚltimosMesesToolStripMenuItem
            // 
            this.comprasDeÚltimosMesesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasDeÚltimosMesesToolStripMenuItem.Image")));
            this.comprasDeÚltimosMesesToolStripMenuItem.Name = "comprasDeÚltimosMesesToolStripMenuItem";
            this.comprasDeÚltimosMesesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.comprasDeÚltimosMesesToolStripMenuItem.Text = "Compras de últimos meses";
            // 
            // librosMásPrestadosToolStripMenuItem
            // 
            this.librosMásPrestadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("librosMásPrestadosToolStripMenuItem.Image")));
            this.librosMásPrestadosToolStripMenuItem.Name = "librosMásPrestadosToolStripMenuItem";
            this.librosMásPrestadosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.librosMásPrestadosToolStripMenuItem.Text = "Libros más prestados";
            // 
            // lectorDelMesToolStripMenuItem
            // 
            this.lectorDelMesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lectorDelMesToolStripMenuItem.Image")));
            this.lectorDelMesToolStripMenuItem.Name = "lectorDelMesToolStripMenuItem";
            this.lectorDelMesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.lectorDelMesToolStripMenuItem.Text = "Lector del mes";
            // 
            // libroDelMesToolStripMenuItem
            // 
            this.libroDelMesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("libroDelMesToolStripMenuItem.Image")));
            this.libroDelMesToolStripMenuItem.Name = "libroDelMesToolStripMenuItem";
            this.libroDelMesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.libroDelMesToolStripMenuItem.Text = "Libro del mes";
            // 
            // porTemaToolStripMenuItem
            // 
            this.porTemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porTemaToolStripMenuItem.Image")));
            this.porTemaToolStripMenuItem.Name = "porTemaToolStripMenuItem";
            this.porTemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porTemaToolStripMenuItem.Text = "Por tema";
            // 
            // porAutorToolStripMenuItem
            // 
            this.porAutorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porAutorToolStripMenuItem.Image")));
            this.porAutorToolStripMenuItem.Name = "porAutorToolStripMenuItem";
            this.porAutorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porAutorToolStripMenuItem.Text = "Por autor";
            // 
            // porEspecialidadToolStripMenuItem
            // 
            this.porEspecialidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porEspecialidadToolStripMenuItem.Image")));
            this.porEspecialidadToolStripMenuItem.Name = "porEspecialidadToolStripMenuItem";
            this.porEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porEspecialidadToolStripMenuItem.Text = "Por especialidad";
            // 
            // porClasificaciónToolStripMenuItem
            // 
            this.porClasificaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porClasificaciónToolStripMenuItem.Image")));
            this.porClasificaciónToolStripMenuItem.Name = "porClasificaciónToolStripMenuItem";
            this.porClasificaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porClasificaciónToolStripMenuItem.Text = "Por clasificación";
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
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penalizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClasificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeÚltimosMesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosMásPrestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectorDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroDelMesToolStripMenuItem;
    }
}