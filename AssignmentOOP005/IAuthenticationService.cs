using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP005
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);

        bool AuthorizeUser(string username, string role);
    }

    class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, (string Password, string Role)> users = new()
        {
    
               { "admin", ("1234", "Admin") },


               { "user", ("abcd", "User") } 
        };

        public bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username].Password == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return users.ContainsKey(username) && users[username].Role == role;
        }
    }

    
}
