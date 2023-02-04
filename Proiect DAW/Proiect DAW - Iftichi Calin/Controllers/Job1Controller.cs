using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;
using Proiect_DAW___Iftichi_Calin.Models;
using Microsoft.EntityFrameworkCore;

namespace Proiect_DAW___Iftichi_Calin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Job1Controller : ControllerBase
    {
        private ProiectContext _proiectContext;

        public Job1Controller(ProiectContext proiectContext)
        {
            _proiectContext = proiectContext;
        }


        [HttpGet("Afiseaza toate job-urile")]

        public async Task<IActionResult> GetJoburi()
        {
            return Ok(await _proiectContext.Joburi.ToListAsync());
        }

        [HttpPost("Listeaza un nou job")]
        public async Task<IActionResult> Create(JobDTO jobDTO)
        {
            var newJob = new Job();
            newJob.JobId = Guid.NewGuid();
            newJob.Nume_Job = jobDTO.Nume_Job;
            newJob.Categorie_job = jobDTO.Categorie_job;
            newJob.Criterii = jobDTO.Criterii;
            newJob.Descriere_job = jobDTO.Descriere_job;


            var company = await _proiectContext.Companii.FirstOrDefaultAsync(c => c.CompanieId == jobDTO.CompanieId);
            if (company == null)
            {
                return BadRequest("Compania specificata nu exista.");
            }
            else
            {
                newJob.Companie = company;
            }

            await _proiectContext.AddAsync(newJob);
            await _proiectContext.SaveChangesAsync();
            return Ok(newJob);
        }

        [HttpDelete("Sterge un job existent")]
        public async Task<IActionResult> Delete(Guid jobId)
        {
            var job = await _proiectContext.Joburi.FirstOrDefaultAsync(j => j.JobId == jobId);
            if (job == null)
            {
                return NotFound("Job-ul specificat nu a fost gasit.");
            }
            _proiectContext.Joburi.Remove(job);
            await _proiectContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
