using SGA.Infrastructure.SharedKernel.Interfaces;
using System;

namespace SGA.Infrastructure.Data.Context
{
    public class DbContextFactory<T> : IDisposable, IDbContextFactory<T> where T : IDbContext, new()
    {
        private T _dataContext;

        public T Get()
        {
            return (_dataContext == null || _dataContext.IsDisposed()) ? _dataContext = new T() : _dataContext;
        }

        public void Dispose()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}