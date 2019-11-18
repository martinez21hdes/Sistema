using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
   public class GradoBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void Create(Grado pGrado)
        {
            uow.GradoRepository.Create(pGrado);
            uow.SaveChanges();
        }

        public void Update(Grado pGrado)
        {
            uow.GradoRepository.Update(pGrado);
            uow.SaveChanges();
        }

        public void Delete(Grado pGrado)
        {
            uow.GradoRepository.Delete(pGrado);
            uow.SaveChanges();
        }

        public IQueryable<Grado> Get()
        {
            return uow.GradoRepository.Get();
        }

        public Grado Find(Int64 pId)
        {
            return uow.GradoRepository.Find(pId);
        }
    }
}
