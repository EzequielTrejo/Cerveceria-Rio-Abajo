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

        public static string ProcesoNombre { get; set; } = string.Empty;
        public static string ProcesoDuracion { get; set; } = string.Empty;
        public static string MateriaCantidad { get; set; } = string.Empty;
        public static string RecetaNombre { get; set; } = string.Empty;

        public Nuevo_Proceso()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtCantidad.Text = "";
            txtDuracion.Text = "";
            txtNombreProceso.Text = "";
        }

    }
}
