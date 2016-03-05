using SMC.Domain.Entities;
using SMC.Domain.Interfaces.Repository;
using SMC.Domain.Interfaces.Services;
using SMC.Domain.Services.Core;

namespace SMC.Domain.Services
{
    public class TimelineService : BaseService<Timeline>, ITimelineService
    {
        public TimelineService(ITimelineRepository repository) : base(repository)
        {
        }
    }
}