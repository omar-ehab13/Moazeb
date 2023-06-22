using Moazeb.DAL.Constants.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class StudyingPeriod
    {
        [Key]
        public string PeriodId { get; set; } = null!;

        [Required]
        public PeriodNumbers PeriodNo { get; set; }

        public DayOfWeek DayName { get; set; }

        public string? SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public virtual Subject? Subject { get; set; }
    }
}
