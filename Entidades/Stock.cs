using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock
    {
        //Materia Prima
        private string MateriaPrima;
        private int CantidadMateria;
        private DateTime FechaIngreso;

        public string MateriaPrima1 { get => MateriaPrima; set => MateriaPrima = value; }
        public int CantidadMateria1 { get => CantidadMateria; set => CantidadMateria = value; }
        public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }

        //Producto Final
        private string ProductoFinal;
        private int CantidadProducto;
        private int NºLote;
        private DateTime FechaFinalizacion;

        public string ProductoFinal1 { get => ProductoFinal; set => ProductoFinal = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public int NºLote1 { get => NºLote; set => NºLote = value; }
        public DateTime FechaFinalizacion1 { get => FechaFinalizacion; set => FechaFinalizacion = value; }

        //Contenedores
        private string Contenedor;
        private int ContenedoresLibres;
        private int ContenedoresOcupados;
        private int ContenedoresEntregados;
        private int TotalContenedores;

        public string Contenedor1 { get => Contenedor; set => Contenedor = value; }
        public int ContenedoresLibres1 { get => ContenedoresLibres; set => ContenedoresLibres = value; }
        public int ContenedoresOcupados1 { get => ContenedoresOcupados; set => ContenedoresOcupados = value; }
        public int ContenedoresEntregados1 { get => ContenedoresEntregados; set => ContenedoresEntregados = value; }
        public int TotalContenedores1 { get => TotalContenedores; set => TotalContenedores = value; }

        public Stock() { }

        public Stock( /*1*/ string MP, int CMP, DateTime FI, /*2*/ string PF, int CP, int NL, DateTime FF, /*3*/ string C, int CL, int CO, int CE, int TC)
        {
            //1
            MateriaPrima1 = MP;
            CantidadMateria1 = CMP;
            FechaIngreso1 = FI;
            //2
            ProductoFinal1 = PF;
            CantidadProducto1 = CP;
            NºLote1 = NL;
            FechaFinalizacion1 = FF;
            //3
            Contenedor1 = C;
            ContenedoresLibres1 = CL;
            ContenedoresOcupados1 = CO;
            ContenedoresEntregados1 = CE;
            TotalContenedores1 = TC;
        }

    }
}
