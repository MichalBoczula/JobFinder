using JobsCatalog.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Dictionaries
{
    public static class TechnologiesSeed
    {
        public static void CreateTechnologiesSeed(this ModelBuilder modelBuilder)
        {
            var technology1 = new Technology()
            {
                Id = 1,
                Name = "ASP.Net"
            };
            var technology2 = new Technology()
            {
                Id = 2,
                Name = "SQL"
            };
            var technology3 = new Technology()
            {
                Id = 3,
                Name = "Entity Framwork"
            };
            var technology14 = new Technology()
            {
                Id = 14,
                Name = "XUnit"
            };
            var technology15 = new Technology()
            {
                Id = 15,
                Name = "Moq"
            };

            var technology4 = new Technology()
            {
                Id = 4,
                Name = "HTML"
            };
            var technology5 = new Technology()
            {
                Id = 5,
                Name = "CSS"
            };
            var technology8 = new Technology()
            {
                Id = 8,
                Name = "React"
            };
            var technology9 = new Technology()
            {
                Id = 9,
                Name = "Angular"
            };

            var technology10 = new Technology()
            {
                Id = 10,
                Name = "Hibernate"
            };
            var technology11 = new Technology()
            {
                Id = 11,
                Name = "Spring"
            };
            var technology12 = new Technology()
            {
                Id = 12,
                Name = "JUnit"
            };
            var technology13 = new Technology()
            {
                Id = 13,
                Name = "Mockito"
            };

            var technology6 = new Technology()
            {
                Id = 6,
                Name = "Azure"
            };
            var technology7 = new Technology()
            {
                Id = 7,
                Name = "Docker"
            };
            var technology16 = new Technology()
            {
                Id = 16,
                Name = "AWS"
            };

            var technology17 = new Technology()
            {
                Id = 17,
                Name = "Flask"
            };
            var technology18 = new Technology()
            {
                Id = 18,
                Name = "Django"
            };

            var technology19 = new Technology()
            {
                Id = 19,
                Name = "C++ 17"
            };

            modelBuilder.Entity<Technology>()
                .HasData(technology1);
            modelBuilder.Entity<Technology>()
                .HasData(technology2);
            modelBuilder.Entity<Technology>()
                .HasData(technology3);
            modelBuilder.Entity<Technology>()
                .HasData(technology4);
            modelBuilder.Entity<Technology>()
                .HasData(technology5);
            modelBuilder.Entity<Technology>()
                .HasData(technology6);
            modelBuilder.Entity<Technology>()
                .HasData(technology7);
            modelBuilder.Entity<Technology>()
                .HasData(technology8);
            modelBuilder.Entity<Technology>()
                .HasData(technology9);
            modelBuilder.Entity<Technology>()
                .HasData(technology10);
            modelBuilder.Entity<Technology>()
                .HasData(technology11);
            modelBuilder.Entity<Technology>()
                .HasData(technology12);
            modelBuilder.Entity<Technology>()
                .HasData(technology13);
            modelBuilder.Entity<Technology>()
                .HasData(technology14);
            modelBuilder.Entity<Technology>()
                .HasData(technology15);
            modelBuilder.Entity<Technology>()
                .HasData(technology16);
            modelBuilder.Entity<Technology>()
                .HasData(technology17);
            modelBuilder.Entity<Technology>()
                .HasData(technology18);
            modelBuilder.Entity<Technology>()
                .HasData(technology19);
        }
    }
}
