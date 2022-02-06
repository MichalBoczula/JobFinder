using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobsCatalog.Domain.Common
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset Modified { get; set; }
        public int StatusId { get; set; }
        public string InactivatedBy { get; set; }
        public DateTimeOffset Inactivated { get; set; }
    }
}
