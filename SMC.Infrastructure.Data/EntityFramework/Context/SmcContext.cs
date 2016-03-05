using SMC.Infrastructure.SharedKernel.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace SMC.Infrastructure.Data.EntityFramework.Context
{
    public class SmcContext : DbContext, IDbContext
    {
        private bool _isDisposed;

        public SmcContext()
            : base("connectionString")
        {
            Database.SetInitializer<SmcContext>(null);
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new int SaveChanges()
        {
            var modifiedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified).ToArray();
            var rowsAffected = base.SaveChanges();
            foreach (var entity in modifiedEntities)
                entity.State = EntityState.Detached;
            return rowsAffected;
        }

        public new DbEntityEntry Entry(object o)
        {
            return base.Entry(o);
        }

        public DbContext Base()
        {
            return this;
        }

        protected override void Dispose(bool disposing)
        {
            _isDisposed = true;
        }

        public bool IsDisposed()
        {
            return _isDisposed;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(SmcContext)));
        }
    }
}