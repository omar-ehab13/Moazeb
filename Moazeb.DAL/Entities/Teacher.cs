using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class Teacher
    {
        [Key]
        public string TeacherId { get; set; } = null!;

        public string Specialize { get; set; } = null!; // e,g: Math Teacher

        [ForeignKey(nameof(TeacherId))]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public virtual List<Subject> Subjects { get; set; } = null!;
    }
}
