using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServerNew.Models
{
    [Table("Theater_Show")]
    public partial class TheaterShow
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_theater")]
        public int? IdTheater { get; set; }
        [Column("ID_show")]
        public int? IdShow { get; set; }

        [ForeignKey("IdShow")]
        [InverseProperty("TheaterShows")]
        public virtual Show? IdShowNavigation { get; set; }
        [ForeignKey("IdTheater")]
        [InverseProperty("TheaterShows")]
        public virtual Theater? IdTheaterNavigation { get; set; }
    }
}
