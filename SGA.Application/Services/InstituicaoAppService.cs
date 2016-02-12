using SGA.Application.Interfaces;
using SGA.Application.Services.Core;
using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Services;

namespace SGA.Application.Services
{
    public class InstituicaoAppService : AppBaseService<Instituicao>, IInstituicaoAppService
    {
        public InstituicaoAppService(IInstituicaoService service) : base(service)
        {
        }
    }
}