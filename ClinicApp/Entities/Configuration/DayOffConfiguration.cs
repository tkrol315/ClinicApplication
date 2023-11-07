using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities.Configuration
{
    public class DayOffConfiguration : IEntityTypeConfiguration<DayOff>
    {
        public void Configure(EntityTypeBuilder<DayOff> builder)
        {
            builder.HasOne(d => d.DayOffType).WithMany(d => d.DaysOff).HasForeignKey(d => d.DayOffTypeId);
            builder.HasMany(d => d.Users).WithMany(u => u.DaysOff);
        }
    }
}
