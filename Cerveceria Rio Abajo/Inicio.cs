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

        #region Diccionario
        /// <summary>
        /// 
        /// 
        /// </summary>
#endregion

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

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion Fact = new Facturacion();

            Fact.Show();
            this.Hide();
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
