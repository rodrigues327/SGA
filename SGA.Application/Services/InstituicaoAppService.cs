using SGA.Application.Interfaces;
using SGA.Application.Services.Core;
using SGA.Application.ViewModel;
using SGA.Domain.Entities;
using StructureMap;

namespace SGA.Application.Services
{
    public class InstituicaoAppService : AppBaseService<Instituicao, InstituicaoViewModel>, IInstituicaoAppService
    {
        public InstituicaoAppService(IContainer iocContaine) : base(iocContaine)
        {
        }
    }
}