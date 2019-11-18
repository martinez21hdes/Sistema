using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
   public class Years
    {
        public Int64 Id { get; set; }
        public string Nombre_Year { get; set; }

        public IList<Ciclo> ciclos { get; set; }
    }
}
