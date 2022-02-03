using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Dictionaries.Technologies
{
    public class TechnologyQueryHandler : IRequestHandler<TechnologyQuery, List<TechnologyVm>>
    {
        private readonly IJobsCatalogDbContext _context;
        
        public TechnologyQueryHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<List<TechnologyVm>> Handle(TechnologyQuery request, CancellationToken cancellationToken)
        {
            var technologyVm = await _context.Technologies
                .Select(x => new TechnologyVm
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync(cancellationToken);

            return technologyVm;
        }
    }
}
