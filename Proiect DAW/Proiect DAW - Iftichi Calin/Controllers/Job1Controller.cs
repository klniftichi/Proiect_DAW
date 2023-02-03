using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Proiect_DAW___Iftichi_Calin.Services.DemoService;

namespace Proiect_DAW___Iftichi_Calin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Job1Controller : ControllerBase
    {
        private readonly IJobService _jobService;

        public Job1Controller(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("Joburile dintr-o anumita categorie")]
        public IActionResult GetByCategory(string category) // repository -> cu baza de date ; serviciile se folos. de repos pt a lua ce date are nevoie -> serviciul este apelat in controller
        {
            var result = _jobService.GetDataMappedByCategory(category);
            return Ok(result);
        }
    }
}
