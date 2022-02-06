using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Common;
using JobsCatalog.Domain.Dictionaries;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using JobsCatalog.Persistance.Seed.Dictionaries;
using JobsCatalog.Persistance.Seed.Entities;
using JobsCatalog.Persistance.Seed.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Persistance.Context
{
    public class JobsCatalogDbContext : DbContext, IJobsCatalogDbContext
    {
        public DbSet<ExperienceLevel> ExperienceLeves { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<JobOfferTechnology> JobOfferTechnologies { get; set; }

        public JobsCatalogDbContext([NotNull] DbContextOptions<JobsCatalogDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.CreateExperienceLevelsSeed();
            modelBuilder.CreateProgrammingLanguagesSeed();
            modelBuilder.CreateTechnologiesSeed();
            modelBuilder.CreateCompaniesSeed();
            modelBuilder.CreateJobOffersSeed();
            modelBuilder.CreateJobDescriptionsSeed();
            modelBuilder.CreateJobOfferTechnologySeed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "Admin";
                        entry.Entity.Created = DateTimeOffset.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "Admin";
                        entry.Entity.Modified = DateTimeOffset.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "Admin";
                        entry.Entity.Modified = DateTimeOffset.Now;
                        entry.Entity.Inactivated = DateTimeOffset.Now;
                        entry.Entity.InactivatedBy = "Admin";
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
