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
    public partial class ProduccionDetalles : Form
    {
        public ProduccionDetalles()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Produccion Prod = new Produccion();

            this.Close();
        }

        private void ProduccionDetalles_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        public void CargarDGV()
        {

        }

    }
}
