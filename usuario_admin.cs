using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Sistema_Academico.DAL.DataModels
{
  public  class usuario_admin
    {
        [DisplayName("id admin")]
        public Int64 Id { get; set; }

        [DisplayName("nombre")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nom_admin { get; set; }

        [DisplayName("apellido")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apell_admin { get; set; }

        [DisplayName("usuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string usuario { get; set; }

        [DisplayName("Contrasenaf")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string password { get; set; }
    }
}
