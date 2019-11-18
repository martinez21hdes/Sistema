using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
   public class YearsBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void Create(Years pYears)
        {
            uow.YearsRepository.Create(pYears);
            uow.SaveChanges();
        }

        public void Update(Years pYears)
        {
            uow.YearsRepository.Update(pYears);
            uow.SaveChanges();
        }

        public void Delete(Years pYears)
        {
            uow.YearsRepository.Delete(pYears);
            uow.SaveChanges();
        }

        public IQueryable<Years> Get()
        {
            return uow.YearsRepository.Get();
        }

        public Years Find(Int64 pId)
        {
            return uow.YearsRepository.Find(pId);
        }
    }
}
