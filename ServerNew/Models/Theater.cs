using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("Theater")]
    public partial class Theater
    {
        public Theater()
        {
            TheaterShows = new HashSet<TheaterShow>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Location { get; set; } = null!;
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public int Contact { get; set; }
        [StringLength(50)]
        public string Address { get; set; } = null!;

        [InverseProperty("IdTheaterNavigation")]
        public virtual ICollection<TheaterShow> TheaterShows { get; set; }
    }
}
