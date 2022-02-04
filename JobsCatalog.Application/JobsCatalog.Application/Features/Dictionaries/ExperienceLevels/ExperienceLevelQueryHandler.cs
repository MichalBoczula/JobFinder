using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Dictionaries.ExperienceLevels
{
    public class ExperienceLevelQueryHandler : IRequestHandler<ExperienceLevelQuery, List<ExperienceLevelVm>>
    {
        private readonly IJobsCatalogDbContext _context;

        public ExperienceLevelQueryHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<List<ExperienceLevelVm>> Handle(ExperienceLevelQuery request, CancellationToken cancellationToken)
        {
            var experienceLevelVm = await _context.ExperienceLeves
                .Select(x => new ExperienceLevelVm
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync(cancellationToken);
            return experienceLevelVm;
        }
    }
}
