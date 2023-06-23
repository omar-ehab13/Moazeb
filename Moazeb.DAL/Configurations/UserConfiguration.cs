using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moazeb.DAL.Constants.Static;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(
                new ApplicationUser
                {
                    Id = DefaultAuth.DefualtSuperAdminId,
                    UserName = DefaultAuth.DefaultSuperAdmin,
                    NormalizedUserName = DefaultAuth.DefaultSuperAdmin.ToUpper(),
                    Email = DefaultAuth.DefaultSuperAdmin,
                    NormalizedEmail = DefaultAuth.DefaultSuperAdmin.ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false, // Set PhoneNumberConfirmed to false
                    TwoFactorEnabled = false, // Set TwoFactorEnabled to false
                    AccessFailedCount = 0,
                    LockoutEnabled = true,
                    PasswordHash = DefaultAuth.DefaultPasswordHash,
                    SecurityStamp = DefaultAuth.DefaultSecurityStamp,
                    ConcurrencyStamp = DefaultAuth.DefaultConcurrencyStamp,
                    FullName = DefaultAuth.DefaultSuperAdmin,
                }    
            );
        }
    }
}
