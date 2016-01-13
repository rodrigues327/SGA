using SGA.Application.Interfaces;
using SGA.Application.Services.Core;
using StructureMap;

namespace SGA.Application.Services
{
    public class AlunoService : AppBaseService<AlunoService>, IAlunoService
    {
        private readonly IContainer _iocContaine;

        public AlunoService(IContainer iocContaine)
        {
            _iocContaine = iocContaine;
        }
    }
}