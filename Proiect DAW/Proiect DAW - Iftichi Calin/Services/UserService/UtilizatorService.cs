using AutoMapper;
using Proiect_DAW___Iftichi_Calin.Helpers.JwtToken;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;
using Proiect_DAW___Iftichi_Calin.Models.Enums;
using Proiect_DAW___Iftichi_Calin.Repositories.UtilizatorRepository;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Proiect_DAW___Iftichi_Calin.Services.UserService
{
    public class UtilizatorService : IUtilizatorService
    {
        public IUtilizatorRepository _utilizatorRepository;
        public IJwtUtils _jwtUtils;
        public IMapper _mapper;
    
        public UtilizatorService(IUtilizatorRepository utilizatorRepository, IJwtUtils jwtUtils)
        {
            _utilizatorRepository = utilizatorRepository;
            _jwtUtils = jwtUtils;
        }

        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = _utilizatorRepository.FindByUsername(model.Username);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }

            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, jwtToken);

        }

       public async Task Create(UserRequestDTO newUser)
        {
            var newDBUtilizator = _mapper.Map<Utilizator>(newUser);
            newDBUtilizator.PasswordHash = BCryptNet.HashPassword(newUser.Password);
            newDBUtilizator.Rol = Rol.User;

            await _utilizatorRepository.CreateAsync(newDBUtilizator);
            await _utilizatorRepository.SaveAsync();
        }

        public UserRequestDTO UserGetById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
