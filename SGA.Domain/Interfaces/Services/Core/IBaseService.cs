using SGA.Domain.Entities.Core;
using System.Collections.Generic;

namespace SGA.Domain.Interfaces.Services.Core
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(int id);

        void Dispose();
    }
}