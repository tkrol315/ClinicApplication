using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicApp.Entities.Configuration
{
    public class RequestStateConfiguration : IEntityTypeConfiguration<RequestState>
    {
        public void Configure(EntityTypeBuilder<RequestState> builder)
        {
            builder.HasMany(r => r.Requests).WithOne(r => r.RequestState).HasForeignKey(r => r.RequestStateId);
        }
    }
}
