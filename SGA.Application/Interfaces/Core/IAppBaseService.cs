using SGA.Domain.Entities.Core;
using System.Collections.Generic;

namespace SGA.Application.Interfaces.Core
{
    public interface IAppBaseService<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}