using SGA.Application.Interfaces;
using SGA.Application.Services.Core;
using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Services;

namespace SGA.Application.Services
{
    public class DisciplinaAppService : AppBaseService<Instituicao>, IInstituicaoAppService
    {
        public DisciplinaAppService(IInstituicaoService service) : base(service)
        {
        }
    }
}