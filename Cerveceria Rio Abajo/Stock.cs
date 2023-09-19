﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerveceria_Rio_Abajo
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        public void btnAtras_Click(object sender, EventArgs e)
        {
            Frm1 Inicio = new Frm1();
            Inicio.Show();
            this.Hide();
        }

        #region Menu Flotante

        public void toolStripMenuItem2_Click(object sender, EventArgs e) //Boton Produccion
        {
            Produccion Prod = new Produccion();

            Prod.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) //Boton Cocina
        {
            Cocina Coc = new Cocina();

            Coc.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturacionProveedores Fc = new FacturacionProveedores();

            Fc.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion_Clientes Fc = new Facturacion_Clientes();

            Fc.Show();
            this.Hide();
        }

        #endregion

        private void Stock_Load(object sender, EventArgs e)
        {
            btnStock.Enabled = false;
            CargarDGV();
        }

        public void CargarDGV()
        {

        }
    }
}
