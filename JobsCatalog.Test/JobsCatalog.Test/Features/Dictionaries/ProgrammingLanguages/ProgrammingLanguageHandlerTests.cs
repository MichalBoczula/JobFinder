using JobsCatalog.Application.Features.Dictionaries.ProgrammingLanguages;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Test.Features.Dictionaries.ProgrammingLanguages
{
    [Collection("QueryCollection")]
    public class ProgrammingLanguageHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public ProgrammingLanguageHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new ProgrammingLanguageQueryHandler(_context);
            var result = await handler.Handle(new ProgrammingLanguageQuery(), CancellationToken.None);
            Assert.True(result.Count() == 5);
            Assert.IsType<List<ProgrammingLanguageVm>>(result);
            result.ForEach(x =>
            {
                Assert.True(x.Id > 0);
                Assert.True(String.IsNullOrWhiteSpace(x.Name) == false);
                Assert.True(String.IsNullOrWhiteSpace(x.Image) == false);
            });
        }
    }
}
