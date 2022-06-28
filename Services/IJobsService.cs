using JobsApi.Models;

namespace JobsApi.Services
{
    public interface IJobsService
    {
        IQueryable<JobInfo> GetAllByDates(JobsInfoRequest jobsInfoRequest);
    }
}
