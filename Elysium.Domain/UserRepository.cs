using Elysium.Domain.Database;
using Elysium.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtoUser = Elysium.Extensibility.Dtos.User.IUser;
using Elysium.Domain.Converters;
namespace Elysium.Domain
{
    public class UserRepository : IUserRepository
    {
        private RoleContext roleContext;

        public UserRepository(RoleContext roleContext)
        {
            this.roleContext = roleContext;
        }

        public void AddUser(DtoUser user)
        {
            var dbUser = user.ToDbUser();
            roleContext.Users.Add(dbUser);
            roleContext.SaveChanges();
        }

        public void UpdateUser(DtoUser user)
        {
            var dbUser = roleContext.Users.Find(user.Id);
            dbUser.UserName = user.UserName;
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;

            roleContext.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var userToDelete = roleContext.Users.Find(userId);
            roleContext.Users.Remove(userToDelete);
            roleContext.SaveChanges();
        }

        public IEnumerable<DtoUser> GetUsers()
        {
            return roleContext.Users.ToList().Select(s => s.ToDtoUser());
        }
    }
}
