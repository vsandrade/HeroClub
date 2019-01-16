using Microsoft.AspNetCore.Identity;

namespace HeroClub.Domain
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}