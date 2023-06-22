using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class Class
    {
        [Required, MaxLength(3)]
        [Key]
        public string ClassName { get; set; } = null!;

        [Required, Range(1, 12)]
        public byte Grade { get; set; }

        public string? ReaderId { get; set; }

        [ForeignKey(nameof(ReaderId))]
        public virtual Reader? Reader { get; set; }

        public virtual ICollection<Student>? Students { get; set; }
        public virtual ICollection<StudyingPeriod>? StudyingPeriods { get; set; }
    }
}
