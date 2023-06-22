using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moazeb.DAL.Constants.Enums;

namespace Moazeb.DAL.Entities
{
    public class Subject
    {
        public string Id { get; set; } = null!;

        public string SubjectCode { get; set; } = null!;

        [Required]
        public SubjectTypes SubjcetName { get; set; }

        public string? ClassName { get; set; }

        [ForeignKey("ClassName")]
        public virtual Class? Class { get; set; }

        [AllowNull]
        public string? TeacherId { get; set; }

        [AllowNull]
        public virtual Teacher? Teacher { get; set; }

        public virtual List<StudyingPeriod>? Periods { get; set; }
    }
}
