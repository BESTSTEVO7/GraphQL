namespace GraphQLTraining.Model
{
    public class Job
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal YearlyFrom { get; set; }

        public decimal YearlyTo { get; set; }

        public int EducationId { get; set; }

        public int BranchId { get; set; }
    }
}
