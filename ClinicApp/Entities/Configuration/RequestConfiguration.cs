using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities.Configuration
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasOne(r => r.User).WithMany(u => u.Requests).HasForeignKey(r => r.UserId);
            builder.HasOne(r => r.DayOffType).WithMany(d => d.Requests).HasForeignKey(d => d.DayOffTypeId);
        }
    }
}
