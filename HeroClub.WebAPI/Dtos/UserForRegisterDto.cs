using System.ComponentModel.DataAnnotations;

namespace HeroClub.WebAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify between 4 and 8 characters")]
        public string Password { get; set; }
    }
}