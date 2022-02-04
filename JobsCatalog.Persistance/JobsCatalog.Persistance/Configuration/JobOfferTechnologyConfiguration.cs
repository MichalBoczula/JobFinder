using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Configuration
{
    public class JobOfferTechnologyConfiguration : IEntityTypeConfiguration<JobOfferTechnology>
    {
        public void Configure(EntityTypeBuilder<JobOfferTechnology> builder)
        {
            builder.HasKey(k => new { k.JobOfferId, k.TechnologyId});
            builder.HasOne(jot => jot.JobOffer)
                .WithMany(jo => jo.JobOfferTechnology)
                .HasForeignKey(jo => jo.JobOfferId);
            builder.HasOne(jot => jot.Technology)
                .WithMany(t => t.JobOfferTechnology)
                .HasForeignKey(jot => jot.TechnologyId);
        }
    }
}
