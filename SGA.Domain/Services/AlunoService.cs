using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Repository;
using SGA.Domain.Interfaces.Services;
using SGA.Domain.Services.Core;

namespace SGA.Domain.Services
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        public AlunoService(IAlunoRepository repository) : base(repository)
        {
        }
    }
}