using JobsCatalog.Domain.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Helper
{
    public static class JobOfferTechnologySeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var jobSoftawareSolution11 = new JobOfferTechnology()
            {
                JobOfferId = 1
            };
            var jobSoftawareSolution12 = new JobOfferTechnology()
            {
                JobOfferId = 1
            };
            var jobSoftawareSolution13 = new JobOfferTechnology()
            {
                JobOfferId = 1
            };

            var jobSoftawareSolution14 = new JobOfferTechnology()
            {
                JobOfferId = 1
            };
            var jobSoftawareSolution15 = new JobOfferTechnology()
            {
                JobOfferId = 1
            };
        }
    }
}
