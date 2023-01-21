using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Data;

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

        [HttpGet]

        public async Task<IActionResult> GetUtilizatori()
        {
            return Ok(await _proiectContext.Utilizatori.ToListAsync());
        }
    }
}
