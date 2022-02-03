using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Dictionaries.ProgrammingLanguages
{

    public class ProgrammingLanguageQueryHandler : IRequestHandler<ProgrammingLanguageQuery, List<ProgrammingLanguageVm>>
    {
        private readonly IJobsCatalogDbContext _context;

        public ProgrammingLanguageQueryHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProgrammingLanguageVm>> Handle(ProgrammingLanguageQuery request, CancellationToken cancellationToken)
        {
            var programmingLanguageVm = await _context.ProgrammingLanguages
                 .Select(x => new ProgrammingLanguageVm
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Image = x.Image
                 })
                 .ToListAsync(cancellationToken);

            return programmingLanguageVm;
        }
    }
}
