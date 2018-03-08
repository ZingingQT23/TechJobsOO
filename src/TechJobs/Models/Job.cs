using System.ComponentModel.DataAnnotations;

namespace TechJobs.Models
{
    public class Job
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
        [Display(Name = "Skill")]
        public CoreCompetency CoreCompetency { get; set; }
        [Display(Name = "Position Type")]
        public PositionType PositionType { get; set; }

        public Job()
        {
            ID = nextId;
            nextId++;
        }

    }
}
