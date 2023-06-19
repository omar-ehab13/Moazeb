using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Constants.Static
{
    public static class DefaultAuth
    {
        public static string DefaultPassword = "P@ssw0rd";

        public static string DefaultSuperAdmin = "superadmin@superadmin.moazeb";
        public static string DefualtSuperAdminId = Guid.NewGuid().ToString();
        public static string DefaultSuperAdminRoleId = Guid.NewGuid().ToString();
    }
}
