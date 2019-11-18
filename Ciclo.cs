using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
   public   class Ciclo
    {
        public Int64 Id { get; set; }
        public string Nombre_Ciclo { get; set; }

        public Int64 YearsId { get; set; }
        public Years years { get; set; }

        public IList<Grado> grado { get; set; }

    }
}
