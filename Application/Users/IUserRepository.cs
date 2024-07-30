using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Users
{
    public interface IUserRepository
    {
        Task<bool> AnyEmail(string email);

        Task<bool> AnyUserName(string userName);

        Task<string> Create(User user);
    }
}