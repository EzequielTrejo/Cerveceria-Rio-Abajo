
namespace Cerveceria_Rio_Abajo
{
    partial class Nueva_Receta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Receta));
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.NombreProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionDelProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbListaProcesos = new System.Windows.Forms.ComboBox();
            this.btnCrearNuevoProceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // PBLogo
            // 
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(661, 450);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 3;
            this.PBLogo.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnAtras.Location = new System.Drawing.Point(192, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(174, 40);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Casa";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de la nueva receta";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(228, 105);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(245, 20);
            this.txtNombreReceta.TabIndex = 14;
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProceso,
            this.DuracionDelProceso,
            this.MateriaPrima,
            this.CantidadMateria});
            this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 274);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(445, 150);
            this.dgvVistaPrevia.TabIndex = 16;
            // 
            // NombreProceso
            // 
            this.NombreProceso.HeaderText = "Nombre";
            this.NombreProceso.Name = "NombreProceso";
            this.NombreProceso.ReadOnly = true;
            // 
            // DuracionDelProceso
            // 
            this.DuracionDelProceso.HeaderText = "Duracion";
            this.DuracionDelProceso.Name = "DuracionDelProceso";
            this.DuracionDelProceso.ReadOnly = true;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.HeaderText = "Materia Prima";
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.ReadOnly = true;
            // 
            // CantidadMateria
            // 
            this.CantidadMateria.HeaderText = "Cantidad Necesaria";
            this.CantidadMateria.Name = "CantidadMateria";
            this.CantidadMateria.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(228, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 21);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(479, 274);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(162, 150);
            this.btnFinalizar.TabIndex = 26;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cbListaProcesos
            // 
            this.cbListaProcesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaProcesos.FormattingEnabled = true;
            this.cbListaProcesos.Items.AddRange(new object[] {
            "Seleccionar un Proceso",
            "Minuto/s",
            "Hora/s",
            "Dia/s"});
            this.cbListaProcesos.Location = new System.Drawing.Point(12, 176);
            this.cbListaProcesos.Name = "cbListaProcesos";
            this.cbListaProcesos.Size = new System.Drawing.Size(210, 21);
            this.cbListaProcesos.TabIndex = 27;
            // 
            // btnCrearNuevoProceso
            // 
            this.btnCrearNuevoProceso.Location = new System.Drawing.Point(12, 212);
            this.btnCrearNuevoProceso.Name = "btnCrearNuevoProceso";
            this.btnCrearNuevoProceso.Size = new System.Drawing.Size(291, 36);
            this.btnCrearNuevoProceso.TabIndex = 28;
            this.btnCrearNuevoProceso.Text = "Crear Nuevo Proceso";
            this.btnCrearNuevoProceso.UseVisualStyleBackColor = true;
            this.btnCrearNuevoProceso.Click += new System.EventHandler(this.btnCrearNuevoProceso_Click);
            // 
            // Nueva_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.btnCrearNuevoProceso);
            this.Controls.Add(this.cbListaProcesos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.PBLogo);
            this.Name = "Nueva_Receta";
            this.Text = "Nueva_Receta";
            this.Load += new System.EventHandler(this.Nueva_Receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cbListaProcesos;
        private System.Windows.Forms.Button btnCrearNuevoProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionDelProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMateria;
    }
}