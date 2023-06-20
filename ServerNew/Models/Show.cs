using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("Show")]
    public partial class Show
    {
        public Show()
        {
            Sessions = new HashSet<Session>();
            TheaterShows = new HashSet<TheaterShow>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; } = null!;
        [StringLength(350)]
        public string Synopse { get; set; } = null!;
        [StringLength(20)]
        public string StartDate { get; set; } = null!;
        [StringLength(20)]
        public string EndDate { get; set; } = null!;
        public double Price { get; set; }
        public bool HasSeen { get; set; }

        [InverseProperty("IdShowNavigation")]
        public virtual ICollection<Session> Sessions { get; set; }
        [InverseProperty("IdShowNavigation")]
        public virtual ICollection<TheaterShow> TheaterShows { get; set; }
    }
}
