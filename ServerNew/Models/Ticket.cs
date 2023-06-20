using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("Ticket")]
    public partial class Ticket
    {
        public Ticket()
        {
            UserTickets = new HashSet<UserTicket>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_Session")]
        public int? IdSession { get; set; }
        [Column("ID_Reference")]
        public int? IdReference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Hour { get; set; }
        public int NumberTickets { get; set; }
        public int IsItPaid { get; set; }

        [ForeignKey("IdReference")]
        [InverseProperty("Tickets")]
        public virtual Reference? IdReferenceNavigation { get; set; }
        [ForeignKey("IdSession")]
        [InverseProperty("Tickets")]
        public virtual Session? IdSessionNavigation { get; set; }
        [InverseProperty("IdTicketNavigation")]
        public virtual ICollection<UserTicket> UserTickets { get; set; }
    }
}
