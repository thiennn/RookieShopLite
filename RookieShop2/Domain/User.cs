using Microsoft.AspNetCore.Identity;

namespace RookieShop2.Domain
{
    public class User : IdentityUser
    {
        public User() : base()
        {
        }

        public User(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }
    }
}
