using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Extensibility.Dtos.User
{
    public interface IUser
    {
       int Id { get; set; }

       string UserName { get; set; }

       string FirstName { get; set; }

       string LastName { get; set; }
    }
}
