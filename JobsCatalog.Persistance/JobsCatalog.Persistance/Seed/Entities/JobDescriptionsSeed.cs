using JobsCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Entities
{
    public static class JobDescriptionsSeed
    {
        public static void CreateJobDescriptionsSeed(this ModelBuilder modelBuilder)
        {
            var admin = "Admin";
            var date = DateTimeOffset.UtcNow;
            var about = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Integer id viverra erat. Nulla euismod laoreet metus vitae mollis." +
                    " Orci varius natoque penatibus et magnis dis parturient montes, " +
                    "nascetur ridiculus mus. Nulla maximus libero non elementum congue. " +
                    "Vestibulum dignissim pellentesque mauris non molestie. " +
                    "Aliquam neque ligula, rutrum at tincidunt ut, " +
                    "fringilla posuere risus. Aenean porta convallis turpis, " +
                    "et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.";
            var responsibilities = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                   "Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. " +
                   "Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. " +
                   "Etiam porttitor elit vitae purus dapibus consectetur. " +
                   "Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. " +
                   "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices " +
                   "posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, " +
                   "cursus congue augue. Integer condimentum sollicitudin nunc in tristique. " +
                   "Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. " +
                   "Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, " +
                   "massa orci tempor tellus, consequat gravida nisi nibh et dui. " +
                   "Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. " +
                   "Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, " +
                   "sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.";
            var expectation = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Nam ut justo id nisl egestas mattis." +
                    "Proin ac ipsum eget velit varius pretium." +
                    "Nam porta ligula vitae diam auctor dictum." +
                    "Nulla varius nunc in velit ultrices ullamcorper.";
            var offer = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Maecenas in lacus id ex iaculis iaculis vel ac metus." +
                    "Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo." +
                    "Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt." +
                    "Donec eget turpis tincidunt, tempus erat at, venenatis erat." +
                    "Duis ultricies dui ac tempor placerat." +
                    "Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.";

            var jobOfferDesc1 = new JobDescription()
            {
                Id = 1,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc2 = new JobDescription()
            {
                Id = 2,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 2,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc3 = new JobDescription()
            {
                Id = 3,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 3,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc4 = new JobDescription()
            {
                Id = 4,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 4,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc5 = new JobDescription()
            {
                Id = 5,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 5,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc6 = new JobDescription()
            {
                Id = 6,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 6,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc7 = new JobDescription()
            {
                Id = 7,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 7,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc8 = new JobDescription()
            {
                Id = 8,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 8,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc9 = new JobDescription()
            {
                Id = 9,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 9,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc10 = new JobDescription()
            {
                Id = 10,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 10,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc11 = new JobDescription()
            {
                Id = 11,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 11,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc12 = new JobDescription()
            {
                Id = 12,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 12,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc13 = new JobDescription()
            {
                Id = 13,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 13,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc14 = new JobDescription()
            {
                Id = 14,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 14,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobOfferDesc15 = new JobDescription()
            {
                Id = 15,
                About = about,
                Responsibilities = responsibilities,
                Expectation = expectation,
                Offer = offer,
                JobOfferId = 15,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            modelBuilder.Entity<JobDescription>()
               .HasData(jobOfferDesc1);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc2);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc3);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc4);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc5);
            modelBuilder.Entity<JobDescription>()
               .HasData(jobOfferDesc6);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc7);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc8);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc9);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc10);
            modelBuilder.Entity<JobDescription>()
               .HasData(jobOfferDesc11);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc12);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc13);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc14);
            modelBuilder.Entity<JobDescription>()
                .HasData(jobOfferDesc15);
        }
    }
}
