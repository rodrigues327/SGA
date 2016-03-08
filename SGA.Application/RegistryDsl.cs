using AutoMapper;
using SGA.Application.Interfaces;
using SGA.Application.Services;

namespace SGA.Application
{
    public class RegistryDsl : StructureMap.Registry
    {
        public RegistryDsl()
        {
            #region Automapper configuration

            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            For<IMapper>().Singleton().Use(config.CreateMapper());

            #endregion Automapper configuration

            For<IInstituicaoAppService>().Use<InstituicaoAppService>();
            //  For<IAlunoAppService>().Use<AlunoAppService>();
            //  For<ICursoAppService>().Use<CursoAppService>();
        }
    }
}