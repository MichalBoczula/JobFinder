using JobsCatalog.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string CompanyLogo { get; set; }
        public ICollection<JobOffer> JobOffers { get; set; }
    }
}
