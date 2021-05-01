
namespace CapaVista.Procesos.MovimientoInventarios
{
    partial class frmMovimientoInventarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantMover = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMover = new System.Windows.Forms.DataGridView();
            this.txtCodBodegaOrigen = new System.Windows.Forms.TextBox();
            this.txtDirecBodegaOrigen = new System.Windows.Forms.TextBox();
            this.btnBuscarBodegaOrigen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRealizarCambios = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdEmpresaDestino = new System.Windows.Forms.TextBox();
            this.txtIdSucursalDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdBodegaDestino = new System.Windows.Forms.TextBox();
            this.txtDireccBodegaDestino = new System.Windows.Forms.TextBox();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdEmpresaOrigen = new System.Windows.Forms.TextBox();
            this.txtIdSucursalOrigen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad A Mover";
            // 
            // txtCantMover
            // 
            this.txtCantMover.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMover.Location = new System.Drawing.Point(142, 97);
            this.txtCantMover.Name = "txtCantMover";
            this.txtCantMover.Size = new System.Drawing.Size(137, 23);
            this.txtCantMover.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(162, 369);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(247, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvMover
            // 
            this.dgvMover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMover.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMover.Location = new System.Drawing.Point(18, 416);
            this.dgvMover.Name = "dgvMover";
            this.dgvMover.Size = new System.Drawing.Size(672, 169);
            this.dgvMover.TabIndex = 8;
            // 
            // txtCodBodegaOrigen
            // 
            this.txtCodBodegaOrigen.Enabled = false;
            this.txtCodBodegaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBodegaOrigen.Location = new System.Drawing.Point(103, 84);
            this.txtCodBodegaOrigen.Name = "txtCodBodegaOrigen";
            this.txtCodBodegaOrigen.Size = new System.Drawing.Size(67, 23);
            this.txtCodBodegaOrigen.TabIndex = 11;
            // 
            // txtDirecBodegaOrigen
            // 
            this.txtDirecBodegaOrigen.Enabled = false;
            this.txtDirecBodegaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecBodegaOrigen.Location = new System.Drawing.Point(103, 113);
            this.txtDirecBodegaOrigen.Multiline = true;
            this.txtDirecBodegaOrigen.Name = "txtDirecBodegaOrigen";
            this.txtDirecBodegaOrigen.Size = new System.Drawing.Size(124, 47);
            this.txtDirecBodegaOrigen.TabIndex = 12;
            // 
            // btnBuscarBodegaOrigen
            // 
            this.btnBuscarBodegaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBodegaOrigen.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarBodegaOrigen.Image = global::CapaVista.Properties.Resources.Consultar;
            this.btnBuscarBodegaOrigen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarBodegaOrigen.Location = new System.Drawing.Point(245, 53);
            this.btnBuscarBodegaOrigen.Name = "btnBuscarBodegaOrigen";
            this.btnBuscarBodegaOrigen.Size = new System.Drawing.Size(82, 54);
            this.btnBuscarBodegaOrigen.TabIndex = 13;
            this.btnBuscarBodegaOrigen.Text = "Buscar";
            this.btnBuscarBodegaOrigen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarBodegaOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarBodegaOrigen.Click += new System.EventHandler(this.btnBuscarBodegaOrigen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRealizarCambios);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 398);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mover Productos de Bodega a Bodega";
            // 
            // btnRealizarCambios
            // 
            this.btnRealizarCambios.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarCambios.Location = new System.Drawing.Point(332, 369);
            this.btnRealizarCambios.Name = "btnRealizarCambios";
            this.btnRealizarCambios.Size = new System.Drawing.Size(167, 23);
            this.btnRealizarCambios.TabIndex = 21;
            this.btnRealizarCambios.Text = "Realizar Movimientos";
            this.btnRealizarCambios.UseVisualStyleBackColor = true;
            this.btnRealizarCambios.Click += new System.EventHandler(this.btnRealizarCambios_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdEmpresaDestino);
            this.groupBox3.Controls.Add(this.txtIdSucursalDestino);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtIdBodegaDestino);
            this.groupBox3.Controls.Add(this.txtDireccBodegaDestino);
            this.groupBox3.Controls.Add(this.btnBuscarDestino);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(345, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 166);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bodega De Destino";
            // 
            // txtIdEmpresaDestino
            // 
            this.txtIdEmpresaDestino.Enabled = false;
            this.txtIdEmpresaDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresaDestino.Location = new System.Drawing.Point(103, 26);
            this.txtIdEmpresaDestino.Name = "txtIdEmpresaDestino";
            this.txtIdEmpresaDestino.Size = new System.Drawing.Size(67, 23);
            this.txtIdEmpresaDestino.TabIndex = 19;
            // 
            // txtIdSucursalDestino
            // 
            this.txtIdSucursalDestino.Enabled = false;
            this.txtIdSucursalDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSucursalDestino.Location = new System.Drawing.Point(103, 55);
            this.txtIdSucursalDestino.Name = "txtIdSucursalDestino";
            this.txtIdSucursalDestino.Size = new System.Drawing.Size(67, 23);
            this.txtIdSucursalDestino.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID Bodega";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID Sucursal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "ID Empresa";
            // 
            // txtIdBodegaDestino
            // 
            this.txtIdBodegaDestino.Enabled = false;
            this.txtIdBodegaDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBodegaDestino.Location = new System.Drawing.Point(103, 84);
            this.txtIdBodegaDestino.Name = "txtIdBodegaDestino";
            this.txtIdBodegaDestino.Size = new System.Drawing.Size(67, 23);
            this.txtIdBodegaDestino.TabIndex = 11;
            // 
            // txtDireccBodegaDestino
            // 
            this.txtDireccBodegaDestino.Enabled = false;
            this.txtDireccBodegaDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccBodegaDestino.Location = new System.Drawing.Point(103, 113);
            this.txtDireccBodegaDestino.Multiline = true;
            this.txtDireccBodegaDestino.Name = "txtDireccBodegaDestino";
            this.txtDireccBodegaDestino.Size = new System.Drawing.Size(124, 47);
            this.txtDireccBodegaDestino.TabIndex = 12;
            this.txtDireccBodegaDestino.TextChanged += new System.EventHandler(this.txtDireccBodegaDestino_TextChanged);
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDestino.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarDestino.Image = global::CapaVista.Properties.Resources.Consultar;
            this.btnBuscarDestino.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarDestino.Location = new System.Drawing.Point(245, 53);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(82, 54);
            this.btnBuscarDestino.TabIndex = 13;
            this.btnBuscarDestino.Text = "Buscar";
            this.btnBuscarDestino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarDestino.UseVisualStyleBackColor = true;
            this.btnBuscarDestino.Click += new System.EventHandler(this.btnBuscarDestino_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtIdProducto);
            this.groupBox4.Controls.Add(this.btnBuscarProducto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtCantidadDisponible);
            this.groupBox4.Controls.Add(this.txtProducto);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCantMover);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(141, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 126);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto A Mover";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(142, 17);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(31, 23);
            this.txtIdProducto.TabIndex = 21;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Image = global::CapaVista.Properties.Resources.Consultar;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProducto.Location = new System.Drawing.Point(285, 16);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(82, 54);
            this.btnBuscarProducto.TabIndex = 20;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad Disponible";
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Enabled = false;
            this.txtCantidadDisponible.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDisponible.Location = new System.Drawing.Point(142, 46);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(137, 23);
            this.txtCantidadDisponible.TabIndex = 8;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(179, 17);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 23);
            this.txtProducto.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdEmpresaOrigen);
            this.groupBox2.Controls.Add(this.txtIdSucursalOrigen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCodBodegaOrigen);
            this.groupBox2.Controls.Add(this.txtDirecBodegaOrigen);
            this.groupBox2.Controls.Add(this.btnBuscarBodegaOrigen);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 166);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bodega De Origen";
            // 
            // txtIdEmpresaOrigen
            // 
            this.txtIdEmpresaOrigen.Enabled = false;
            this.txtIdEmpresaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresaOrigen.Location = new System.Drawing.Point(103, 26);
            this.txtIdEmpresaOrigen.Name = "txtIdEmpresaOrigen";
            this.txtIdEmpresaOrigen.Size = new System.Drawing.Size(67, 23);
            this.txtIdEmpresaOrigen.TabIndex = 19;
            // 
            // txtIdSucursalOrigen
            // 
            this.txtIdSucursalOrigen.Enabled = false;
            this.txtIdSucursalOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSucursalOrigen.Location = new System.Drawing.Point(103, 55);
            this.txtIdSucursalOrigen.Name = "txtIdSucursalOrigen";
            this.txtIdSucursalOrigen.Size = new System.Drawing.Size(67, 23);
            this.txtIdSucursalOrigen.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID Bodega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID Empresa";
            // 
            // frmMovimientoInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(709, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMover);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimientoInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento Inventarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovimientoInventarios_FormClosing);
            this.Load += new System.EventHandler(this.frmMovimientoInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantMover;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMover;
        private System.Windows.Forms.TextBox txtDirecBodegaOrigen;
        private System.Windows.Forms.TextBox txtCodBodegaOrigen;
        private System.Windows.Forms.Button btnBuscarBodegaOrigen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.TextBox txtIdEmpresaOrigen;
        private System.Windows.Forms.TextBox txtIdSucursalOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdEmpresaDestino;
        private System.Windows.Forms.TextBox txtIdSucursalDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdBodegaDestino;
        private System.Windows.Forms.TextBox txtDireccBodegaDestino;
        private System.Windows.Forms.Button btnBuscarDestino;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Button btnRealizarCambios;
    }
}