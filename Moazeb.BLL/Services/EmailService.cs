using Moazeb.BLL.IService;
using Moazeb.DAL.Constants.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.BLL.Services
{
    public class EmailService : IEmailService
    {
        public Task<string> GenerateRandomEmailAsync(string name, string role, bool exist = false)
        {
            StringBuilder builder = new();
            var splitedName = name.Split(" ");
            var emialExtension = GetEmailExtension(role);

            builder.Append(splitedName[0]);

            // add second name if exist
            if (splitedName.Length > 1)
                builder.Append(splitedName[1]);

            // add random number if email with name only is exist in DB
            if (exist)
                builder.Append(new Random().Next(1000));


            builder.Append(emialExtension);

            return Task.FromResult(builder.ToString());
        }

        private string? GetEmailExtension(string role)
        {
            string superAdmin = RoleTypes.SuperAdmin.ToString();
            string admin = RoleTypes.Admin.ToString();
            string parent = RoleTypes.Parent.ToString();
            string teacher = RoleTypes.Teacher.ToString();

            var emailExtension =  role switch
            {
                nameof(RoleTypes.SuperAdmin) => "@superadmin.moazeb",
                nameof(RoleTypes.Admin) => "@admin.moazeb",
                nameof(RoleTypes.Parent) => "@parent.moazeb",
                nameof(RoleTypes.Teacher) => "@teacher.moazeb",
                _ => null
            };

            return emailExtension;
        }
    }
}
