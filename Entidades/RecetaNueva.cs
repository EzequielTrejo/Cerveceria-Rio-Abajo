using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class RecetaNueva
    {
        private string NombreReceta;
        private string ListaProcesos;
        private string NombreProceso;
        private int DuracionProceso;
        private string MateriaPrima;
        private int CantidadNecesaria;

        public string NombreReceta1 { get => NombreReceta; set => NombreReceta = value; }
        public string ListaProcesos1 { get => ListaProcesos; set => ListaProcesos = value; }
        public string NombreProceso1 { get => NombreProceso; set => NombreProceso = value; }
        public int DuracionProceso1 { get => DuracionProceso; set => DuracionProceso = value; }
        public string MateriaPrima1 { get => MateriaPrima; set => MateriaPrima = value; }
        public int CantidadNecesaria1 { get => CantidadNecesaria; set => CantidadNecesaria = value; }

        public RecetaNueva(){ }

        public RecetaNueva(string NR, string LP, string NP, int DP, string MP, int CN)
        {
            NombreReceta1 = NR;
            ListaProcesos1 = LP;
            NombreProceso1 = NP;
            DuracionProceso1 = DP;
            MateriaPrima1 = MP;
            CantidadNecesaria1 = CN;
        }
    }
}
