using Elysium.Extensibility.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Extensibility
{
    public interface IUserRepository
    {
        void AddUser(IUser user);

        void UpdateUser(IUser user);

        void DeleteUser(int userId);

        IEnumerable<IUser> GetUsers();
    }
}
