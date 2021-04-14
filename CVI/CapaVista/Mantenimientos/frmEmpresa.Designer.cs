
namespace CapaVista.Mantenimientos
{
    partial class frmEmpresa
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
            this.lblIdEmpresa = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblMuni = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtIdPais = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtMunicipalidad = new System.Windows.Forms.TextBox();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbMunicipalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdEmpresa
            // 
            this.lblIdEmpresa.AutoSize = true;
            this.lblIdEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpresa.Location = new System.Drawing.Point(133, 115);
            this.lblIdEmpresa.Name = "lblIdEmpresa";
            this.lblIdEmpresa.Size = new System.Drawing.Size(89, 17);
            this.lblIdEmpresa.TabIndex = 1;
            this.lblIdEmpresa.Text = "ID Empresa";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(47, 149);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(175, 17);
            this.lblNombreEmpresa.TabIndex = 2;
            this.lblNombreEmpresa.Text = "Nombre De La Empresa";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(128, 185);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(94, 17);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "Pais/Region";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(41, 220);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(187, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion De La Empresa";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(119, 254);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(109, 17);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblMuni
            // 
            this.lblMuni.AutoSize = true;
            this.lblMuni.BackColor = System.Drawing.Color.Transparent;
            this.lblMuni.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuni.Location = new System.Drawing.Point(114, 287);
            this.lblMuni.Name = "lblMuni";
            this.lblMuni.Size = new System.Drawing.Size(114, 17);
            this.lblMuni.TabIndex = 6;
            this.lblMuni.Text = "Municipalidad ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(156, 326);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 17);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresa.Location = new System.Drawing.Point(234, 112);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(64, 25);
            this.txtIdEmpresa.TabIndex = 8;
            this.txtIdEmpresa.Tag = "pkIdEmpresa";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(234, 146);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(191, 25);
            this.txtNombreEmpresa.TabIndex = 9;
            this.txtNombreEmpresa.Tag = "nombreEmpresa";
            this.txtNombreEmpresa.TextChanged += new System.EventHandler(this.txtNombreEmpresa_TextChanged);
            // 
            // txtIdPais
            // 
            this.txtIdPais.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPais.Location = new System.Drawing.Point(234, 182);
            this.txtIdPais.Name = "txtIdPais";
            this.txtIdPais.Size = new System.Drawing.Size(49, 25);
            this.txtIdPais.TabIndex = 10;
            this.txtIdPais.Tag = "fkIdPais";
            // 
            // cmbPais
            // 
            this.cmbPais.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(289, 182);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(136, 25);
            this.cmbPais.TabIndex = 11;
            this.cmbPais.Tag = "saltar";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(234, 217);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(191, 25);
            this.txtDireccionEmpresa.TabIndex = 12;
            this.txtDireccionEmpresa.Tag = "direccionDeLugar";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(234, 251);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(49, 25);
            this.txtDepartamento.TabIndex = 13;
            this.txtDepartamento.Tag = "fkIdDepar";
            // 
            // txtMunicipalidad
            // 
            this.txtMunicipalidad.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipalidad.Location = new System.Drawing.Point(234, 284);
            this.txtMunicipalidad.Name = "txtMunicipalidad";
            this.txtMunicipalidad.Size = new System.Drawing.Size(49, 25);
            this.txtMunicipalidad.TabIndex = 14;
            this.txtMunicipalidad.Tag = "fkIdMuni";
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbHabilitado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHabilitado.Location = new System.Drawing.Point(217, 324);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(101, 21);
            this.rbHabilitado.TabIndex = 15;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = false;
            this.rbHabilitado.CheckedChanged += new System.EventHandler(this.rbHabilitado_CheckedChanged);
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbDeshabilitado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeshabilitado.Location = new System.Drawing.Point(324, 324);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(126, 21);
            this.rbDeshabilitado.TabIndex = 16;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = false;
            this.rbDeshabilitado.CheckedChanged += new System.EventHandler(this.rbDeshabilitado_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(50, 323);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 25);
            this.txtEstado.TabIndex = 17;
            this.txtEstado.Tag = "estadoEmpresa";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(467, 102);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(572, 250);
            this.dgvEmpresa.TabIndex = 18;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 84);
            this.navegador1.TabIndex = 19;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(289, 251);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(136, 25);
            this.cmbDepartamento.TabIndex = 20;
            this.cmbDepartamento.Tag = "saltar";
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // cmbMunicipalidad
            // 
            this.cmbMunicipalidad.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipalidad.FormattingEnabled = true;
            this.cmbMunicipalidad.Location = new System.Drawing.Point(289, 284);
            this.cmbMunicipalidad.Name = "cmbMunicipalidad";
            this.cmbMunicipalidad.Size = new System.Drawing.Size(136, 25);
            this.cmbMunicipalidad.TabIndex = 21;
            this.cmbMunicipalidad.Tag = "saltar";
            this.cmbMunicipalidad.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipalidad_SelectedIndexChanged);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.Mantenimiento_Centro_1141515;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 441);
            this.Controls.Add(this.cmbMunicipalidad);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.txtMunicipalidad);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtDireccionEmpresa);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtIdPais);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMuni);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.lblIdEmpresa);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblMuni;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtIdPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtMunicipalidad;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbMunicipalidad;
    }
}