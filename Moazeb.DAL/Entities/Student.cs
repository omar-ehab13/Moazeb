using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; } = null!;

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = null!;

        public string? Gender { get; set; }

        public int? Age { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? ImageUrl { get; set; }

        public Guid? TagId { get; set; }

        public virtual ICollection<AttendanceState>? AttendanceStates { get; set; }

        #region Relation with parent
        [Required]
        public string ParentId { get; set; } = null!;

        [ForeignKey("ParentId")]
        public virtual Parent? Parent { get; set; }
        #endregion

        #region Relation with class
        public string? ClassName { get; set; }

        [ForeignKey("ClassCode")]
        public virtual Class? Class { get; set; }
        #endregion
    }
}
