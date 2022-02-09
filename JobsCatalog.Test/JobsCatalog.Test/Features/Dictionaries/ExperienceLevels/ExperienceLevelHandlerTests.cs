using JobsCatalog.Application.Features.Dictionaries.ExperienceLevels;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Test.Features.Dictionaries.ExperienceLevels
{
    [Collection("QueryCollection")]
    public class ExperienceLevelHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public ExperienceLevelHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new ExperienceLevelQueryHandler(_context);
            var result = await handler.Handle(new ExperienceLevelQuery(), CancellationToken.None);
            Assert.True(result.Count() == 4);
            Assert.IsType<List<ExperienceLevelVm>>(result);
            result.ForEach(x =>
            {
                Assert.True(x.Id > 0);
                Assert.True(String.IsNullOrWhiteSpace(x.Name) == false);
            });
        }
    }
}