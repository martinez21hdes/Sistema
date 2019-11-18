using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
   public class NotasBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void Create(Notas pNotas)
        {
            uow.NotasRepository.Create(pNotas);
            uow.SaveChanges();
        }

        public void Update(Notas pNotas)
        {
            uow.NotasRepository.Update(pNotas);
            uow.SaveChanges();
        }

        public void Delete(Notas pNotas)
        {
            uow.NotasRepository.Delete(pNotas);
            uow.SaveChanges();
        }

        public IQueryable<Notas> Get()
        {
            return uow.NotasRepository.Get();
        }

        public Notas Find(Int64 pId)
        {
            return uow.NotasRepository.Find(pId);
        }
    }
}
