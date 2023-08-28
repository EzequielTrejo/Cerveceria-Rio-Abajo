
namespace Cerveceria_Rio_Abajo
{
    partial class Cocina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cocina));
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.cbRecetas = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStock = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCocina = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAUtilizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCocinar = new System.Windows.Forms.Button();
            this.btnReceta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBLogo
            // 
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(608, 450);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 2;
            this.PBLogo.TabStop = false;
            // 
            // cbRecetas
            // 
            this.cbRecetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecetas.FormattingEnabled = true;
            this.cbRecetas.Items.AddRange(new object[] {
            "Seleccione una Receta",
            "1",
            "2"});
            this.cbRecetas.Location = new System.Drawing.Point(12, 75);
            this.cbRecetas.Name = "cbRecetas";
            this.cbRecetas.Size = new System.Drawing.Size(121, 21);
            this.cbRecetas.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStock,
            this.btnProduccion,
            this.btnCocina,
            this.btnFacturacion});
            this.menuStrip1.Location = new System.Drawing.Point(179, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 39);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnStock
            // 
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(48, 35);
            this.btnStock.Text = "Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(80, 35);
            this.btnProduccion.Text = "Produccion";
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            // 
            // btnCocina
            // 
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(56, 35);
            this.btnCocina.Text = "Cocina";
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(81, 35);
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 40);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Casa";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.CantidadAUtilizar,
            this.CantidadDisponible});
            this.dataGridView1.Location = new System.Drawing.Point(168, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(305, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // CantidadAUtilizar
            // 
            this.CantidadAUtilizar.HeaderText = "Cantidad a Utilizar";
            this.CantidadAUtilizar.Name = "CantidadAUtilizar";
            this.CantidadAUtilizar.ReadOnly = true;
            this.CantidadAUtilizar.Width = 80;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "Cantidad Disponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.ReadOnly = true;
            this.CantidadDisponible.Width = 80;
            // 
            // btnCocinar
            // 
            this.btnCocinar.Location = new System.Drawing.Point(168, 273);
            this.btnCocinar.Name = "btnCocinar";
            this.btnCocinar.Size = new System.Drawing.Size(75, 44);
            this.btnCocinar.TabIndex = 14;
            this.btnCocinar.Text = "Iniciar";
            this.btnCocinar.UseVisualStyleBackColor = true;
            this.btnCocinar.Click += new System.EventHandler(this.btnCocinar_Click);
            // 
            // btnReceta
            // 
            this.btnReceta.Location = new System.Drawing.Point(392, 273);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(75, 44);
            this.btnReceta.TabIndex = 15;
            this.btnReceta.Text = "Nueva Receta";
            this.btnReceta.UseVisualStyleBackColor = true;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnReceta);
            this.Controls.Add(this.btnCocinar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cbRecetas);
            this.Controls.Add(this.PBLogo);
            this.Name = "Cocina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocina";
            this.Load += new System.EventHandler(this.Cocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.ComboBox cbRecetas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnStock;
        private System.Windows.Forms.ToolStripMenuItem btnProduccion;
        private System.Windows.Forms.ToolStripMenuItem btnCocina;
        private System.Windows.Forms.ToolStripMenuItem btnFacturacion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAUtilizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.Button btnCocinar;
        private System.Windows.Forms.Button btnReceta;
    }
}