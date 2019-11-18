using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
   public class Notas
    {
        private Matricula matricula1;

        public Notas(Matricula matricula1)
        {
            this.matricula1 = matricula1;
        }

        public Notas()
        {
        }

        public Int64 Id { get; set; }
        public string Primer_Trimestre { get; set; }
        public string Segundo_Trimestre { get; set; }
        public string Tercer_Trimestre { get; set; }
        public string Promedio_Final { get; set; }
        public string Estado { get; set; }

        public Int64 MatriculaId { get; set; }
        public Matricula matricula { get; set; }

        public Int64 MateriaId { get; set; }
        public Materia materia { get; set; }

       
    }
}
