
namespace CapaVista
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMunicipioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContrasenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimiendoAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionPerfilYAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoModuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionAPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.mantenimientoLineaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMarcaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.windowsMenu,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(56, 24);
            this.fileMenu.Text = "Abrir";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.mantenimientoPaisToolStripMenuItem,
            this.mantenimientoDepartamentoToolStripMenuItem,
            this.mantenimientoMunicipioToolStripMenuItem,
            this.mantenimientoLineaProductoToolStripMenuItem,
            this.mantenimientoMarcaProductoToolStripMenuItem,
            this.mantenimientoClienteToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.mantenimientosToolStripMenuItem.Text = "Catalogos";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento Proveedores";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // mantenimientoPaisToolStripMenuItem
            // 
            this.mantenimientoPaisToolStripMenuItem.Name = "mantenimientoPaisToolStripMenuItem";
            this.mantenimientoPaisToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoPaisToolStripMenuItem.Text = "Mantenimiento Pais";
            this.mantenimientoPaisToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPaisToolStripMenuItem_Click);
            // 
            // mantenimientoDepartamentoToolStripMenuItem
            // 
            this.mantenimientoDepartamentoToolStripMenuItem.Name = "mantenimientoDepartamentoToolStripMenuItem";
            this.mantenimientoDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoDepartamentoToolStripMenuItem.Text = "Mantenimiento Departamento";
            this.mantenimientoDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDepartamentoToolStripMenuItem_Click);
            // 
            // mantenimientoMunicipioToolStripMenuItem
            // 
            this.mantenimientoMunicipioToolStripMenuItem.Name = "mantenimientoMunicipioToolStripMenuItem";
            this.mantenimientoMunicipioToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoMunicipioToolStripMenuItem.Text = "Mantenimiento Municipio ";
            this.mantenimientoMunicipioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoMunicipioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.reportesToolStripMenuItem.Text = "Informes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContrasenaToolStripMenuItem,
            this.mantenimientoDeUsuarioToolStripMenuItem,
            this.mantenimiendoAplicacionesToolStripMenuItem,
            this.asignacionPerfilYAplicacionesToolStripMenuItem,
            this.mantenimientoModuloToolStripMenuItem,
            this.perfilesToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambioDeContrasenaToolStripMenuItem
            // 
            this.cambioDeContrasenaToolStripMenuItem.Name = "cambioDeContrasenaToolStripMenuItem";
            this.cambioDeContrasenaToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.cambioDeContrasenaToolStripMenuItem.Text = "0011-Cambio de Contrasena";
            this.cambioDeContrasenaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContrasenaToolStripMenuItem_Click);
            // 
            // mantenimientoDeUsuarioToolStripMenuItem
            // 
            this.mantenimientoDeUsuarioToolStripMenuItem.Name = "mantenimientoDeUsuarioToolStripMenuItem";
            this.mantenimientoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.mantenimientoDeUsuarioToolStripMenuItem.Text = "0002-Mantenimiento de Usuario";
            this.mantenimientoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuarioToolStripMenuItem_Click);
            // 
            // mantenimiendoAplicacionesToolStripMenuItem
            // 
            this.mantenimiendoAplicacionesToolStripMenuItem.Name = "mantenimiendoAplicacionesToolStripMenuItem";
            this.mantenimiendoAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.mantenimiendoAplicacionesToolStripMenuItem.Text = "0003- Mantenimiendo Aplicaciones";
            this.mantenimiendoAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.mantenimiendoAplicacionesToolStripMenuItem_Click);
            // 
            // asignacionPerfilYAplicacionesToolStripMenuItem
            // 
            this.asignacionPerfilYAplicacionesToolStripMenuItem.Name = "asignacionPerfilYAplicacionesToolStripMenuItem";
            this.asignacionPerfilYAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.asignacionPerfilYAplicacionesToolStripMenuItem.Text = "0006-Asignacion Perfil y Aplicaciones";
            this.asignacionPerfilYAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionPerfilYAplicacionesToolStripMenuItem_Click);
            // 
            // mantenimientoModuloToolStripMenuItem
            // 
            this.mantenimientoModuloToolStripMenuItem.Name = "mantenimientoModuloToolStripMenuItem";
            this.mantenimientoModuloToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.mantenimientoModuloToolStripMenuItem.Text = "0008-Mantenimiento Modulo";
            this.mantenimientoModuloToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoModuloToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoAPerfilToolStripMenuItem,
            this.asignacionDeAplicacionAPerfilToolStripMenuItem});
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // mantenimientoAPerfilToolStripMenuItem
            // 
            this.mantenimientoAPerfilToolStripMenuItem.Name = "mantenimientoAPerfilToolStripMenuItem";
            this.mantenimientoAPerfilToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.mantenimientoAPerfilToolStripMenuItem.Text = "0004- Mantenimiento a Perfil";
            this.mantenimientoAPerfilToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoAPerfilToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionAPerfilToolStripMenuItem
            // 
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Name = "asignacionDeAplicacionAPerfilToolStripMenuItem";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Text = "0005- Asignacion de Aplicacion a Perfil";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeAplicacionAPerfilToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(84, 24);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 572);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1227, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(708, 2);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(132, 22);
            this.txtusuario.TabIndex = 4;
            // 
            // mantenimientoLineaProductoToolStripMenuItem
            // 
            this.mantenimientoLineaProductoToolStripMenuItem.Name = "mantenimientoLineaProductoToolStripMenuItem";
            this.mantenimientoLineaProductoToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoLineaProductoToolStripMenuItem.Text = "Mantenimiento Linea Producto";
            this.mantenimientoLineaProductoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoLineaProductoToolStripMenuItem_Click);
            // 
            // mantenimientoMarcaProductoToolStripMenuItem
            // 
            this.mantenimientoMarcaProductoToolStripMenuItem.Name = "mantenimientoMarcaProductoToolStripMenuItem";
            this.mantenimientoMarcaProductoToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoMarcaProductoToolStripMenuItem.Text = "Mantenimiento Marca Producto";
            this.mantenimientoMarcaProductoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoMarcaProductoToolStripMenuItem_Click);
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            this.mantenimientoClienteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1227, 598);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIPrincipal";
            this.Text = "CVI Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContrasenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionPerfilYAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoModuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionAPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimiendoAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMunicipioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoLineaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMarcaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
    }
}



