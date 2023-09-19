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
        private string UnidadMedida;
        private DateTime FechaIngreso;
        private int NumeroFactura;

        public string MateriaPrima1 { get => MateriaPrima; set => MateriaPrima = value; }
        public int CantidadMateria1 { get => CantidadMateria; set => CantidadMateria = value; }
        public string UnidadMedida1 { get => UnidadMedida; set => UnidadMedida = value; }
        public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
        public int NumeroFactura1 { get => NumeroFactura; set => NumeroFactura = value; }

        //Producto Final
        private string ProductoFinal;
        private int CantidadProducto;
        private int NºLote;
        private DateTime FechaFinalizacion;
        private string UnidadMedidaProducto;

        public string ProductoFinal1 { get => ProductoFinal; set => ProductoFinal = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public int NºLote1 { get => NºLote; set => NºLote = value; }
        public DateTime FechaFinalizacion1 { get => FechaFinalizacion; set => FechaFinalizacion = value; }
        public string UnidadMedidaProducto1 { get => UnidadMedidaProducto; set => UnidadMedidaProducto = value; }

        //Contenedores
        private string Contenedor;
        private int CantidadContenedores;
        private string UnidadMedidaContenedores;
        private int TotalContenedores;

        public string Contenedor1 { get => Contenedor; set => Contenedor = value; }
        public string UnidadMedidaContenedores1 { get => UnidadMedidaContenedores; set => UnidadMedidaContenedores = value; }
        public int CantidadContenedores1 { get => CantidadContenedores; set => CantidadContenedores = value; }
        public int TotalContenedores1 { get => TotalContenedores; set => TotalContenedores = value; }

        public Stock() { }

        public Stock( /*1*/ string MP, int CMP, DateTime FI, int NF, string UM, /*2*/ string PF, int CP, int NL, DateTime FF, string UMPF, /*3*/ string C, int TC, string UMC, int CC)
        {
            //1
            MateriaPrima1 = MP;
            CantidadMateria1 = CMP;
            FechaIngreso1 = FI;
            NumeroFactura1 = NF;
            UnidadMedida1 = UM;
            //2
            ProductoFinal1 = PF;
            CantidadProducto1 = CP;
            NºLote1 = NL;
            FechaFinalizacion1 = FF;
            UnidadMedidaProducto1 = UMPF;
            //3
            Contenedor1 = C;
            CantidadContenedores1 = CC;
            UnidadMedidaContenedores1 = UMC;
            TotalContenedores1 = TC;
        }

    }
}
