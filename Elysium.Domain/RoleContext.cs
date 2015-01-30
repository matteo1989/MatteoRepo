using Elysium.Domain.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Domain
{
    public class RoleContext : DbContext, IDisposable
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

    }
}
