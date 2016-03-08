using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Repository;
using SGA.Domain.Interfaces.Services;
using SGA.Domain.Services.Core;

namespace SGA.Domain.Services
{
    public class InstituicaoService : BaseService<Instituicao>, IInstituicaoService
    {
        public InstituicaoService(IInstituicaoRepository repository) : base(repository)
        {
        }
    }
}