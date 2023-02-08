using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Proiect_DAW___Iftichi_Calin.Helpers.JwtToken;
using Proiect_DAW___Iftichi_Calin.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Proiect_DAW___Iftichi_Calin.Helpers.JwtUtils
{
    public class JwtUtils : IJwtUtils
    {
        public readonly AppSettings _appSettings;

        public JwtUtils(IOptions<AppSettings> appSettings)  
        {
            _appSettings = appSettings.Value;
        }
        public string GenerateJwtToken(Utilizator utilizator)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var appPrivateKey = Encoding.ASCII.GetBytes(_appSettings.JwtToken);

            var tokenDesciptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new[] { new Claim("id", utilizator.UtilizatorId.ToString()) }
                    ),
                Expires = DateTime.UtcNow.AddDays(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(appPrivateKey), SecurityAlgorithms.Aes256KW)
            };

            var token = tokenHandler.CreateToken(tokenDesciptor);
           
            return tokenHandler.WriteToken(token);
        }

        public Guid ValidateJwtToken(string token)
        {
            if(token == null)
            {
                return Guid.Empty;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var appPrivateKey = Encoding.ASCII.GetBytes(_appSettings.JwtToken);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(appPrivateKey),
                ValidateIssuer = true,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            try
            {
                tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);
                var JwtToken = (JwtSecurityToken)validatedToken;
                var userId = new Guid(JwtToken.Claims.FirstOrDefault(x => x.Type == "id").Value);
                return userId;  
            }

            catch ( Exception ) 
            {
                return Guid.Empty;
            }
        }
    }
}
