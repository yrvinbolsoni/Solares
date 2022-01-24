using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {

        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllPag(int skip = 0, int take = 25);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
