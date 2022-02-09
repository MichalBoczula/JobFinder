using JobsCatalog.Application.Features.Entities.JobDetails;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Test.Features.Entiteis.Details
{
    [Collection("QueryCollection")]
    public class JobDetailsQueryHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public JobDetailsQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnObject()
        {
            var handler = new JobDetailsQueryHandler(_context);
            var result = await handler.Handle(new JobDetailsQuery() { Id = 1} , CancellationToken.None);
            Assert.IsType<JobDetailsVm>(result);
            Assert.True(result.Id > 0);
            Assert.True(String.IsNullOrWhiteSpace(result.PositionName) == false);
            Assert.True(result.SalaryMin > 0);
            Assert.IsType<int>(result.SalaryMin);
            Assert.True(result.SalaryMax > 0);
            Assert.IsType<int>(result.SalaryMax);
            Assert.True((String.IsNullOrWhiteSpace(result.City) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.CompanyName) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.CompanyImage) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.ProgrammingLanguageImage) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.About) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.Responsibilities) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.Expectation) == false));
            Assert.True((String.IsNullOrWhiteSpace(result.Offer) == false));
            Assert.True(result.Technologies.Count == 3);
            result.Technologies.ForEach(x =>
            {
                Assert.True((String.IsNullOrWhiteSpace(x) == false));
            });
        }

        [Fact]
        public async Task ShouldReturnNull()
        {
            var handler = new JobDetailsQueryHandler(_context);
            var result = await handler.Handle(new JobDetailsQuery() { Id = 111 }, CancellationToken.None);
            Assert.Null(result);
        }
    }
}
