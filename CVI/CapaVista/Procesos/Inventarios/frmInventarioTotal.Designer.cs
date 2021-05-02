
namespace CapaVista.Procesos.Inventarios
{
    partial class frmInventarioTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioTotal));
            this.dgvInventarioT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbExistencia = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.rbExistencia = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventarioT
            // 
            this.dgvInventarioT.AllowUserToAddRows = false;
            this.dgvInventarioT.ColumnHeadersHeight = 29;
            this.dgvInventarioT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvInventarioT.Location = new System.Drawing.Point(355, 70);
            this.dgvInventarioT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventarioT.Name = "dgvInventarioT";
            this.dgvInventarioT.ReadOnly = true;
            this.dgvInventarioT.RowHeadersWidth = 51;
            this.dgvInventarioT.RowTemplate.Height = 24;
            this.dgvInventarioT.Size = new System.Drawing.Size(804, 356);
            this.dgvInventarioT.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empresa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bodega";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Existencia";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Maxima";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Minima";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(143, 88);
            this.cmbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(181, 28);
            this.cmbEmpresa.TabIndex = 1;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            this.cmbEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmpresa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empresa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cbExistencia);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.rbExistencia);
            this.groupBox1.Controls.Add(this.rbProducto);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(300, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cbExistencia
            // 
            this.cbExistencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExistencia.FormattingEnabled = true;
            this.cbExistencia.Items.AddRange(new object[] {
            "MINIMA",
            "MAXIMA"});
            this.cbExistencia.Location = new System.Drawing.Point(143, 71);
            this.cbExistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbExistencia.Name = "cbExistencia";
            this.cbExistencia.Size = new System.Drawing.Size(140, 28);
            this.cbExistencia.TabIndex = 6;
            this.cbExistencia.SelectedIndexChanged += new System.EventHandler(this.cbExistencia_SelectedIndexChanged);
            this.cbExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbExistencia_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(143, 39);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(140, 27);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // rbExistencia
            // 
            this.rbExistencia.AutoSize = true;
            this.rbExistencia.Location = new System.Drawing.Point(15, 76);
            this.rbExistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbExistencia.Name = "rbExistencia";
            this.rbExistencia.Size = new System.Drawing.Size(115, 24);
            this.rbExistencia.TabIndex = 1;
            this.rbExistencia.TabStop = true;
            this.rbExistencia.Text = "Existencia ";
            this.rbExistencia.UseVisualStyleBackColor = true;
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(15, 39);
            this.rbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(101, 24);
            this.rbProducto.TabIndex = 0;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bodega";
            // 
            // cmbBodega
            // 
            this.cmbBodega.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(143, 123);
            this.cmbBodega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(181, 28);
            this.cmbBodega.TabIndex = 4;
            this.cmbBodega.SelectedIndexChanged += new System.EventHandler(this.cmbBodega_SelectedIndexChanged);
            this.cmbBodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBodega_KeyPress);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.button5);
            this.bunifuGradientPanel1.Controls.Add(this.lblEmpresa);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(35)))), ((int)(((byte)(7)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(35)))), ((int)(((byte)(7)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1198, 47);
            this.bunifuGradientPanel1.TabIndex = 37;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(5, 20);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(11, 17);
            this.lblEmpresa.TabIndex = 42;
            this.lblEmpresa.Text = "l";
            this.lblEmpresa.Visible = false;
            this.lblEmpresa.Click += new System.EventHandler(this.lblEmpresa_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(183, 398);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 28);
            this.button3.TabIndex = 40;
            this.button3.Text = "Indicadores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "INVENTARIO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Mostrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(29, 157);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(295, 28);
            this.button4.TabIndex = 41;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1146, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 47);
            this.button5.TabIndex = 43;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmInventarioTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 453);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBodega);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.dgvInventarioT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInventarioTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventarioTotal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbExistencia;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.RadioButton rbExistencia;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBodega;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvInventarioT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button button5;
    }
}