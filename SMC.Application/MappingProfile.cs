using AutoMapper;
using SMC.Application.ViewModel;
using SMC.Domain.Entities;

namespace SMC.Application
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<TimelineViewModel, Timeline>().ReverseMap();
        }
    }
}