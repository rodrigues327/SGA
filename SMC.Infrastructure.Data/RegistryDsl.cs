using SMC.Domain.Interfaces.Repository;
using SMC.Infrastructure.Data.EntityFramework.Context;
using SMC.Infrastructure.Data.Repositories;
using SMC.Infrastructure.SharedKernel.Interfaces;

namespace SMC.Infrastructure.Data
{
    public class RegistryDsl : StructureMap.Registry
    {
        public RegistryDsl()
        {
            For<IDbContextFactory<SmcContext>>().Use(new DbContextFactory<SmcContext>());

            For<ITimelineRepository>().Use<TimelineRepository>();
        }
    }
}