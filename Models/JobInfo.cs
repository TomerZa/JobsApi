namespace JobsApi.Models
{
    public class JobInfo
    {
        public DateTime JobDate { get; set; }
        public int ActiveJobs { get; set; }
        public int JobViews { get; set; }
        public int PredictedJobViews { get; set; }
    }
}
