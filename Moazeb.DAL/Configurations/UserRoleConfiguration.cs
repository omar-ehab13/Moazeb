using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moazeb.DAL.Constants.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                UserId = DefaultAuth.DefualtSuperAdminId,
                RoleId = DefaultAuth.DefaultSuperAdminRoleId,
            });
        }
    }
}
