using JobsCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Configuration
{
    public class JobOfferConfiguration : IEntityTypeConfiguration<JobOffer>
    {
        public void Configure(EntityTypeBuilder<JobOffer> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasOne(jo => jo.ExperienceLevel)
                .WithMany(el => el.JobOffers)
                .HasForeignKey(jo => jo.ExperienceLevelId);
            builder.HasOne(jo => jo.Company)
                .WithMany(c => c.JobOffers)
                .HasForeignKey(jo => jo.CompanyId);
            builder.HasOne(jo => jo.ProgrammingLanguage)
                .WithMany(pl => pl.JobOffers)
                .HasForeignKey(jo => jo.ProgrammingLanguageId);
            builder.HasOne(jo => jo.JobDescription)
                .WithOne(jod => jod.JobOffer)
                .HasForeignKey<JobDescription>(jd => jd.JobOfferId);
        }
    }
}
