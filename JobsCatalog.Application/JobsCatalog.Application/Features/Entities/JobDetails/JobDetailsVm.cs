using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Entities.JobDetails
{
    public class JobDetailsVm
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public string City { get; set; }
        public string ExperienceLevel { get; set; }
        public string CompanyName { get; set; }
        public string CompanyImage { get; set; }
        public string ProgrammingLanguageImage { get; set; }
        public string About { get; set; }
        public string Responsibilities { get; set; }
        public string Expectation { get; set; }
        public string Offer { get; set; }
        public List<string> Technologies { get; set; }
    }
}
