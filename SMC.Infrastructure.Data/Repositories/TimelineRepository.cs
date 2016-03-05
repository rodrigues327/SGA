using SMC.Domain.Entities;
using SMC.Domain.Interfaces.Repository;
using SMC.Infrastructure.Data.EntityFramework.Context;
using SMC.Infrastructure.Data.Repositories.Core;
using SMC.Infrastructure.SharedKernel.Interfaces;

namespace SMC.Infrastructure.Data.Repositories
{
    public class TimelineRepository : BaseRepository<Timeline>, ITimelineRepository
    {
        public TimelineRepository(IDbContextFactory<SmcContext> contextFactory) : base(contextFactory)
        {
        }
    }
}