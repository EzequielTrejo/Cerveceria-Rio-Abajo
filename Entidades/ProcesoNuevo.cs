using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ProcesoNuevo
    {
        private string Nombre;
        private string Duracion;
        private string MateriaPrima;
        private string CantidadNecesaria;
        private string Temperatura;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Duracion1 { get => Duracion; set => Duracion = value; }
        public string MateriaPrima1 { get => MateriaPrima; set => MateriaPrima = value; }
        public string CantidadNecesaria1 { get => CantidadNecesaria; set => CantidadNecesaria = value; }
        public string Temperatura1 { get => Temperatura; set => Temperatura = value; }

        public ProcesoNuevo() { }

        public ProcesoNuevo(string N, string D, string MP, string CN, string T)
        {
            Nombre1 = N;
            Duracion1 = D;
            MateriaPrima1 = MP;
            CantidadNecesaria1 = CN;
            Temperatura1 = T;
        }
    }
}
