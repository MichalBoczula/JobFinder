using JobsCatalog.Domain.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Seed.Helper
{
    public static class JobOfferTechnologySeed
    {
        public static void CreateJobOfferTechnologySeed(this ModelBuilder modelBuilder)
        {
            var jobSoftawareSolution11 = new JobOfferTechnology()
            {
                JobOfferId = 1,
                TechnologyId = 1
            };
            var jobSoftawareSolution12 = new JobOfferTechnology()
            {
                JobOfferId = 1,
                TechnologyId = 2
            };
            var jobSoftawareSolution13 = new JobOfferTechnology()
            {
                JobOfferId = 1,
                TechnologyId = 3
            };

            var jobSoftawareSolution21 = new JobOfferTechnology()
            {
                JobOfferId = 2,
                TechnologyId = 1
            };
            var jobSoftawareSolution22 = new JobOfferTechnology()
            {
                JobOfferId = 2,
                TechnologyId = 2
            };
            var jobSoftawareSolution23 = new JobOfferTechnology()
            {
                JobOfferId = 2,
                TechnologyId = 3
            };
            var jobSoftawareSolution24 = new JobOfferTechnology()
            {
                JobOfferId = 2,
                TechnologyId = 14
            };
            var jobSoftawareSolution25 = new JobOfferTechnology()
            {
                JobOfferId = 2,
                TechnologyId = 15
            };

            var jobSoftawareSolution31 = new JobOfferTechnology()
            {
                JobOfferId = 3,
                TechnologyId = 1
            };
            var jobSoftawareSolution32 = new JobOfferTechnology()
            {
                JobOfferId = 3,
                TechnologyId = 2
            };
            var jobSoftawareSolution33 = new JobOfferTechnology()
            {
                JobOfferId = 3,
                TechnologyId = 3
            };
            var jobSoftawareSolution34 = new JobOfferTechnology()
            {
                JobOfferId = 3,
                TechnologyId = 14
            };
            var jobSoftawareSolution35 = new JobOfferTechnology()
            {
                JobOfferId = 3,
                TechnologyId = 15
            };

            var jobSoftawareSolution41 = new JobOfferTechnology()
            {
                JobOfferId = 4,
                TechnologyId = 10
            };
            var jobSoftawareSolution42 = new JobOfferTechnology()
            {
                JobOfferId = 4,
                TechnologyId = 11
            };
            var jobSoftawareSolution43 = new JobOfferTechnology()
            {
                JobOfferId = 4,
                TechnologyId = 12
            };
            var jobSoftawareSolution44 = new JobOfferTechnology()
            {
                JobOfferId = 4,
                TechnologyId = 13
            };
            var jobSoftawareSolution45 = new JobOfferTechnology()
            {
                JobOfferId = 4,
                TechnologyId = 2
            };

            var jobSoftawareSolution51 = new JobOfferTechnology()
            {
                JobOfferId = 5,
                TechnologyId = 10
            };
            var jobSoftawareSolution52 = new JobOfferTechnology()
            {
                JobOfferId = 5,
                TechnologyId = 11
            };
            var jobSoftawareSolution53 = new JobOfferTechnology()
            {
                JobOfferId = 5,
                TechnologyId = 12
            };
            var jobSoftawareSolution54 = new JobOfferTechnology()
            {
                JobOfferId = 5,
                TechnologyId = 13
            };
            var jobSoftawareSolution55 = new JobOfferTechnology()
            {
                JobOfferId = 5,
                TechnologyId = 2
            };

            var jobSoftawareSolution61 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 10
            };
            var jobSoftawareSolution62 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 11
            };
            var jobSoftawareSolution63 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 12
            };
            var jobSoftawareSolution64 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 13
            };
            var jobSoftawareSolution65 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 2
            };
            var jobSoftawareSolution66 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 6
            };
            var jobSoftawareSolution67 = new JobOfferTechnology()
            {
                JobOfferId = 6,
                TechnologyId = 7
            };

            var jobSoftawareSolution71 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 1
            };
            var jobSoftawareSolution72 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 2
            };
            var jobSoftawareSolution73 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 3
            };
            var jobSoftawareSolution74 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 14
            };
            var jobSoftawareSolution75 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 15
            };
            var jobSoftawareSolution76 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 6
            };
            var jobSoftawareSolution77 = new JobOfferTechnology()
            {
                JobOfferId = 7,
                TechnologyId = 7
            };

            var jobSoftawareSolution81 = new JobOfferTechnology()
            {
                JobOfferId = 8,
                TechnologyId = 17
            };
            var jobSoftawareSolution82 = new JobOfferTechnology()
            {
                JobOfferId = 8,
                TechnologyId = 18
            };
            var jobSoftawareSolution83 = new JobOfferTechnology()
            {
                JobOfferId = 8,
                TechnologyId = 2
            };
            var jobSoftawareSolution84 = new JobOfferTechnology()
            {
                JobOfferId = 8,
                TechnologyId = 7
            };
            var jobSoftawareSolution85 = new JobOfferTechnology()
            {
                JobOfferId = 8,
                TechnologyId = 16
            };

            var jobSoftawareSolution91 = new JobOfferTechnology()
            {
                JobOfferId = 9,
                TechnologyId = 19
            };

            var jobSoftawareSolution101 = new JobOfferTechnology()
            {
                JobOfferId = 10,
                TechnologyId = 4
            };
            var jobSoftawareSolution102 = new JobOfferTechnology()
            {
                JobOfferId = 10,
                TechnologyId = 5
            };
            var jobSoftawareSolution103 = new JobOfferTechnology()
            {
                JobOfferId = 10,
                TechnologyId = 8
            };
            var jobSoftawareSolution104 = new JobOfferTechnology()
            {
                JobOfferId = 10,
                TechnologyId = 9
            };

            var jobSoftawareSolution111 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 10
            };
            var jobSoftawareSolution112 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 11
            };
            var jobSoftawareSolution113 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 12
            };
            var jobSoftawareSolution114 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 13
            };
            var jobSoftawareSolution115 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 6
            };
            var jobSoftawareSolution116 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 7
            };
            var jobSoftawareSolution117 = new JobOfferTechnology()
            {
                JobOfferId = 11,
                TechnologyId = 16
            };

            var jobSoftawareSolution121 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 1
            };
            var jobSoftawareSolution122 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 2
            };
            var jobSoftawareSolution123 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 3
            };
            var jobSoftawareSolution124 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 14
            };
            var jobSoftawareSolution125 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 15
            };
            var jobSoftawareSolution126 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 6
            };
            var jobSoftawareSolution127 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 7
            };
            var jobSoftawareSolution128 = new JobOfferTechnology()
            {
                JobOfferId = 12,
                TechnologyId = 16
            };

            var jobSoftawareSolution131 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 1
            };
            var jobSoftawareSolution132 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 2
            };
            var jobSoftawareSolution133 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 3
            };
            var jobSoftawareSolution134 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 14
            };
            var jobSoftawareSolution135 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 15
            };
            var jobSoftawareSolution136 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 6
            };
            var jobSoftawareSolution137 = new JobOfferTechnology()
            {
                JobOfferId = 13,
                TechnologyId = 7
            };

            var jobSoftawareSolution141 = new JobOfferTechnology()
            {
                JobOfferId = 14,
                TechnologyId = 17
            };
            var jobSoftawareSolution142 = new JobOfferTechnology()
            {
                JobOfferId = 14,
                TechnologyId = 18
            };
            var jobSoftawareSolution143 = new JobOfferTechnology()
            {
                JobOfferId = 14,
                TechnologyId = 2
            };
            var jobSoftawareSolution144 = new JobOfferTechnology()
            {
                JobOfferId = 14,
                TechnologyId = 7
            };
            var jobSoftawareSolution145 = new JobOfferTechnology()
            {
                JobOfferId = 14,
                TechnologyId = 16
            };

            var jobSoftawareSolution151 = new JobOfferTechnology()
            {
                JobOfferId = 15,
                TechnologyId = 4
            };
            var jobSoftawareSolution152 = new JobOfferTechnology()
            {
                JobOfferId = 15,
                TechnologyId = 5
            };
            var jobSoftawareSolution153 = new JobOfferTechnology()
            {
                JobOfferId = 15,
                TechnologyId = 8
            };
            var jobSoftawareSolution154 = new JobOfferTechnology()
            {
                JobOfferId = 15,
                TechnologyId = 9
            };

            modelBuilder.Entity<JobOfferTechnology>()
               .HasData(jobSoftawareSolution11);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution12);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution13);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution21);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution22);
            modelBuilder.Entity<JobOfferTechnology>()
               .HasData(jobSoftawareSolution23);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution24);
            modelBuilder.Entity<JobOfferTechnology>()
               .HasData(jobSoftawareSolution25);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution31);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution32);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution33);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution34);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution35);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution41);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution42);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution43);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution44);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution45);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution51);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution52);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution53);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution54);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution55);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution61);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution62);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution63);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution64);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution65);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution66);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution67);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution71);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution72);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution73);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution74);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution75);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution76);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution77);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution81);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution82);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution83);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution84);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution85);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution91);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution101);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution102);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution103);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution104);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution111);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution112);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution113);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution114);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution115);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution116);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution117);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution121);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution122);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution123);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution124);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution125);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution126);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution127);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution128);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution131);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution132);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution133);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution134);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution135);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution136);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution137);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution141);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution142);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution143);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution144);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution145);

            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution151);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution152);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution153);
            modelBuilder.Entity<JobOfferTechnology>()
                .HasData(jobSoftawareSolution154);
        }
    }
}
