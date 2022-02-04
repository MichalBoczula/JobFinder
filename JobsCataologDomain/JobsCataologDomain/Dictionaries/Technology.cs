using JobsCatalog.Domain.Common;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobsCatalog.Domain.Dictionaries
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<JobOfferTechnology> JobOfferTechnology { get; set; }
    }
}
