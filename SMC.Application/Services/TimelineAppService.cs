using SMC.Application.Interfaces;
using SMC.Application.Services.Core;
using SMC.Application.ViewModel;
using SMC.Domain.Entities;
using StructureMap;

namespace SMC.Application.Services
{
    public class TimelineAppService : AppBaseService<Timeline, TimelineViewModel>, ITimelineAppService
    {
        public TimelineAppService(IContainer iocContaine) : base(iocContaine)
        {
        }
    }
}