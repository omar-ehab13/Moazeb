using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moazeb.DAL.Constants.Enums;

namespace Moazeb.DAL.Entities
{
    public class AttendanceState
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Range(2020, 2030)]
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public string? DayName { get; set; }

        [Required]
        public AttendanceStateTypes State { get; set; } = AttendanceStateTypes.ABSENT;

        public string StudentId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(StudentId))]
        public virtual Student Student { get; set; } = null!;

        public virtual ICollection<Log>? Logs { get; set; }
    }
}
