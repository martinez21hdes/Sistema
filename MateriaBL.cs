using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
  public  class MateriaBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void Create(Materia pMateria)
        {
            uow.MateriaRepository.Create(pMateria);
            uow.SaveChanges();
        }

        public void Update(Materia pMateria)
        {
            uow.MateriaRepository.Update(pMateria);
            uow.SaveChanges();
        }

        public void Delete(Materia pMateria)
        {
            uow.MateriaRepository.Delete(pMateria);
            uow.SaveChanges();
        }

        public IQueryable<Materia> Get()
        {
            return uow.MateriaRepository.Get();
        }

        public Materia Find(Int64 pId)
        {
            return uow.MateriaRepository.Find(pId);
        }
    }
}
