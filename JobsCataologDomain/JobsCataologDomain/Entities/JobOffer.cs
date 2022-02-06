using JobsCatalog.Domain.Common;
using JobsCatalog.Domain.Dictionaries;
using JobsCatalog.Domain.Helper;
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
        public int ExperienceLevelId { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public JobDescription JobDescription { get; set; }
        public ICollection<JobOfferTechnology> JobOfferTechnology { get; set; }
    }
}
