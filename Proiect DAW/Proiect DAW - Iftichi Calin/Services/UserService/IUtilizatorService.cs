using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;

namespace Proiect_DAW___Iftichi_Calin.Services.UserService
{
    public interface IUtilizatorService
    {
        UserResponseDTO Authenticate(UserRequestDTO model);
        UserRequestDTO UserGetById(Guid Id);
        Task Create(UserRequestDTO newUser);
    }
}

