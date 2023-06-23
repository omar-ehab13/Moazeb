using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moazeb.DAL.Constants.Enums;
using Moazeb.DAL.Constants.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = DefaultAuth.DefaultSuperAdminRoleId,
                    Name = RoleTypes.SuperAdmin.ToString(),
                    NormalizedName = RoleTypes.SuperAdmin.ToString().ToUpper(),
                    ConcurrencyStamp = DefaultAuth.DefaultSuperAdminRoleConcurrencyStamp
                },
                new IdentityRole
                {
                    Id = DefaultAuth.DefaultAdminRoleId,
                    Name = RoleTypes.Admin.ToString(),
                    NormalizedName = RoleTypes.Admin.ToString().ToUpper(),
                    ConcurrencyStamp = DefaultAuth.DefaultAdminRoleConcurrencyStamp
                },
                new IdentityRole
                {
                    Id = DefaultAuth.DefaultParentRoleId,
                    Name = RoleTypes.Parent.ToString(),
                    NormalizedName = RoleTypes.Parent.ToString().ToUpper(),
                    ConcurrencyStamp = DefaultAuth.DefaultParentRoleConcurrencyStamp
                },
                new IdentityRole
                {
                    Id = DefaultAuth.DefaultTeacherRoleId,
                    Name = RoleTypes.Teacher.ToString(),
                    NormalizedName = RoleTypes.Teacher.ToString().ToUpper(),
                    ConcurrencyStamp = DefaultAuth.DefaultTeacherConcurrencyStamp
                }
            );
        }
    }
}
