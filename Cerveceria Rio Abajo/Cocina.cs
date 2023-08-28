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
    public partial class Cocina : Form
    {
        public Cocina()
        {
            InitializeComponent();
        }

        private void Cocina_Load(object sender, EventArgs e)
        {
            btnCocina.Enabled = false;
            cbRecetas.SelectedIndex = 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Frm1 Inicio = new Frm1();

            Inicio.Show();
            this.Hide();
        }

        #region Menu Flotante

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();

            stock.Show();
            this.Hide();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Produccion Prod = new Produccion();

            Prod.Show();
            this.Hide();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FacturacionProveedores Fact = new FacturacionProveedores();

            Fact.Show();
            this.Hide();
        }



        #endregion

        private void btnCocinar_Click(object sender, EventArgs e)
        {
            if (NuevoProceso(cbRecetas.SelectedItem.ToString()) == "1")
            {
                Produccion Prod = new Produccion();

                Prod.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo iniciar el Proceso");
            }

        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            Nueva_Receta NR = new Nueva_Receta();

            NR.Show();
            this.Hide();
        }

        public string NuevoProceso(string Receta)
        {

            string Ok = "";
            return Ok;
        }

        public string NuevaReceta(string Receta)
        {

            string Ok = "";
            return Ok;
        }

    }
}
