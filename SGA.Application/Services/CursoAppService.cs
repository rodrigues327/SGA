using SGA.Application.Interfaces;
using SGA.Application.Services.Core;
using SGA.Domain.Entities;
using SGA.Domain.Interfaces.Services;

namespace SGA.Application.Services
{
    public class CursoAppService : AppBaseService<Curso>, ICursoAppService
    {
        public CursoAppService(ICursoService service) : base(service)
        {
        }
    }
}