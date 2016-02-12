using SGA.Application.Interfaces.Core;
using SGA.Domain.Entities.Core;
using SGA.Domain.Interfaces.Services.Core;
using System;
using System.Collections.Generic;

namespace SGA.Application.Services.Core
{
    public class AppBaseService<TEntity> : IDisposable, IAppBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseService<TEntity> _serviceBase;

        public AppBaseService(IBaseService<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}