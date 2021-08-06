using eFoodHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodHub.Services.Interfaces
{
    public interface IAuthenticationServices
    {
        bool CreateUser(User user, string Password);
        Task<bool> SignOut();
        User AuthenticateUser(string Username, string Password);
        User GetUser(string Username);
    
    }
}
