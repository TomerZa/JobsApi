using JobsApi.Configuration;
using JobsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsApi.Data
{
    public class JobsDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public JobsDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("Sql"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobInfoConfiguration());
        }

        public DbSet<JobInfo> JobsInfo => Set<JobInfo>();
    }
}
