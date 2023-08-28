using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Facturacion
    {
        //Proveedores
        private int NºFactura;
        private DateTime Fecha;
        private int MontoPagado;
        private string Proveedor;
        private string ProductosComprados;

        public int NºFactura1 { get => NºFactura; set => NºFactura = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int MontoPagado1 { get => MontoPagado; set => MontoPagado = value; }
        public string Proveedor1 { get => Proveedor; set => Proveedor = value; }
        public string ProductosComprados1 { get => ProductosComprados; set => ProductosComprados = value; }

        //Clientes

        public Facturacion() { }

        public Facturacion(int NF, DateTime F, int MP, string P, string PC)
        {
            NºFactura1 = NF;
            Fecha1 = F;
            MontoPagado1 = MP;
            Proveedor1 = P;
            ProductosComprados1 = PC;
        }
    }
}
