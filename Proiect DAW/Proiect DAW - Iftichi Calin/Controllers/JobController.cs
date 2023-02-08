using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Services.DemoService;
using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Helpers.Atributes;
using Proiect_DAW___Iftichi_Calin.Models.Enums;

namespace Proiect_DAW___Iftichi_Calin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

       // [Authorization(Rol.User)]
        [HttpGet("Joburile dintr-o anumita categorie **NOT WORKING YET**")]
        public IActionResult GetByCategory(string category) // repository -> cu baza de date ; serviciile se folos. de repos pt a lua ce date are nevoie -> serviciul este apelat in controller
        {
            var result = _jobService.GetDataMappedByCategory(category);
            return Ok(result);
        }
    }
}
