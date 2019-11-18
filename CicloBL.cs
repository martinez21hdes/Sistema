using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;


namespace Sistema_Academico.BL
{
  public  class CicloBL
    {
         UnitOfWork uow = new UnitOfWork();

        public void Create(Ciclo pCiclo)
        {
            uow.CicloRepository.Create(pCiclo);
            uow.SaveChanges();
        }

        public void Update(Ciclo pCiclo)
        {
            uow.CicloRepository.Update(pCiclo);
            uow.SaveChanges();
        }

        public void Delete(Ciclo pCiclo)
        {
            uow.CicloRepository.Delete(pCiclo);
            uow.SaveChanges();
        }

        public IQueryable<Ciclo> Get()
        {
            return uow.CicloRepository.Get();
        }

        public Ciclo Find(Int64 pId)
        {
            return uow.CicloRepository.Find(pId);
        }
    }
}
