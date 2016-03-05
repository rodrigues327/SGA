using AutoMapper;
using SMC.Application.Interfaces.Core;
using SMC.Application.ViewModel.Core;
using SMC.Domain.Entities.Core;
using SMC.Domain.Interfaces.Services.Core;
using StructureMap;
using System;
using System.Collections.Generic;

namespace SMC.Application.Services.Core
{
    public class AppBaseService<TEntity, TViewModel> : IDisposable, IAppBaseService<TViewModel> where TEntity : BaseEntity where TViewModel : BaseViewModel
    {
        private readonly IMapper _mapper;

        private readonly IBaseService<TEntity> _serviceBase;

        public AppBaseService(IContainer iocContainer)
        {
            _mapper = iocContainer.GetInstance<IMapper>();
            _serviceBase = iocContainer.GetInstance<IBaseService<TEntity>>();
        }

        public void Add(TViewModel obj)
        {
            _serviceBase.Add(_mapper.Map<TEntity>(obj));
        }

        public TViewModel GetById(int id)
        {
            return _mapper.Map<TViewModel>(_serviceBase.GetById(id));
        }

        public IEnumerable<TViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TViewModel>>(_serviceBase.GetAll());
        }

        public void Update(TViewModel obj)
        {
            _serviceBase.Update(_mapper.Map<TEntity>(obj));
        }

        public void Remove(int id)
        {
            _serviceBase.Remove(id);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}