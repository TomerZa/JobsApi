using JobsApi.Data;
using JobsApi.Models;

namespace JobsApi.Services
{
    public class JobsService : IJobsService
    {
        private readonly ILogger<JobsService> _logger;
        private readonly JobsDbContext _jobsDb;

        public JobsService(ILogger<JobsService> logger, JobsDbContext jobsDb)
        {
            _logger = logger;
            _jobsDb = jobsDb;
        }
        public IQueryable<JobInfo> GetAllByDates(JobsInfoRequest jobsInfoRequest)
        {
            _logger.LogInformation("Getting All Jobs by dates from: {StartDate} to: {EndDate}", jobsInfoRequest.StartDate, jobsInfoRequest.EndDate);
            return _jobsDb.JobsInfo.Where(x => x.JobDate >= jobsInfoRequest.StartDate && x.JobDate <= jobsInfoRequest.EndDate).OrderBy(x => x.JobDate);
        }
    }
}
