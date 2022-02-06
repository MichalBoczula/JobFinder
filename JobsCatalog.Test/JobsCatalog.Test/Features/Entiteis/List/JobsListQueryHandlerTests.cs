using JobsCatalog.Application.Features.Entities.JobsList;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Test.Features.Entiteis.List
{
    [Collection("QueryCollection")]
    public class JobsListQueryHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public JobsListQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new JobsListQueryHandler(_context);
            var result = await handler.Handle(new JobsListQuery(), CancellationToken.None);
            Assert.True(result.Count() == 15);
            Assert.IsType<List<JobsListVm>>(result);
            result.ForEach(x =>
            {
                Assert.True(x.Id > 0);
                Assert.True(String.IsNullOrWhiteSpace(x.PositionName) == false);
                Assert.True(x.SalaryMin > 0);
                Assert.IsType<int>(x.SalaryMin);
                Assert.True(x.SalaryMax > 0);
                Assert.IsType<int>(x.SalaryMax);
                Assert.True((String.IsNullOrWhiteSpace(x.City) == false));
                Assert.True((String.IsNullOrWhiteSpace(x.CompanyName) == false));
                Assert.True((String.IsNullOrWhiteSpace(x.CompanyImage) == false));
                Assert.True((String.IsNullOrWhiteSpace(x.ProgrammingLanguageImage) == false));
            });
        }
    }
}
