using SGA.Domain.Interfaces.Repository;
using SGA.Infrastructure.Data.EntityFramework.Context;
using SGA.Infrastructure.Data.Repositories;
using SGA.Infrastructure.SharedKernel.Interfaces;

namespace SGA.Infrastructure.Data
{
    public class RegistryDsl : StructureMap.Registry
    {
        public RegistryDsl()
        {
            For<IDbContextFactory<SgaContext>>().Use(new DbContextFactory<SgaContext>());

            For<IInstituicaoRepository>().Use<InstituicaoRepository>();
        }
    }
}