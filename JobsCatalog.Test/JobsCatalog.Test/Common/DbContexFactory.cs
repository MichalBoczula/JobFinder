using JobsCatalog.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Test.Common
{
    public static class DbContexFactory
    {
        public static Mock<JobsCatalogDbContext> Create()
        {
            var options = new DbContextOptionsBuilder<JobsCatalogDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var mock = new Mock<JobsCatalogDbContext>(options) { CallBase = true };
            mock.Object.Database.EnsureCreated();
            mock.Object.SaveChanges();
            return mock;
        }

        public static void CleanUp(JobsCatalogDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
