namespace Proiect_DAW___Iftichi_Calin.Models.DTOs
{
    public class UserResponseDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Token { get; set; }

        public UserResponseDTO(Utilizator user, string token)
        {
            Id= user.UtilizatorId;
            Username= user.Username;
            Email= user.Email;
            Nume= user.Nume;
            Prenume= user.Prenume;
            Token= token;
        }
    }
}
