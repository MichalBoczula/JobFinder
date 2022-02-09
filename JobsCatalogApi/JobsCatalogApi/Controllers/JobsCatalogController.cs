using JobsCatalog.Application.Features.Entities.JobDetails;
using JobsCatalog.Application.Features.Entities.JobsList;
using JobsCatalogApi.Common;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCatalogApi.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsCatalogController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetJobsList()
        {
            Log.Information("Controller {JobsCatalogController} action {GetJobsList}");
            var vm = await Mediator.Send(new JobsListQuery());
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetJobDetails(int id)
        {
            Log.ForContext("id", id)
                .Information("Controller {JobsCatalogController} action {GetJobDetails}");
            var vm = await Mediator.Send(new JobDetailsQuery() { Id = id});
            return Ok(vm);
        }
    }
}
