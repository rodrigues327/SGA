using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Repository;
using SGA.Domain.Interfaces.Services;
using SGA.Domain.Services.Core;

namespace SGA.Domain.Services
{
    public class CursoService : BaseService<Curso>, ICursoService
    {
        public CursoService(ICursoRepository repository) : base(repository)
        {
        }
    }
}
