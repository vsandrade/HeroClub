using System.ComponentModel.DataAnnotations;

namespace HeroClub.WebAPI.Dtos
{
    public class UserForLoginDto
    {
        public string Username { get; set; }        
        public string Password { get; set; }
    }
}