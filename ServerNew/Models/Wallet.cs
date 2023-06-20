using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("Wallet")]
    public partial class Wallet
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_User")]
        public int? IdUser { get; set; }
        public double? WalletAmount { get; set; }

        [ForeignKey("IdUser")]
        [InverseProperty("Wallets")]
        public virtual User? IdUserNavigation { get; set; }
    }
}
