using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FullName { get; set; } = null!;

        public string? City { get; set; }

        public string? Governorate { get; set; }

        public string? Address { get; set; }

        public string? ImageUrl { get; set; }

        public string? ExternalEmail { get; set; }
    }
}
