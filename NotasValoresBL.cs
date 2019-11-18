using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
  public  class NotasValoresBL
    {

        UnitOfWork uow = new UnitOfWork();

        public void Create(NotasValores pnotasValores)
        {
            uow.NotasValoresRepository.Create(pnotasValores);
            uow.SaveChanges();
        }

        public void Update(NotasValores pnotasValores)
        {
            uow.NotasValoresRepository.Update(pnotasValores);
            uow.SaveChanges();
        }

        public void Delete(NotasValores pnotasValores)
        {
            uow.NotasValoresRepository.Delete(pnotasValores);
            uow.SaveChanges();
        }

        public IQueryable<NotasValores> Get()
        {
            return uow.NotasValoresRepository.Get();
        }

        public NotasValores Find(Int64 pId)
        {
            return uow.NotasValoresRepository.Find(pId);
        }
    }
}
