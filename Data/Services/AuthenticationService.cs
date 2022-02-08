using Data.Entities;
using System.Linq;

namespace Data.Services
{
    public class AuthenticationService
    {
        public User LoggedUser { get; private set; }
        public void AuthenticateUser(string username, string password)
        {
            OvmDbContext context = new OvmDbContext();
            this.LoggedUser = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
