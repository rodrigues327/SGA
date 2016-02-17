﻿using SGA.Application.Interfaces;
using SGA.Application.Services;

namespace SGA.Application
{
    public class RegistryDsl : StructureMap.Registry
    {
        public RegistryDsl()
        {
            For<IInstituicaoAppService>().Use<InstituicaoAppService>();
            For<IAlunoAppService>().Use<AlunoAppService>();
            For<ICursoAppService>().Use<CursoAppService>();
        }
    }
}