using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
     public class Grado
    {

        public Int64 Id { get; set; }
        public string Nombre_Grado { get; set; }

        
       

        public Int64 CicloId { get; set; }
        public Ciclo ciclo { get; set; }

        public IList<Matricula> Matriculas { get; set; }

    }
}
