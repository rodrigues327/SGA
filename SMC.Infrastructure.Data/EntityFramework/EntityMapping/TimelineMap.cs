using SMC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SMC.Infrastructure.Data.EntityFramework.EntityMapping
{
    public class TimelineMap : EntityTypeConfiguration<Timeline>
    {
        public TimelineMap()
        {
            // Table & Column Mappings
            ToTable("Timeline");
        }
    }
}