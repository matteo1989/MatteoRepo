using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Domain
{
    class RoleContext: DbContext
    {
        public int MyProperty { get; set; }
    }
}
