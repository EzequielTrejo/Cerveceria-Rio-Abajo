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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Frm1 Inicio = new Frm1();

            Inicio.Show();
            this.Hide();
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            btnProduccion.Enabled = false;
            CargarDGV();
        }

        #region Menu Flotante

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();

            stock.Show();
            this.Hide();
        }

        private void cocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cocina Coc = new Cocina();

            Coc.Show();
            this.Hide();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturacionProveedores Fact = new FacturacionProveedores();

            Fact.Show();
            this.Hide();
        }

        #endregion

        public void CargarDGV()
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProduccionDetalles PD = new ProduccionDetalles();

            PD.Show();
        }
    }
}
