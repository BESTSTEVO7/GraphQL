
using GraphQLTraining.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTraining.Model
{
    public class Query
    {
        private readonly IJobService jobService;

        public Query(IJobService jobService)
        {
            this.jobService = jobService;
        }

        public List<Job> Jobs => jobService.GetJobs();
    }
}
