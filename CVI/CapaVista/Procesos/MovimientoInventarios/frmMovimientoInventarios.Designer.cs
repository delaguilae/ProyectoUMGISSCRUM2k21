
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
            this.txtIdMovimiento = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAcciones = new System.Windows.Forms.TextBox();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.rbDevClientes = new System.Windows.Forms.RadioButton();
            this.rbMovimientoBodegaBodega = new System.Windows.Forms.RadioButton();
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
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad A Mover";
            // 
            // txtCantMover
            // 
            this.txtCantMover.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMover.Location = new System.Drawing.Point(189, 119);
            this.txtCantMover.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantMover.Name = "txtCantMover";
            this.txtCantMover.Size = new System.Drawing.Size(181, 27);
            this.txtCantMover.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(372, 454);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(485, 454);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 28);
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
            this.dgvMover.Location = new System.Drawing.Point(24, 512);
            this.dgvMover.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMover.Name = "dgvMover";
            this.dgvMover.RowHeadersWidth = 51;
            this.dgvMover.Size = new System.Drawing.Size(896, 208);
            this.dgvMover.TabIndex = 8;
            this.dgvMover.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMover_CellClick);
            // 
            // txtCodBodegaOrigen
            // 
            this.txtCodBodegaOrigen.Enabled = false;
            this.txtCodBodegaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBodegaOrigen.Location = new System.Drawing.Point(137, 103);
            this.txtCodBodegaOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodBodegaOrigen.Name = "txtCodBodegaOrigen";
            this.txtCodBodegaOrigen.Size = new System.Drawing.Size(88, 27);
            this.txtCodBodegaOrigen.TabIndex = 11;
            // 
            // txtDirecBodegaOrigen
            // 
            this.txtDirecBodegaOrigen.Enabled = false;
            this.txtDirecBodegaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecBodegaOrigen.Location = new System.Drawing.Point(137, 139);
            this.txtDirecBodegaOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirecBodegaOrigen.Multiline = true;
            this.txtDirecBodegaOrigen.Name = "txtDirecBodegaOrigen";
            this.txtDirecBodegaOrigen.Size = new System.Drawing.Size(164, 57);
            this.txtDirecBodegaOrigen.TabIndex = 12;
            // 
            // btnBuscarBodegaOrigen
            // 
            this.btnBuscarBodegaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBodegaOrigen.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarBodegaOrigen.Image = global::CapaVista.Properties.Resources.Consultar;
            this.btnBuscarBodegaOrigen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarBodegaOrigen.Location = new System.Drawing.Point(327, 65);
            this.btnBuscarBodegaOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarBodegaOrigen.Name = "btnBuscarBodegaOrigen";
            this.btnBuscarBodegaOrigen.Size = new System.Drawing.Size(109, 66);
            this.btnBuscarBodegaOrigen.TabIndex = 13;
            this.btnBuscarBodegaOrigen.Text = "Buscar";
            this.btnBuscarBodegaOrigen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarBodegaOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarBodegaOrigen.Click += new System.EventHandler(this.btnBuscarBodegaOrigen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtIdMovimiento);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(913, 490);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mover Productos de Bodega a Bodega";
            // 
            // txtIdMovimiento
            // 
            this.txtIdMovimiento.Location = new System.Drawing.Point(31, 436);
            this.txtIdMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMovimiento.Name = "txtIdMovimiento";
            this.txtIdMovimiento.Size = new System.Drawing.Size(132, 27);
            this.txtIdMovimiento.TabIndex = 23;
            this.txtIdMovimiento.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAcciones);
            this.groupBox5.Controls.Add(this.rbVentas);
            this.groupBox5.Controls.Add(this.rbDevClientes);
            this.groupBox5.Controls.Add(this.rbMovimientoBodegaBodega);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(515, 266);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(381, 155);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones";
            // 
            // txtAcciones
            // 
            this.txtAcciones.Location = new System.Drawing.Point(28, 121);
            this.txtAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcciones.Name = "txtAcciones";
            this.txtAcciones.Size = new System.Drawing.Size(132, 27);
            this.txtAcciones.TabIndex = 3;
            this.txtAcciones.Visible = false;
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(28, 96);
            this.rbVentas.Margin = new System.Windows.Forms.Padding(4);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(224, 24);
            this.rbVentas.TabIndex = 2;
            this.rbVentas.Text = "Movimiento De Ventas";
            this.rbVentas.UseVisualStyleBackColor = true;
            this.rbVentas.CheckedChanged += new System.EventHandler(this.rbVentas_CheckedChanged);
            // 
            // rbDevClientes
            // 
            this.rbDevClientes.AutoSize = true;
            this.rbDevClientes.Location = new System.Drawing.Point(28, 65);
            this.rbDevClientes.Margin = new System.Windows.Forms.Padding(4);
            this.rbDevClientes.Name = "rbDevClientes";
            this.rbDevClientes.Size = new System.Drawing.Size(231, 24);
            this.rbDevClientes.TabIndex = 1;
            this.rbDevClientes.Text = "Devolucion De Clientes";
            this.rbDevClientes.UseVisualStyleBackColor = true;
            this.rbDevClientes.CheckedChanged += new System.EventHandler(this.rbDevClientes_CheckedChanged);
            // 
            // rbMovimientoBodegaBodega
            // 
            this.rbMovimientoBodegaBodega.AutoSize = true;
            this.rbMovimientoBodegaBodega.Location = new System.Drawing.Point(28, 34);
            this.rbMovimientoBodegaBodega.Margin = new System.Windows.Forms.Padding(4);
            this.rbMovimientoBodegaBodega.Name = "rbMovimientoBodegaBodega";
            this.rbMovimientoBodegaBodega.Size = new System.Drawing.Size(312, 24);
            this.rbMovimientoBodegaBodega.TabIndex = 0;
            this.rbMovimientoBodegaBodega.Text = "Movimiento De Bodega a Bodega";
            this.rbMovimientoBodegaBodega.UseVisualStyleBackColor = true;
            this.rbMovimientoBodegaBodega.CheckedChanged += new System.EventHandler(this.rbMovimientoBodegaBodega_CheckedChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(460, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(444, 204);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bodega De Destino";
            // 
            // txtIdEmpresaDestino
            // 
            this.txtIdEmpresaDestino.Enabled = false;
            this.txtIdEmpresaDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresaDestino.Location = new System.Drawing.Point(137, 32);
            this.txtIdEmpresaDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpresaDestino.Name = "txtIdEmpresaDestino";
            this.txtIdEmpresaDestino.Size = new System.Drawing.Size(88, 27);
            this.txtIdEmpresaDestino.TabIndex = 19;
            // 
            // txtIdSucursalDestino
            // 
            this.txtIdSucursalDestino.Enabled = false;
            this.txtIdSucursalDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSucursalDestino.Location = new System.Drawing.Point(137, 68);
            this.txtIdSucursalDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSucursalDestino.Name = "txtIdSucursalDestino";
            this.txtIdSucursalDestino.Size = new System.Drawing.Size(88, 27);
            this.txtIdSucursalDestino.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID Bodega";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID Sucursal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "ID Empresa";
            // 
            // txtIdBodegaDestino
            // 
            this.txtIdBodegaDestino.Enabled = false;
            this.txtIdBodegaDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBodegaDestino.Location = new System.Drawing.Point(137, 103);
            this.txtIdBodegaDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBodegaDestino.Name = "txtIdBodegaDestino";
            this.txtIdBodegaDestino.Size = new System.Drawing.Size(88, 27);
            this.txtIdBodegaDestino.TabIndex = 11;
            // 
            // txtDireccBodegaDestino
            // 
            this.txtDireccBodegaDestino.Enabled = false;
            this.txtDireccBodegaDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccBodegaDestino.Location = new System.Drawing.Point(137, 139);
            this.txtDireccBodegaDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccBodegaDestino.Multiline = true;
            this.txtDireccBodegaDestino.Name = "txtDireccBodegaDestino";
            this.txtDireccBodegaDestino.Size = new System.Drawing.Size(164, 57);
            this.txtDireccBodegaDestino.TabIndex = 12;
            this.txtDireccBodegaDestino.TextChanged += new System.EventHandler(this.txtDireccBodegaDestino_TextChanged);
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDestino.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarDestino.Image = global::CapaVista.Properties.Resources.Consultar;
            this.btnBuscarDestino.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarDestino.Location = new System.Drawing.Point(327, 65);
            this.btnBuscarDestino.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(109, 66);
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
            this.groupBox4.Location = new System.Drawing.Point(8, 266);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(499, 155);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto A Mover";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(189, 21);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(40, 27);
            this.txtIdProducto.TabIndex = 21;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Image = global::CapaVista.Properties.Resources.Consultar;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProducto.Location = new System.Drawing.Point(380, 20);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(109, 66);
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
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad Disponible";
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Enabled = false;
            this.txtCantidadDisponible.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDisponible.Location = new System.Drawing.Point(189, 57);
            this.txtCantidadDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(181, 27);
            this.txtCantidadDisponible.TabIndex = 8;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(239, 21);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(132, 27);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(444, 204);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bodega De Origen";
            // 
            // txtIdEmpresaOrigen
            // 
            this.txtIdEmpresaOrigen.Enabled = false;
            this.txtIdEmpresaOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpresaOrigen.Location = new System.Drawing.Point(137, 32);
            this.txtIdEmpresaOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpresaOrigen.Name = "txtIdEmpresaOrigen";
            this.txtIdEmpresaOrigen.Size = new System.Drawing.Size(88, 27);
            this.txtIdEmpresaOrigen.TabIndex = 19;
            this.txtIdEmpresaOrigen.TextChanged += new System.EventHandler(this.txtIdEmpresaOrigen_TextChanged);
            // 
            // txtIdSucursalOrigen
            // 
            this.txtIdSucursalOrigen.Enabled = false;
            this.txtIdSucursalOrigen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSucursalOrigen.Location = new System.Drawing.Point(137, 68);
            this.txtIdSucursalOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSucursalOrigen.Name = "txtIdSucursalOrigen";
            this.txtIdSucursalOrigen.Size = new System.Drawing.Size(88, 27);
            this.txtIdSucursalOrigen.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID Bodega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID Empresa";
            // 
            // frmMovimientoInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMover);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimientoInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento Inventarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovimientoInventarios_FormClosing);
            this.Load += new System.EventHandler(this.frmMovimientoInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.RadioButton rbDevClientes;
        private System.Windows.Forms.RadioButton rbMovimientoBodegaBodega;
        private System.Windows.Forms.TextBox txtAcciones;
        private System.Windows.Forms.TextBox txtIdMovimiento;
    }
}