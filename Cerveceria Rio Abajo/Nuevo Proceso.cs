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
    public partial class Nuevo_Proceso : Form
    {

        public Nuevo_Proceso()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtTemperatura.Text = "";
            txtCantidad.Text = "";
            txtDuracion.Text = "";
            txtNombreProceso.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nueva_Receta NR = new Nueva_Receta();

            MessageBox.Show("Proceso Agregado Correctamente");
            Limpiar();
            NR.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Nueva_Receta NR = new Nueva_Receta();

            Limpiar();
            NR.Show();
            this.Hide();
        }
    }
}
