﻿using JobsCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Entities
{
    public static class JobOffersSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var admin = "Admin";
            var date = DateTimeOffset.UtcNow;
            var jobSoftawareSolution1 = new JobOffer()
            {
                Id = 1,
                PositionName = "Junior .Net Developer",
                SalaryMin = 6000,
                SalaryMax = 8000,
                City = "Wroclaw",
                CompanyId = 1,
                ExperienceLevelId = 1,
                JobDescriptionId = 1,
                ProgrammingLanguageId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
                StatusId = 1
            };

            var jobSoftawareSolution2 = new JobOffer()
            {
                Id = 2,
                PositionName = ".Net Developer",
                SalaryMin = 10000,
                SalaryMax = 15000,
                City = "Wroclaw",
                CompanyId = 1,
                ExperienceLevelId = 2,
                JobDescriptionId = 3,
                ProgrammingLanguageId = 1,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var jobSoftawareSolution3 = new JobOffer()
            {
                Id = 3,
                PositionName = "Senior .Net Developer",
                SalaryMin = 15000,
                SalaryMax = 20000,
                City = "Wroclaw",
                CompanyId = 1,
                ExperienceLevelId = 3,
                JobDescriptionId = 3,
                ProgrammingLanguageId = 1,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };


            var swissUnionBank1 = new JobOffer()
            {
                Id = 4,
                PositionName = "Java Developer",
                SalaryMin = 10000,
                SalaryMax = 15000,
                City = "Warsaw",
                CompanyId = 2,
                ExperienceLevelId = 2,
                JobDescriptionId = 4,
                ProgrammingLanguageId = 2,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var swissUnionBank2 = new JobOffer()
            {
                Id = 5,
                PositionName = "Senior Java Developer",
                SalaryMin = 15000,
                SalaryMax = 20000,
                City = "Warsaw",
                CompanyId = 2,
                ExperienceLevelId = 3,
                JobDescriptionId = 5,
                ProgrammingLanguageId = 2,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var swissUnionBank3 = new JobOffer()
            {
                Id = 6,
                PositionName = "Java Tech Lead",
                SalaryMin = 20000,
                SalaryMax = 30000,
                City = "Warsaw",
                CompanyId = 2,
                ExperienceLevelId = 4,
                JobDescriptionId = 6,
                ProgrammingLanguageId = 2,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var creativity1 = new JobOffer()
            {
                Id = 7,
                PositionName = ".Net Developer",
                SalaryMin = 10000,
                SalaryMax = 15000,
                City = "Remote",
                CompanyId = 3,
                ExperienceLevelId = 2,
                JobDescriptionId = 7,
                ProgrammingLanguageId = 1,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var creativity2 = new JobOffer()
            {
                Id = 8,
                PositionName = "Python Developer",
                SalaryMin = 10000,
                SalaryMax = 15000,
                City = "Poznan",
                CompanyId = 3,
                ExperienceLevelId = 2,
                JobDescriptionId = 8,
                ProgrammingLanguageId = 3,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var creativity3 = new JobOffer()
            {
                Id = 9,
                PositionName = "C++ Tech Lead",
                SalaryMin = 20000,
                SalaryMax = 30000,
                City = "Remote",
                CompanyId = 4,
                ExperienceLevelId = 4,
                JobDescriptionId = 9,
                ProgrammingLanguageId = 5,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var itOpportunity1 = new JobOffer()
            {
                Id = 10,
                PositionName = "Junior JavaScript Developer",
                SalaryMin = 6000,
                SalaryMax = 8000,
                City = "Poznan",
                CompanyId = 4,
                ExperienceLevelId = 1,
                JobDescriptionId = 10,
                ProgrammingLanguageId = 4,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var itOpportunity2 = new JobOffer()
            {
                Id = 11,
                PositionName = "Senior JavaScript Developer",
                SalaryMin = 15000,
                SalaryMax = 20000,
                City = "Gdansk",
                CompanyId = 4,
                ExperienceLevelId = 3,
                JobDescriptionId = 11,
                ProgrammingLanguageId = 4,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var itOpportunity3 = new JobOffer()
            {
                Id = 12,
                PositionName = "Java Tech Lead",
                SalaryMin = 20000,
                SalaryMax = 30000,
                City = "Katowice",
                CompanyId = 4,
                ExperienceLevelId = 4,
                JobDescriptionId = 12,
                ProgrammingLanguageId = 2,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var softMatter1 = new JobOffer()
            {
                Id = 13,
                PositionName = ".Net Tech Lead",
                SalaryMin = 20000,
                SalaryMax = 30000,
                City = "Crakow",
                CompanyId = 5,
                ExperienceLevelId = 4,
                JobDescriptionId = 13,
                ProgrammingLanguageId = 1,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var softMatter2 = new JobOffer()
            {
                Id = 14,
                PositionName = "Python Developer",
                SalaryMin = 10000,
                SalaryMax = 15000,
                City = "Remote",
                CompanyId = 5,
                ExperienceLevelId = 2,
                JobDescriptionId = 14,
                ProgrammingLanguageId = 3,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };

            var softMatter3 = new JobOffer()
            {
                Id = 15,
                PositionName = "JavaScript Developer",
                SalaryMin = 10000,
                SalaryMax = 15000,
                City = "Crakow",
                CompanyId = 5,
                ExperienceLevelId = 2,
                JobDescriptionId = 15,
                ProgrammingLanguageId = 4,
                StatusId = 1,
                CreatedBy = admin,
                Created = date,
                ModifiedBy = admin,
                Modified = date,
            };
        }
    }
}
