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
        private string Observaciones;
        private string NombreProducto;
        private int CantidadProducto;
        private int PrecioXUni;
        private int PrecioFinal;

        public int NºFactura1 { get => NºFactura; set => NºFactura = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int MontoPagado1 { get => MontoPagado; set => MontoPagado = value; }
        public string Proveedor1 { get => Proveedor; set => Proveedor = value; }
        public string ProductosComprados1 { get => ProductosComprados; set => ProductosComprados = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public int PrecioXUni1 { get => PrecioXUni; set => PrecioXUni = value; }
        public int PrecioFinal1 { get => PrecioFinal; set => PrecioFinal = value; }

        //Clientes
        private int NºFacturaCliente;
        private string Cliente;
        private DateTime FechaCliente;
        private string ProductosVendidos;
        private int MontoACobrar;
        private string ObservacionesCliente;
        private string NombreProductoCliente;
        private int CantidadProductoCliente;
        private int PrecioXUniCliente;
        private int PrecioFinalCliente;

        public int NºFacturaCliente1 { get => NºFacturaCliente; set => NºFacturaCliente = value; }
        public string Cliente1 { get => Cliente; set => Cliente = value; }
        public DateTime FechaCliente1 { get => FechaCliente; set => FechaCliente = value; }
        public string ProductosVendidos1 { get => ProductosVendidos; set => ProductosVendidos = value; }
        public int MontoACobrar1 { get => MontoACobrar; set => MontoACobrar = value; }
        public string ObservacionesCliente1 { get => ObservacionesCliente; set => ObservacionesCliente = value; }
        public string NombreProductoCliente1 { get => NombreProductoCliente; set => NombreProductoCliente = value; }
        public int CantidadProductoCliente1 { get => CantidadProductoCliente; set => CantidadProductoCliente = value; }
        public int PrecioXUniCliente1 { get => PrecioXUniCliente; set => PrecioXUniCliente = value; }
        public int PrecioFinalCliente1 { get => PrecioFinalCliente; set => PrecioFinalCliente = value; }

        public Facturacion() { }

        public Facturacion(int NF, DateTime F, int MP, string P, string PC, string O, string NP, int CP, int PU, int PF) //Proveedores
        {
            NºFactura1 = NF;
            Fecha1 = F;
            MontoPagado1 = MP;
            Proveedor1 = P;
            ProductosComprados1 = PC;
            Observaciones1 = O;
            NombreProducto1 = NP;
            CantidadProducto1 = CP;
            PrecioXUni1 = PU;
            PrecioFinal1 = PF;
        }

        public Facturacion(int NFC,string C, DateTime FC, string PV, int MC, string OC, string NPC, int CPC, int PUC, int PFC) //Clientes
        {
            NºFacturaCliente1 = NFC;
            Cliente1 = C;
            FechaCliente1 = FC;
            ProductosVendidos1 = PV;
            MontoACobrar1 = MC;
            ObservacionesCliente1 = OC;
            NombreProductoCliente1 = NPC;
            CantidadProductoCliente1 = CPC;
            PrecioXUniCliente1 = PUC;
            PrecioFinalCliente1 = PFC;
        }

    }
}
