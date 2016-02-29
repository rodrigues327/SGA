using AutoMapper;
using SGA.Application.ViewModel;
using SGA.Domain.Entities;

namespace SGA.Application
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<InstituicaoViewModel, Instituicao>().ReverseMap();
        }
    }
}