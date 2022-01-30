using JobsCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobsCatalog.Domain.Dictionaries
{
    public class ExperienceLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<JobOffer> JobOffers { get; set; }
    }
}
