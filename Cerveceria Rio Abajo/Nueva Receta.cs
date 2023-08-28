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
    public partial class Nueva_Receta : Form
    {

        public Nueva_Receta()
        {
            InitializeComponent();
        }

        private void Nueva_Receta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Boton Agregar
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearNuevoProceso_Click(object sender, EventArgs e)
        {
            Nuevo_Proceso NP = new Nuevo_Proceso();

            NP.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Cocina C = new Cocina();

            C.Show();
            this.Hide();
        }
    }
}
