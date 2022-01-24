using JobsCatalog.Domain.Common;
using JobsCatalog.Domain.Dictionaries;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Domain.Entities
{
    public class JobOffer : AuditableEntity
    {
        public string PositionName { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public string City { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public Company Company { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public JobDescription JobDescription { get; set; }
        public List<Technology> Technologies { get; set; }
    }
}
