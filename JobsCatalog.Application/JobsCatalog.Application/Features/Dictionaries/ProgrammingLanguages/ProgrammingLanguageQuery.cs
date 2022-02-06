using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Dictionaries.ProgrammingLanguages
{
    public class ProgrammingLanguageQuery : IRequest<List<ProgrammingLanguageVm>>
    {
    }
}
