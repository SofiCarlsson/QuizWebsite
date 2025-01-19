


using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.X509Certificates;

namespace Quiz.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string userName { get; set; }

    }
}
