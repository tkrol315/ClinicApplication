using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities.Configuration
{
    public class ResponseConfiguration : IEntityTypeConfiguration<Response>
    {
       
        public void Configure(EntityTypeBuilder<Response> builder)
        {
           builder.HasOne(r => r.DayOffType).WithMany(d => d.Responses).HasForeignKey(r => r.DayOffTypeId);
        }
    }
}
