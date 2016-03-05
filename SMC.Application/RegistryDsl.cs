using AutoMapper;
using SMC.Application.Interfaces;
using SMC.Application.Services;

namespace SMC.Application
{
    public class RegistryDsl : StructureMap.Registry
    {
        public RegistryDsl()
        {
            #region Automapper configuration

            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            For<IMapper>().Singleton().Use(config.CreateMapper());

            #endregion Automapper configuration

            For<ITimelineAppService>().Use<TimelineAppService>();
            //  For<IAlunoAppService>().Use<AlunoAppService>();
            //  For<ICursoAppService>().Use<CursoAppService>();
        }
    }
}