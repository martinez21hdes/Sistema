using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
    public class Matricula
    {
        private Matricula matricula;

        public Matricula(Matricula matricula)
        {
            this.matricula = matricula;
        }

        public Matricula()
        {
        }

        public Int64 Id { get; set; }
        public string Nie { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Tercer_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Turno { get; set; }
        public string Nombre_Responsable { get; set; }
        public string DUI { get; set; }
        public string Seccion { get; set; }
        public Int64 GradoId { get; set; }
        public Grado grado { get; set; }
       

    }
}
