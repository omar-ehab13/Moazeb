using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Entities
{
    public class Parent
    {
        [Key]
        public string ParentId { get; set; } = null!;

        [Required, MaxLength(20)]
        public string Nid { get; set; } = null!;

        [MaxLength(100)]
        public string? Job { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public virtual ICollection<Student>? Students { get; set; }
    }
}
