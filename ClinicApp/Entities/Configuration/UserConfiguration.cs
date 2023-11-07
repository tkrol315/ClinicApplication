using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.HasMany(u => u.Schedules).WithMany(s => s.Users);
            builder.HasMany(u => u.DaysOff).WithMany(d => d.Users);
        }
    }
}
