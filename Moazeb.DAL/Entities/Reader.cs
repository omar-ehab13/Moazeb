using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class Reader
    {
        [Key]
        public string ReaderId { get; set; } = null!;

        public DateTime AddedDay { get; set; } = DateTime.Now;

        public string? Model { get; set; }

        public string? ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public virtual Class? Class { get; set; }
    }
}
