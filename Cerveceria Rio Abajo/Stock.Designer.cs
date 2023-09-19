
namespace Cerveceria_Rio_Abajo
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvMateriaPrima = new System.Windows.Forms.DataGridView();
            this.MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMateriaPrima = new System.Windows.Forms.Label();
            this.lblProductoFinal = new System.Windows.Forms.Label();
            this.dgvProductoFinal = new System.Windows.Forms.DataGridView();
            this.ProductoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NºLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContenedores = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Contenedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarContenedor = new System.Windows.Forms.TextBox();
            this.MFlotante = new System.Windows.Forms.MenuStrip();
            this.btnStock = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.MFlotante.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 663);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvMateriaPrima
            // 
            this.dgvMateriaPrima.AllowUserToAddRows = false;
            this.dgvMateriaPrima.AllowUserToDeleteRows = false;
            this.dgvMateriaPrima.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.dgvMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaPrima,
            this.Cantidad,
            this.FechaDeIngreso});
            this.dgvMateriaPrima.Location = new System.Drawing.Point(12, 102);
            this.dgvMateriaPrima.Name = "dgvMateriaPrima";
            this.dgvMateriaPrima.ReadOnly = true;
            this.dgvMateriaPrima.Size = new System.Drawing.Size(395, 159);
            this.dgvMateriaPrima.TabIndex = 1;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.HeaderText = "Materia Prima";
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.ReadOnly = true;
            this.MateriaPrima.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // FechaDeIngreso
            // 
            this.FechaDeIngreso.HeaderText = "Fecha De Ingreso";
            this.FechaDeIngreso.Name = "FechaDeIngreso";
            this.FechaDeIngreso.ReadOnly = true;
            // 
            // lblMateriaPrima
            // 
            this.lblMateriaPrima.AutoSize = true;
            this.lblMateriaPrima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.lblMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrima.Location = new System.Drawing.Point(12, 74);
            this.lblMateriaPrima.Name = "lblMateriaPrima";
            this.lblMateriaPrima.Size = new System.Drawing.Size(145, 25);
            this.lblMateriaPrima.TabIndex = 3;
            this.lblMateriaPrima.Text = "Materia Prima";
            // 
            // lblProductoFinal
            // 
            this.lblProductoFinal.AutoSize = true;
            this.lblProductoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.lblProductoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoFinal.Location = new System.Drawing.Point(12, 264);
            this.lblProductoFinal.Name = "lblProductoFinal";
            this.lblProductoFinal.Size = new System.Drawing.Size(151, 25);
            this.lblProductoFinal.TabIndex = 4;
            this.lblProductoFinal.Text = "Producto Final";
            // 
            // dgvProductoFinal
            // 
            this.dgvProductoFinal.AllowUserToAddRows = false;
            this.dgvProductoFinal.AllowUserToDeleteRows = false;
            this.dgvProductoFinal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.dgvProductoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoFinal,
            this.CantidadPF,
            this.NºLote,
            this.FechaDeFinalizacion});
            this.dgvProductoFinal.Location = new System.Drawing.Point(12, 292);
            this.dgvProductoFinal.Name = "dgvProductoFinal";
            this.dgvProductoFinal.ReadOnly = true;
            this.dgvProductoFinal.Size = new System.Drawing.Size(444, 159);
            this.dgvProductoFinal.TabIndex = 5;
            // 
            // ProductoFinal
            // 
            this.ProductoFinal.HeaderText = "Producto Final";
            this.ProductoFinal.Name = "ProductoFinal";
            this.ProductoFinal.ReadOnly = true;
            this.ProductoFinal.Width = 200;
            // 
            // CantidadPF
            // 
            this.CantidadPF.HeaderText = "Cantidad(L)";
            this.CantidadPF.Name = "CantidadPF";
            this.CantidadPF.ReadOnly = true;
            this.CantidadPF.Width = 50;
            // 
            // NºLote
            // 
            this.NºLote.HeaderText = "Nº De Lote";
            this.NºLote.Name = "NºLote";
            this.NºLote.ReadOnly = true;
            this.NºLote.Width = 50;
            // 
            // FechaDeFinalizacion
            // 
            this.FechaDeFinalizacion.HeaderText = "Fecha De Finalizacion";
            this.FechaDeFinalizacion.Name = "FechaDeFinalizacion";
            this.FechaDeFinalizacion.ReadOnly = true;
            // 
            // lblContenedores
            // 
            this.lblContenedores.AutoSize = true;
            this.lblContenedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.lblContenedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenedores.Location = new System.Drawing.Point(12, 454);
            this.lblContenedores.Name = "lblContenedores";
            this.lblContenedores.Size = new System.Drawing.Size(148, 25);
            this.lblContenedores.TabIndex = 6;
            this.lblContenedores.Text = "Contenedores";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contenedor,
            this.Libre,
            this.Ocupado,
            this.Entregados,
            this.Total});
            this.dataGridView3.Location = new System.Drawing.Point(12, 482);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(485, 159);
            this.dataGridView3.TabIndex = 7;
            // 
            // Contenedor
            // 
            this.Contenedor.HeaderText = "Contenedor";
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.ReadOnly = true;
            this.Contenedor.Width = 200;
            // 
            // Libre
            // 
            this.Libre.HeaderText = "Libres";
            this.Libre.Name = "Libre";
            this.Libre.ReadOnly = true;
            this.Libre.Width = 50;
            // 
            // Ocupado
            // 
            this.Ocupado.HeaderText = "Ocupados";
            this.Ocupado.Name = "Ocupado";
            this.Ocupado.ReadOnly = true;
            this.Ocupado.Width = 70;
            // 
            // Entregados
            // 
            this.Entregados.HeaderText = "Entregados";
            this.Entregados.Name = "Entregados";
            this.Entregados.ReadOnly = true;
            this.Entregados.Width = 70;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 50;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 40);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Casa";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(413, 172);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(202, 20);
            this.txtBuscarMateria.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(462, 368);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(202, 20);
            this.txtBuscarProducto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buscar";
            // 
            // txtBuscarContenedor
            // 
            this.txtBuscarContenedor.Location = new System.Drawing.Point(503, 556);
            this.txtBuscarContenedor.Name = "txtBuscarContenedor";
            this.txtBuscarContenedor.Size = new System.Drawing.Size(202, 20);
            this.txtBuscarContenedor.TabIndex = 16;
            // 
            // MFlotante
            // 
            this.MFlotante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MFlotante.AutoSize = false;
            this.MFlotante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.MFlotante.Dock = System.Windows.Forms.DockStyle.None;
            this.MFlotante.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MFlotante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStock,
            this.produccionToolStripMenuItem,
            this.cocinaToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.MFlotante.Location = new System.Drawing.Point(297, 9);
            this.MFlotante.Name = "MFlotante";
            this.MFlotante.Size = new System.Drawing.Size(288, 39);
            this.MFlotante.TabIndex = 18;
            this.MFlotante.Text = "menuStrip1";
            // 
            // btnStock
            // 
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(48, 35);
            this.btnStock.Text = "Stock";
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(80, 35);
            this.produccionToolStripMenuItem.Text = "Produccion";
            // 
            // cocinaToolStripMenuItem
            // 
            this.cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
            this.cocinaToolStripMenuItem.Size = new System.Drawing.Size(56, 35);
            this.cocinaToolStripMenuItem.Text = "Cocina";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 35);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 663);
            this.ControlBox = false;
            this.Controls.Add(this.MFlotante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscarContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarMateria);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblContenedores);
            this.Controls.Add(this.dgvProductoFinal);
            this.Controls.Add(this.lblProductoFinal);
            this.Controls.Add(this.lblMateriaPrima);
            this.Controls.Add(this.dgvMateriaPrima);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.MFlotante.ResumeLayout(false);
            this.MFlotante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMateriaPrima;
        private System.Windows.Forms.Label lblMateriaPrima;
        private System.Windows.Forms.Label lblProductoFinal;
        private System.Windows.Forms.DataGridView dgvProductoFinal;
        private System.Windows.Forms.Label lblContenedores;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NºLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarContenedor;
        private System.Windows.Forms.MenuStrip MFlotante;
        private System.Windows.Forms.ToolStripMenuItem btnStock;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
    }
}