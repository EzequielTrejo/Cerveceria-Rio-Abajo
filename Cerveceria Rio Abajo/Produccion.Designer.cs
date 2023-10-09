
namespace Cerveceria_Rio_Abajo
{
    partial class Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produccion));
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.MFlotante = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.cocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RecetasCompletadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMateriaPrima = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RecetaEnProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcesoActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioDelProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizaProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDeLaReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Listo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MFlotante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PBLogo
            // 
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(776, 431);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 2;
            this.PBLogo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecetaEnProceso,
            this.ProcesoActivo,
            this.InicioDelProceso,
            this.FinalizaProceso,
            this.TiempoRestante,
            this.EstadoDeLaReceta,
            this.Listo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 40);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Casa";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // MFlotante
            // 
            this.MFlotante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MFlotante.AutoSize = false;
            this.MFlotante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.MFlotante.Dock = System.Windows.Forms.DockStyle.None;
            this.MFlotante.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MFlotante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.btnProduccion,
            this.cocinaToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.MFlotante.Location = new System.Drawing.Point(246, 9);
            this.MFlotante.Name = "MFlotante";
            this.MFlotante.Size = new System.Drawing.Size(288, 39);
            this.MFlotante.TabIndex = 11;
            this.MFlotante.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 35);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(80, 35);
            this.btnProduccion.Text = "Produccion";
            // 
            // cocinaToolStripMenuItem
            // 
            this.cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
            this.cocinaToolStripMenuItem.Size = new System.Drawing.Size(56, 35);
            this.cocinaToolStripMenuItem.Text = "Cocina";
            this.cocinaToolStripMenuItem.Click += new System.EventHandler(this.cocinaToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 35);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecetasCompletadas,
            this.FechaDeFinalizacion,
            this.CantidadL,
            this.Estado});
            this.dataGridView2.Location = new System.Drawing.Point(12, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(394, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // RecetasCompletadas
            // 
            this.RecetasCompletadas.HeaderText = "Recetas Completadas";
            this.RecetasCompletadas.Name = "RecetasCompletadas";
            this.RecetasCompletadas.ReadOnly = true;
            // 
            // FechaDeFinalizacion
            // 
            this.FechaDeFinalizacion.HeaderText = "Fecha De Finalizacion";
            this.FechaDeFinalizacion.Name = "FechaDeFinalizacion";
            this.FechaDeFinalizacion.ReadOnly = true;
            this.FechaDeFinalizacion.Width = 80;
            // 
            // CantidadL
            // 
            this.CantidadL.HeaderText = "Cantidad (L)";
            this.CantidadL.Name = "CantidadL";
            this.CantidadL.ReadOnly = true;
            this.CantidadL.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // lblMateriaPrima
            // 
            this.lblMateriaPrima.AutoSize = true;
            this.lblMateriaPrima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.lblMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrima.Location = new System.Drawing.Point(12, 62);
            this.lblMateriaPrima.Name = "lblMateriaPrima";
            this.lblMateriaPrima.Size = new System.Drawing.Size(205, 25);
            this.lblMateriaPrima.TabIndex = 13;
            this.lblMateriaPrima.Text = "Recetas en Proceso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recetas Finalizadas";
            // 
            // RecetaEnProceso
            // 
            this.RecetaEnProceso.HeaderText = "Receta En Proceso";
            this.RecetaEnProceso.Name = "RecetaEnProceso";
            this.RecetaEnProceso.ReadOnly = true;
            // 
            // ProcesoActivo
            // 
            this.ProcesoActivo.HeaderText = "Proceso Activo";
            this.ProcesoActivo.Name = "ProcesoActivo";
            this.ProcesoActivo.ReadOnly = true;
            // 
            // InicioDelProceso
            // 
            this.InicioDelProceso.HeaderText = "Inicio Del Proceso";
            this.InicioDelProceso.Name = "InicioDelProceso";
            this.InicioDelProceso.ReadOnly = true;
            // 
            // FinalizaProceso
            // 
            this.FinalizaProceso.HeaderText = "Finalizacion Del Proceso";
            this.FinalizaProceso.Name = "FinalizaProceso";
            this.FinalizaProceso.ReadOnly = true;
            // 
            // TiempoRestante
            // 
            this.TiempoRestante.HeaderText = "Tiempo Restante";
            this.TiempoRestante.Name = "TiempoRestante";
            this.TiempoRestante.ReadOnly = true;
            // 
            // EstadoDeLaReceta
            // 
            this.EstadoDeLaReceta.HeaderText = "Estado Actual";
            this.EstadoDeLaReceta.Name = "EstadoDeLaReceta";
            this.EstadoDeLaReceta.ReadOnly = true;
            // 
            // Listo
            // 
            this.Listo.HeaderText = "Listo";
            this.Listo.Name = "Listo";
            this.Listo.ReadOnly = true;
            this.Listo.Width = 50;
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 431);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMateriaPrima);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MFlotante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PBLogo);
            this.Name = "Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.Produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MFlotante.ResumeLayout(false);
            this.MFlotante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.MenuStrip MFlotante;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnProduccion;
        private System.Windows.Forms.ToolStripMenuItem cocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecetasCompletadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblMateriaPrima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecetaEnProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcesoActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioDelProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizaProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeLaReceta;
        private System.Windows.Forms.DataGridViewButtonColumn Listo;
    }
}