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
    public class Log
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime LogTime { get; set; } = DateTime.Now;

        public LogActionTypes Action { get; set; } = LogActionTypes.OUT;

        public string AttendanceStateId { get; set; } = null!;

        [ForeignKey("AttendanceStateId ")]
        public virtual AttendanceState AttendanceState { get; set; } = null!;
    }
}
