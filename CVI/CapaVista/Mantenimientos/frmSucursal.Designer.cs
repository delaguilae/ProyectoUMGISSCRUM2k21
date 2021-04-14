
namespace CapaVista.Mantenimientos
{
    partial class frmSucursal
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
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMuni = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblIdPais = new System.Windows.Forms.Label();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.lblIdEmpresa = new System.Windows.Forms.Label();
            this.lblIdSucursal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtMunicipalidad = new System.Windows.Forms.TextBox();
            this.cmbMunicipalidad = new System.Windows.Forms.ComboBox();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 84);
            this.navegador1.TabIndex = 38;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(97, 325);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(110, 17);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Municipalidad";
            // 
            // lblMuni
            // 
            this.lblMuni.AutoSize = true;
            this.lblMuni.BackColor = System.Drawing.Color.Transparent;
            this.lblMuni.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuni.Location = new System.Drawing.Point(97, 290);
            this.lblMuni.Name = "lblMuni";
            this.lblMuni.Size = new System.Drawing.Size(109, 17);
            this.lblMuni.TabIndex = 25;
            this.lblMuni.Text = "Departamento";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(129, 257);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(78, 17);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Direccion";
            // 
            // lblIdPais
            // 
            this.lblIdPais.AutoSize = true;
            this.lblIdPais.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPais.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPais.Location = new System.Drawing.Point(113, 226);
            this.lblIdPais.Name = "lblIdPais";
            this.lblIdPais.Size = new System.Drawing.Size(94, 17);
            this.lblIdPais.TabIndex = 23;
            this.lblIdPais.Text = "Pais/Region";
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreSucursal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSucursal.Location = new System.Drawing.Point(33, 188);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(174, 17);
            this.lblNombreSucursal.TabIndex = 22;
            this.lblNombreSucursal.Text = "Nombre De La Sucursal";
            // 
            // lblIdEmpresa
            // 
            this.lblIdEmpresa.AutoSize = true;
            this.lblIdEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpresa.Location = new System.Drawing.Point(118, 151);
            this.lblIdEmpresa.Name = "lblIdEmpresa";
            this.lblIdEmpresa.Size = new System.Drawing.Size(89, 17);
            this.lblIdEmpresa.TabIndex = 21;
            this.lblIdEmpresa.Text = "ID Empresa";
            // 
            // lblIdSucursal
            // 
            this.lblIdSucursal.AutoSize = true;
            this.lblIdSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblIdSucursal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSucursal.Location = new System.Drawing.Point(119, 115);
            this.lblIdSucursal.Name = "lblIdSucursal";
            this.lblIdSucursal.Size = new System.Drawing.Size(88, 17);
            this.lblIdSucursal.TabIndex = 20;
            this.lblIdSucursal.Text = "ID Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Estado";
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSucursal.Location = new System.Drawing.Point(213, 112);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(52, 25);
            this.txtIdSucursal.TabIndex = 40;
            this.txtIdSucursal.Tag = "pkIdSucursal";
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresa.Location = new System.Drawing.Point(213, 148);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(52, 25);
            this.txtIdEmpresa.TabIndex = 41;
            this.txtIdEmpresa.Tag = "fkIdEmpresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(271, 148);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(121, 25);
            this.cmbEmpresa.TabIndex = 42;
            this.cmbEmpresa.Tag = "saltar";
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSucursal.Location = new System.Drawing.Point(213, 185);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(179, 25);
            this.txtNombreSucursal.TabIndex = 43;
            this.txtNombreSucursal.Tag = "nombreSucursal";
            this.txtNombreSucursal.TextChanged += new System.EventHandler(this.txtNombreSucursal_TextChanged);
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(213, 223);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(52, 25);
            this.txtPais.TabIndex = 44;
            this.txtPais.Tag = "fkIdPais";
            // 
            // cmbPais
            // 
            this.cmbPais.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(271, 223);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 25);
            this.cmbPais.TabIndex = 45;
            this.cmbPais.Tag = "saltar";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(213, 254);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(179, 25);
            this.txtDireccion.TabIndex = 46;
            this.txtDireccion.Tag = "direccionDeLugar";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(213, 287);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(52, 25);
            this.txtDepartamento.TabIndex = 47;
            this.txtDepartamento.Tag = "fkIdDepar";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(271, 287);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 25);
            this.cmbDepartamento.TabIndex = 48;
            this.cmbDepartamento.Tag = "saltar";
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // txtMunicipalidad
            // 
            this.txtMunicipalidad.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipalidad.Location = new System.Drawing.Point(213, 325);
            this.txtMunicipalidad.Name = "txtMunicipalidad";
            this.txtMunicipalidad.Size = new System.Drawing.Size(52, 25);
            this.txtMunicipalidad.TabIndex = 49;
            this.txtMunicipalidad.Tag = "fkIdMuni";
            // 
            // cmbMunicipalidad
            // 
            this.cmbMunicipalidad.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipalidad.FormattingEnabled = true;
            this.cmbMunicipalidad.Location = new System.Drawing.Point(271, 325);
            this.cmbMunicipalidad.Name = "cmbMunicipalidad";
            this.cmbMunicipalidad.Size = new System.Drawing.Size(121, 25);
            this.cmbMunicipalidad.TabIndex = 50;
            this.cmbMunicipalidad.Tag = "saltar";
            this.cmbMunicipalidad.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipalidad_SelectedIndexChanged);
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbHabilitado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHabilitado.Location = new System.Drawing.Point(159, 360);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(101, 21);
            this.rbHabilitado.TabIndex = 51;
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
            this.rbDeshabilitado.Location = new System.Drawing.Point(266, 360);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(126, 21);
            this.rbDeshabilitado.TabIndex = 52;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = false;
            this.rbDeshabilitado.CheckedChanged += new System.EventHandler(this.rbDeshabilitado_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(25, 359);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(66, 20);
            this.txtEstado.TabIndex = 53;
            this.txtEstado.Tag = "estadoSucursal";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(411, 115);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.Size = new System.Drawing.Size(623, 251);
            this.dgvSucursal.TabIndex = 54;
            // 
            // frmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.Mantenimiento_Centro_1141515;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 467);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.cmbMunicipalidad);
            this.Controls.Add(this.txtMunicipalidad);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.txtIdSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMuni);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblIdPais);
            this.Controls.Add(this.lblNombreSucursal);
            this.Controls.Add(this.lblIdEmpresa);
            this.Controls.Add(this.lblIdSucursal);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMuni;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblIdPais;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.Label lblIdEmpresa;
        private System.Windows.Forms.Label lblIdSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtMunicipalidad;
        private System.Windows.Forms.ComboBox cmbMunicipalidad;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvSucursal;
    }
}