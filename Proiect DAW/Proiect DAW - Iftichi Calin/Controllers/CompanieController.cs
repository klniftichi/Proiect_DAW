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
    public class CompanieController : ControllerBase
    {
        private ProiectContext _proiectContext;

        public CompanieController(ProiectContext proiectConext)
        {
            _proiectContext = proiectConext;
        }

        [HttpPost("Adauga o noua companie")]
        public async Task<IActionResult> Create(CompanieDTO companieDTO)
        {
            var newCompanie = new Companie();
            newCompanie.CompanieId = Guid.NewGuid();
            newCompanie.Nume_companie = companieDTO.Nume_companie;
            newCompanie.Descriere_companie = companieDTO.Descriere_companie;
            newCompanie.SediuId = companieDTO.SediuId;

            var sediu = await _proiectContext.Sedii.FirstOrDefaultAsync(s => s.SediuId == companieDTO.SediuId);
            if (sediu == null)
            {
                var newSediu = new Sediu();
                newSediu.SediuId = Guid.NewGuid();
                newSediu.Oras = companieDTO.Oras;
                newSediu.Adresa = companieDTO.Adresa;

                newCompanie.Sediu = newSediu;
                await _proiectContext.AddAsync(newSediu);
            }
            else
            {
                newCompanie.Sediu = sediu;
            }

            await _proiectContext.AddAsync(newCompanie);
            await _proiectContext.SaveChangesAsync();
            return Ok(newCompanie);
        }

        [HttpGet("Afiseaza toate companiile")]

        public async Task<IActionResult> GetCompanii()
        {
            return Ok(await _proiectContext.Companii.ToListAsync());
        }

        [HttpDelete("Sterge o companie")]
        public async Task<IActionResult> Delete(Guid companieId)
        {
            var companie = await _proiectContext.Companii
                .Include(c => c.Sediu)
                .FirstOrDefaultAsync(c => c.CompanieId == companieId);

            if (companie == null)
            {
                return BadRequest("Compania specificata nu exista.");
            }

            _proiectContext.Remove(companie.Sediu);
            _proiectContext.Remove(companie);
            await _proiectContext.SaveChangesAsync();
            return NoContent();
        }


    }
}
