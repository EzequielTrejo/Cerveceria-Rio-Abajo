using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidades
    {
        //Receta en Proceso
        private string RecetaEnProceso;
        private string ProcesoActivo;
        private DateTime FechaInicio;
        private DateTime FechaFinalizacionProceso;
        private int CantidadDeMateria;
        private DateTime TiempoRestante;
        private string EstadoActual;

        public string RecetaEnProceso1 { get => RecetaEnProceso; set => RecetaEnProceso = value; }
        public string ProcesoActivo1 { get => ProcesoActivo; set => ProcesoActivo = value; }
        public DateTime FechaInicio1 { get => FechaInicio; set => FechaInicio = value; }
        public DateTime FechaFinalizacionProceso1 { get => FechaFinalizacionProceso; set => FechaFinalizacionProceso = value; }
        public int CantidadDeMateria1 { get => CantidadDeMateria; set => CantidadDeMateria = value; }
        public DateTime TiempoRestante1 { get => TiempoRestante; set => TiempoRestante = value; }
        public string EstadoActual1 { get => EstadoActual; set => EstadoActual = value; }

        //Receta Finalizada
        private string RecetasCompletadas;
        private DateTime FechaFinalizacionReceta;
        private int CantidadProducto;
        private string Estado;

        public string RecetasCompletadas1 { get => RecetasCompletadas; set => RecetasCompletadas = value; }
        public DateTime FechaFinalizacionReceta1 { get => FechaFinalizacionReceta; set => FechaFinalizacionReceta = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public string Estado1 { get => Estado; set => Estado = value; }

        public Entidades() { }

        public Entidades( /*1*/ string RP, string PA, DateTime FI, DateTime FFP, int CM, DateTime TR, string EA, /*2*/ string RC, DateTime FFR, int CP,
            string E)
        {
            //1
            RecetaEnProceso1 = RP;
            ProcesoActivo1 = PA;
            FechaInicio1 = FI;
            FechaFinalizacionProceso1 = FFP;
            CantidadDeMateria1 = CM;
            TiempoRestante1 = TR;
            EstadoActual1 = EA;
            //2
            RecetasCompletadas1 = RC;
            FechaFinalizacionReceta1 = FFR;
            CantidadProducto1 = CP;
            Estado1 = E;
        }


    }
}
