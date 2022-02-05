using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Entities.JobsList
{
    public class JobsListQuery : IRequest<List<JobsListVm>>
    {
    }
}
