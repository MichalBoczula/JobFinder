using JobsCatalog.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Domain.Entities
{
    public class JobDescription : AuditableEntity
    {
        public string About { get; set; }
        public string Responsibilities { get; set; }
        public string Expectation { get; set; }
        public string Offer { get; set; }
    }
}
