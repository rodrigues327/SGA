using SMC.Domain.Entities.Core;
using SMC.Domain.Interfaces.Repository.Core;
using SMC.Domain.Interfaces.Services.Core;
using System;
using System.Collections.Generic;

namespace SMC.Domain.Services.Core
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(int id)
        {
            var entity = GetById(id);
            _repository.Remove(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}