using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;

namespace Proiect_DAW___Iftichi_Calin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private ProiectContext _proiectContext;

        public JobController(ProiectContext proiectContext)
        {
            _proiectContext = proiectContext;
        }

        [HttpGet("Afiseaza job-urile")]

        public async Task<IActionResult> GetJoburi()
        {
            return Ok(await _proiectContext.Joburi.ToListAsync());
        }

        [HttpPost("Listeaza un nou job *nu o sa mearga pana nu adaug companii*")]
        public async Task<IActionResult> Create(JobDTO jobDTO)
        {
            var newJob = new Job();
            newJob.Nume_Job = jobDTO.Nume_Job;
            newJob.Categorie_job = jobDTO.Categorie_job;
            newJob.Criterii = jobDTO.Criterii;
            newJob.Descriere_job = jobDTO.Descriere_job;

            var company = await _proiectContext.Companii.FirstOrDefaultAsync(c => c.CompanieId == jobDTO.CompanieId);
            if (company == null)
            {
                return BadRequest("The specified company was not found.");
            }
            newJob.Companie = company;

            await _proiectContext.AddAsync(newJob);
            await _proiectContext.SaveChangesAsync();
            return Ok(newJob);
        }

    }
}
