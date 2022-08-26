using Microsoft.AspNetCore.Identity;

namespace MySite.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
