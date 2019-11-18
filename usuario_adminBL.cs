using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.DAL;

namespace Sistema_Academico.BL
{
   public  class usuario_adminBL
    {
        UnitOfWork uow = new UnitOfWork();

        public void create(usuario_admin pusuario_admin)
        {
            uow.Usuario_AdminRepository.Create(pusuario_admin);
            uow.SaveChanges();
        }
        public void Update(usuario_admin pusuario_admin)
        {
            uow.Usuario_AdminRepository.Update(pusuario_admin);
            uow.SaveChanges();

        }
        public void Delete(usuario_admin pusuario_admin)
        {
            uow.Usuario_AdminRepository.Delete(pusuario_admin);
            uow.SaveChanges();
        }
        public IQueryable<usuario_admin> Get()
        {
            return uow.Usuario_AdminRepository.Get();

        }
        public usuario_admin Find(Int64 pId)
        {
            return uow.Usuario_AdminRepository.Find(pId);
        }
    }
}
