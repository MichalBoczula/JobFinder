using JobsCatalog.Domain.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Dictionaries
{
    public static class ProgrammingLanguagesSeed
    {
        public static void CreateProgrammingLanguagesSeed(this ModelBuilder modelBuilder)
        {
            var cSharp = new ProgrammingLanguage()
            {
                Id = 1,
                Name = "C#",
                Image = "CSharp"
            };

            var java = new ProgrammingLanguage()
            {
                Id = 2,
                Name = "Java",
                Image = "Java"
            };

            var python = new ProgrammingLanguage()
            {
                Id = 3,
                Name = "Python",
                Image = "Python"
            };

            var js = new ProgrammingLanguage()
            {
                Id = 4,
                Name = "JavaScript",
                Image = "JavaScript"
            };

            var cPlusPlus = new ProgrammingLanguage()
            {
                Id = 5,
                Name = "C++",
                Image = "CPlusPlus"
            };

            modelBuilder.Entity<ProgrammingLanguage>()
                .HasData(cSharp);
            modelBuilder.Entity<ProgrammingLanguage>()
                .HasData(java);
            modelBuilder.Entity<ProgrammingLanguage>()
                .HasData(python);
            modelBuilder.Entity<ProgrammingLanguage>()
                .HasData(js);
            modelBuilder.Entity<ProgrammingLanguage>()
                .HasData(cPlusPlus);
        }
    }
}
