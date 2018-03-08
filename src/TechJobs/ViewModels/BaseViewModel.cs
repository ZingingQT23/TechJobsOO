using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        public string Title { get; set; } = "";
        public List<JobFieldType> Columns { get; set; }
        public JobFieldType Column { get; set; } = JobFieldType.All;

    }
}
