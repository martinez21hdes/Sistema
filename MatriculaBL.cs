using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
   public class MatriculaBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void Create(Matricula pMatricula)
        {
            uow.MatriculaRepository.Create(pMatricula);
            uow.SaveChanges();
        }

        public void Update(Matricula pMatricula)
        {
            uow.MatriculaRepository.Update(pMatricula);
            uow.SaveChanges();
        }

        public void Delete(Matricula pMatricula)
        {
            uow.MatriculaRepository.Delete(pMatricula);
            uow.SaveChanges();
        }

        public IQueryable<Matricula> Get()
        {
            return uow.MatriculaRepository.Get();
        }

        public Matricula Find(Int64 pId)
        {
            return uow.MatriculaRepository.Find(pId);
        }
    }
}
