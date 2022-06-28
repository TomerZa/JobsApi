using JobsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobsApi.Configuration
{
    public class JobInfoConfiguration : IEntityTypeConfiguration<JobInfo>
    {
        public void Configure(EntityTypeBuilder<JobInfo> builder)
        {
            builder.ToTable("JobInfo");

            builder.Property(p => p.JobDate).HasColumnType("datetime").IsRequired();
            builder.HasKey(k => k.JobDate);

            builder.Property(p => p.ActiveJobs).IsRequired();

            builder.Property(p => p.JobViews).IsRequired();

            builder.Property(p => p.PredictedJobViews).IsRequired();

            var dataList = new List<JobInfo>();

            for (int i = 1; i <= 30; i++)
            {
                dataList.Add(new JobInfo
                {
                    JobDate = DateTime.Now.AddDays(-i).Date,
                    ActiveJobs = i * 5,
                    JobViews = i * 3,
                    PredictedJobViews = i * 2,
                });
            }

            builder.HasData(dataList);
        }
    }
}
