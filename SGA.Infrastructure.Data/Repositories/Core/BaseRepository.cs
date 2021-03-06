﻿using SGA.Domain.Entities.Core;
using SGA.Domain.Interfaces.Repository.Core;
using SGA.Infrastructure.Data.EntityFramework.Context;
using SGA.Infrastructure.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SGA.Infrastructure.Data.Repositories.Core
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private bool _disposed;

        internal IDbContext Context;

        internal IDbSet<TEntity> DbSet;

        public BaseRepository(IDbContextFactory<SgaContext> contextFactory)
        {
            Context = contextFactory.Get();
            DbSet = Context.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
            Context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
            Context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}