using Proiect_DAW___Iftichi_Calin.Models;

namespace Proiect_DAW___Iftichi_Calin.Helpers.JwtToken
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(Utilizator utilizator);
        public Guid ValidateJwtToken(string token);
    }
}
