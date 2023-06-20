using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("Reference")]
    public partial class Reference
    {
        public Reference()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Reference")]
        public int? Reference1 { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }

        [InverseProperty("IdReferenceNavigation")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
