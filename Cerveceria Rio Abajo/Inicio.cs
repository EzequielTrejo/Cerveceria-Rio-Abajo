using System;
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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Menu Flotante

        public void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock Stock = new Stock();

            Stock.Show();
            this.Hide();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produccion Prod = new Produccion();

            Prod.Show();
            this.Hide();
        }

        private void cocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cocina Coc = new Cocina();

            Coc.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion_Clientes Fc = new Facturacion_Clientes();

            Fc.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturacionProveedores Fc = new FacturacionProveedores();

            Fc.Show();
            this.Hide();
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
