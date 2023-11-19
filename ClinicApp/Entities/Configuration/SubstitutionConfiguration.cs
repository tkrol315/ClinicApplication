using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities.Configuration
{
    public class SubstitutionConfiguration : IEntityTypeConfiguration<Substitution>
    {
        public void Configure(EntityTypeBuilder<Substitution> builder)
        {
            builder.HasOne(s => s.User).WithMany(u => u.Substitutions).HasForeignKey(s => s.UserId);
            builder.HasOne(s => s.Request).WithMany(r => r.Substitutions).HasForeignKey(s => s.RequestId);
        }
    }
}
