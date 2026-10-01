using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OrusCurso.Logica
{
    public class Lcargos
    {
        public int Id_Cargo { get; set; }
        public string Cargo { get; set; }
        public double SueldoPorHora { get; set; }
    }
}
