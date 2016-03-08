using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SGA.Infrastructure.SharedKernel.Interfaces
{
    public interface IDbContext
    {
        int SaveChanges();

        DbEntityEntry Entry(object o);

        void Dispose();

        IDbSet<T> Set<T>() where T : class;

        DbContext Base();

        bool IsDisposed();
    }
}