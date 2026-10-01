using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrusCurso.Logica
{
    public class Lpersonal
    {
        public int Id_personal { get; set; }
        public string Nombres { get; set; }
        public string Identificacion { get; set; }
        public string Pais { get; set; }
        public int Id_Cargo { get; set; }
        public double SueldoPorHora { get; set; }

        public string Estado { get; set; }
        public string Codigo { get; set; }
    }
}
