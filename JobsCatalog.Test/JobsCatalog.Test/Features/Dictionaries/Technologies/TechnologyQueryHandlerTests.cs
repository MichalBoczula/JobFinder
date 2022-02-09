using JobsCatalog.Application.Features.Dictionaries.Technologies;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Test.Features.Dictionaries.Technologies
{
    [Collection("QueryCollection")]
    public class TechnologyQueryHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public TechnologyQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new TechnologyQueryHandler(_context);
            var result = await handler.Handle(new TechnologyQuery(), CancellationToken.None);
            Assert.True(result.Count() == 19);
            Assert.IsType<List<TechnologyVm>>(result);
            result.ForEach(x =>
            {
                Assert.True(x.Id > 0);
                Assert.True(String.IsNullOrWhiteSpace(x.Name) == false);
            });
        }
    }
}
