using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
   public class Materia
    {
        public Int64 Id { get; set; }
        public string Nombre_Materia { get; set; } 

        public IList<Notas> notas { get; set; } 
    }
}
