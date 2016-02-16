using SGA.Application.Interfaces;
using SGA.Application.Services.Core;
using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Services;

namespace SGA.Application.Services
{
    public class AlunoAppService : AppBaseService<Aluno>, IAlunoAppService
    {
        public AlunoAppService(IAlunoService service) : base(service)
        {
        }
    }
}