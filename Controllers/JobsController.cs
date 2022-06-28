using JobsApi.Models;
using JobsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly IJobsService _jobsServcie;

        public JobsController(ILogger<JobsController> logger, IJobsService jobsServcie)
        {
            _jobsServcie = jobsServcie;
        }

        [HttpGet]
        public IEnumerable<JobInfo> Get([FromQuery]JobsInfoRequest jobsInfoRequest)
        {
            return _jobsServcie.GetAllByDates(jobsInfoRequest);
        }
    }
}