using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.JobsList
{
    public class JobsListQueryHandler : IRequestHandler<JobsListQuery, List<JobsListVm>>
    {
        private readonly IJobsCatalogDbContext _context;

        public JobsListQueryHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public Task<List<JobsListVm>> Handle(JobsListQuery request, CancellationToken cancellationToken)
        {
            var vm = _context.JobOffers
                .Join(_context.Companies,
                    jo => jo.CompanyId,
                    c => c.Id,
                    (jo, c) => new { Jobs = jo, Company = c })
                .Join(_context.ProgrammingLanguages,
                    x => x.Jobs.ProgrammingLanguageId,
                    pl => pl.Id,
                    (x, pl) => new { x.Jobs, x.Company, ProgrammingLanguage = pl })
                .Select(x => new JobsListVm()
                {
                    Id = x.Jobs.Id,
                    PositionName = x.Jobs.PositionName,
                    SalaryMin = x.Jobs.SalaryMin,
                    SalaryMax = x.Jobs.SalaryMax,
                    City = x.Jobs.City,
                    CompanyName = x.Company.Name,
                    CompanyImage = x.Company.CompanyLogo,
                    ProgrammingLanguageImage = x.ProgrammingLanguage.Image
                });

            return vm.ToListAsync(cancellationToken);
        }
    }
}
