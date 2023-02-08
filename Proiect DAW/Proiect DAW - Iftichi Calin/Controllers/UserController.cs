using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_DAW___Iftichi_Calin.Helpers.Atributes;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;
using Proiect_DAW___Iftichi_Calin.Models.Enums;
using Proiect_DAW___Iftichi_Calin.Services.UserService;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Proiect_DAW___Iftichi_Calin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUtilizatorService _utilizatorService;

        public UserController(IUtilizatorService utilizatorService)
        {
            _utilizatorService = utilizatorService;
        }
        /* [Authorization(Rol.Admin)]
        [HttpPost("Creeaza utilizator")]
        public async Task<IActionResult> CreateUser(UserRequestDTO user)
        {
            var userToCreate = new Utilizator
            {
                Username = user.Username,
                PasswordHash = BCryptNet.HashPassword(user.Password),
                Email = user.Email,
                Nume = user.Nume,
                Prenume = user.Prenume,
                Rol = user.Rol,
            };


            await _utilizatorService.Create(userToCreate);
            return Ok();
        }*/
    }
}
