﻿using JobsCatalog.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Dictionaries
{
    public static class ExperienceLevelsSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var junior = new ExperienceLevel()
            {
                Id = 1,
                Name = "Junior"
            };

            var mid = new ExperienceLevel()
            {
                Id = 2,
                Name = "Mid"
            };

            var senior = new ExperienceLevel()
            {
                Id = 3,
                Name = "Senior"
            };

            var expert = new ExperienceLevel()
            {
                Id = 4,
                Name = "Expert"
            };
        }
    }
}
