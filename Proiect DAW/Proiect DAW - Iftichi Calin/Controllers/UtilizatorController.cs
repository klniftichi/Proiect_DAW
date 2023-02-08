using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Helpers.Atributes;
using Proiect_DAW___Iftichi_Calin.Models.Enums;

namespace Proiect_DAW___Iftichi_Calin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizatorController : ControllerBase
    {
        private ProiectContext _proiectContext;

        public UtilizatorController(ProiectContext proiectContext)
        {
            _proiectContext = proiectContext;
        }

        //[Authorization(Rol.Admin)]
        [HttpGet("Lista utilizatorilor")]

        public async Task<IActionResult> GetUtilizatori()
        {
            return Ok(await _proiectContext.Utilizatori.ToListAsync());
        }
    }
}
