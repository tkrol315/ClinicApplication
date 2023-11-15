using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<DayOffType> DayOffTypes { get; set; }
        public DbSet<DayOff> DaysOff { get; set; }
        public DbSet<ReceptionistRequest> ReceptionistRequests { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }

   
}
