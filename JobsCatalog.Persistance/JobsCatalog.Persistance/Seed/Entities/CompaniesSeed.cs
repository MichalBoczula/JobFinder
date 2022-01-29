using JobsCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Entities
{
    public static class CompaniesSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var softawareSolution = new Company()
            {
                Id = 1,
                Name = "Software Solution",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. " +
                    "Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. " +
                    "Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. " +
                    "Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.",
                CompanyLogo = "SoftwareSolution"
            };

            var swissUnionBank= new Company()
            {
                Id = 2,
                Name = "Swiss Union Bank",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. " +
                    "Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. " +
                    "Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. " +
                    "Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.",
                CompanyLogo = "SwissUnionBank"
            };

            var creativity = new Company()
            {
                Id = 3,
                Name = "Creativity",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. " +
                    "Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. " +
                    "Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. " +
                    "Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.",
                CompanyLogo = "Creativity"
            };

            var itOpportunity= new Company()
            {
                Id = 4,
                Name = "It Opportunity",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. " +
                    "Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. " +
                    "Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. " +
                    "Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.",
                CompanyLogo = "ItOpportunity"
            };

            var softMatter= new Company()
            {
                Id = 5,
                Name = "Soft Matter",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. " +
                    "Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. " +
                    "Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. " +
                    "Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.",
                CompanyLogo = "SoftMatter"
            };
        }
    }
}
