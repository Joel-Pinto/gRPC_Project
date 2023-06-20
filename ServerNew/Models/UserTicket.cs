using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("User_Ticket")]
    public partial class UserTicket
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_User")]
        public int? IdUser { get; set; }
        [Column("ID_Session")]
        public int? IdSession { get; set; }
        [Column("ID_Ticket")]
        public int? IdTicket { get; set; }

        [ForeignKey("IdSession")]
        [InverseProperty("UserTickets")]
        public virtual Session? IdSessionNavigation { get; set; }
        [ForeignKey("IdTicket")]
        [InverseProperty("UserTickets")]
        public virtual Ticket? IdTicketNavigation { get; set; }
        [ForeignKey("IdUser")]
        [InverseProperty("UserTickets")]
        public virtual User? IdUserNavigation { get; set; }
    }
}
