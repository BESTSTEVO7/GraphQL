using GraphQLTraining.Model;
using System.Collections.Generic;

namespace GraphQLTraining.Services
{
    public class InMemoryJobService : IJobService
    {
        public List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Name = "SoftwareDeveloper",
                    YearlyFrom = 3000,
                    YearlyTo = 6000,
                    BranchId = 1,
                    EducationId = 1
                }
            };
        }
    }
}
