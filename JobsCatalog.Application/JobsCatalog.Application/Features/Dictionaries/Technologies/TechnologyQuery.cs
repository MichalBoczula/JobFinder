using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Dictionaries.Technologies
{
    public class TechnologyQuery : IRequest<List<TechnologyVm>>
    {
    }
}
