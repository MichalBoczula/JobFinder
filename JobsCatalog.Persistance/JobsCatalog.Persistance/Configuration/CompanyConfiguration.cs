using JobsCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Configuration
{
    public class CompanyConfiguration
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasMany(c => c.JobOffers)
                .WithOne(jo => jo.Company)
                .HasForeignKey(jo => jo.CompanyId);
        }
    }
}
