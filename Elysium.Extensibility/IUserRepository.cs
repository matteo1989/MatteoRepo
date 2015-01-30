using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Extensibility
{
    public interface IUserRepository
    {
        void AddUser();

        void UpdateUser();

        void DeleteUser();
    }
}
