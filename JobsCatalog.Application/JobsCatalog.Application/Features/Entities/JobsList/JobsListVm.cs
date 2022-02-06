using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Entities.JobsList
{
    public class JobsListVm
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string CompanyImage { get; set; }
        public string ProgrammingLanguageImage { get; set; }

    }
}
