using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cocina
    {
        private string Receta;
        private string Producto;
        private int CantidadAUtilizar;
        private int CantidaDisponible;

        public string Receta1 { get => Receta; set => Receta = value; }
        public string Producto1 { get => Producto; set => Producto = value; }
        public int CantidadAUtilizar1 { get => CantidadAUtilizar; set => CantidadAUtilizar = value; }
        public int CantidaDisponible1 { get => CantidaDisponible; set => CantidaDisponible = value; }

        public Cocina() { }

        public Cocina(string R, string P, int CU, int CD)
        {
            Receta1 = R;
            Producto1 = P;
            CantidadAUtilizar1 = CU;
            CantidaDisponible1 = CD;
        }
    }
}
