using DtoUser = Elysium.Extensibility.Dtos.User.User;
using DbUser = Elysium.Domain.Database.User;
using Elysium.Extensibility.Dtos.User;
namespace Elysium.Domain.Converters
{
    public static class UserConverter
    {
        public static IUser ToDtoUser(this DbUser dbuser)
        {
            if (dbuser == null)
            {
                return null;
            }
            return new DtoUser()
            {
                FirstName = dbuser.FirstName,
                LastName = dbuser.LastName,
                UserName = dbuser.UserName,
                Id = dbuser.Id
            };
        }

        public static DbUser ToDbUser(this IUser dtoUser)
        {
            return new DbUser()
            {
                FirstName = dtoUser.FirstName,
                LastName = dtoUser.LastName,
                UserName = dtoUser.UserName
            };
        }
    }
}
