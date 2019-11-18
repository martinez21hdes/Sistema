using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL
{
    public interface IRepository<T>
    {
        void Create(T entity);
        T Find(params object[] key);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Get();
    }
}
