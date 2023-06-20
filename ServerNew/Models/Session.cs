using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("_Session")]
    public partial class Session
    {
        public Session()
        {
            Tickets = new HashSet<Ticket>();
            UserTickets = new HashSet<UserTicket>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_show")]
        public int? IdShow { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [StringLength(20)]
        public string StartHour { get; set; } = null!;
        [StringLength(20)]
        public string EndHour { get; set; } = null!;
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }

        [ForeignKey("IdShow")]
        [InverseProperty("Sessions")]
        public virtual Show? IdShowNavigation { get; set; }
        [InverseProperty("IdSessionNavigation")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        [InverseProperty("IdSessionNavigation")]
        public virtual ICollection<UserTicket> UserTickets { get; set; }
    }
}
