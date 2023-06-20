using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("_User")]
    public partial class User
    {
        public User()
        {
            UserTickets = new HashSet<UserTicket>();
            Wallets = new HashSet<Wallet>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_Role")]
        public int? IdRole { get; set; }
        [Column("ID_Wallet")]
        public int? IdWallet { get; set; }
        [StringLength(150)]
        public string Name { get; set; } = null!;
        [StringLength(20)]
        public string UserName { get; set; } = null!;
        [StringLength(50)]
        public string Location { get; set; } = null!;
        public int Age { get; set; }

        [ForeignKey("IdRole")]
        [InverseProperty("Users")]
        public virtual Role? IdRoleNavigation { get; set; }
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<UserTicket> UserTickets { get; set; }
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
