using GraphQLTraining.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTraining.Services
{
    public interface IJobService
    {
        List<Job> GetJobs();
    }
}
