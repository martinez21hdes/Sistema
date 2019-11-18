using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
  public  class NotasValores
    {

        public Int64 Id { get; set; }
        public string Primer_Trimestre { get; set; }
        public string Segundo_Trimestre { get; set; }
        public string Tercer_Trimestre { get; set; }
    

        public Int64 MatriculaId { get; set; }
        public Matricula matricula { get; set; }

        public Int64 ValoresId { get; set; }
        public Valores valor { get; set; }
    }
}
