using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DetallesProduccion
    {
        //Detalles
        private string Proceso;
        private DateTime HoraInicio;
        private DateTime HoraFin;
        private DateTime FinReal;
        private string Estado;
        private string MateriaPrima;

        public string Proceso1 { get => Proceso; set => Proceso = value; }
        public DateTime HoraInicio1 { get => HoraInicio; set => HoraInicio = value; }
        public DateTime HoraFin1 { get => HoraFin; set => HoraFin = value; }
        public DateTime FinReal1 { get => FinReal; set => FinReal = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string MateriaPrima1 { get => MateriaPrima; set => MateriaPrima = value; }
        

        //Materia Prima
        private string MateriaPrimaDetalle;
        private int CantidadMateria;
        private int CantidadDisponible;

        public string MateriaPrimaDetalle1 { get => MateriaPrimaDetalle; set => MateriaPrimaDetalle = value; }
        public int CantidadMateria1 { get => CantidadMateria; set => CantidadMateria = value; }
        public int CantidadDisponible1 { get => CantidadDisponible; set => CantidadDisponible = value; }

        public DetallesProduccion() { }

        public DetallesProduccion( /*1*/ string P, DateTime HI, DateTime HF, DateTime FR, string E, string MP, /*2*/ string MPD, int CM, int CD)
        {
            //1
            Proceso1 = P;
            HoraInicio1 = HI;
            HoraFin1 = HF;
            FinReal1 = FR;
            Estado1 = E;
            MateriaPrima1 = MP;
            //2
            MateriaPrimaDetalle1 = MPD;
            CantidadMateria1 = CM;
            CantidadDisponible1 = CD;
        }
    }
}
