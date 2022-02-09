using JobsCatalog.Application.Features.Dictionaries.ExperienceLevels;
using JobsCatalog.Application.Features.Dictionaries.ProgrammingLanguages;
using JobsCatalog.Application.Features.Dictionaries.Technologies;
using JobsCatalogApi.Common;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCatalogApi.Controllers
{
    [Route("api/dictionaries")]
    [ApiController]
    public class DictionaryController : BaseController
    {
        [HttpGet("experienceLevels")]
        public async Task<ActionResult<ExperienceLevelVm>> GetExperienceLevels()
        {
            Log.Information("Controller {DictionaryController} action {GetExperienceLevels}");
            var vm = await Mediator.Send(new ExperienceLevelQuery());
            return Ok(vm);
        }

        [HttpGet("programmingLanguages")]
        public async Task<ActionResult<List<ProgrammingLanguageVm>>> GetProgrammingLanguages()
        {
            Log.Information("Controller {DictionaryController} action {GetExperienceLevels}");
            var vm = await Mediator.Send(new ProgrammingLanguageQuery());
            return Ok(vm);
        }

        [HttpGet("technologies")]
        public async Task<ActionResult<TechnologyVm>> GetTechnologies()
        {
            Log.Information("Controller {DictionaryController} action {GetExperienceLevels}");
            var vm = await Mediator.Send(new TechnologyQuery());
            return Ok(vm);
        }
    }
}
