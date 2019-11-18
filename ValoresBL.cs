using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
  public  class ValoresBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void Create(Valores pValores)
        {
            uow.ValoresRepository.Create(pValores);
            uow.SaveChanges();
        }

        public void Update(Valores pValores)
        {
            uow.ValoresRepository.Update(pValores);
            uow.SaveChanges();
        }

        public void Delete(Valores pValores)
        {
            uow.ValoresRepository.Delete(pValores);
            uow.SaveChanges();
        }

        public IQueryable<Valores> Get()
        {
            return uow.ValoresRepository.Get();
        }

        public Valores Find(Int64 pId)
        {
            return uow.ValoresRepository.Find(pId);
        }
    }
}

