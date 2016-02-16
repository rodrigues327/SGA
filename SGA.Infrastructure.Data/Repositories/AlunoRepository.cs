using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Repository;
using SGA.Infrastructure.Data.EntityFramework.Context;
using SGA.Infrastructure.Data.Repositories.Core;
using SGA.Infrastructure.SharedKernel.Interfaces;

namespace SGA.Infrastructure.Data.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(IDbContextFactory<SgaContext> contextFactory) : base(contextFactory)
        {
        }
    }
}