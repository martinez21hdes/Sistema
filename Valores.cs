using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL.DataModels
{
   public class Valores
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
      
        public IList<NotasValores> notasvalores { get; set; }
       
    }
}
