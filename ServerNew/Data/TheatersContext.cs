using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ServerNew.Models;

namespace ServerNew.Data
{
    public partial class TheatersContext : DbContext
    {
        public TheatersContext()
        {
        }

        public TheatersContext(DbContextOptions<TheatersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reference> References { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Show> Shows { get; set; } = null!;
        public virtual DbSet<Theater> Theaters { get; set; } = null!;
        public virtual DbSet<TheaterShow> TheaterShows { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserTicket> UserTickets { get; set; } = null!;
        public virtual DbSet<Wallet> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=TheatersContext");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasOne(d => d.IdShowNavigation)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.IdShow)
                    .HasConstraintName("FK___Session__ID_sho__33D4B598");
            });

            modelBuilder.Entity<TheaterShow>(entity =>
            {
                entity.HasOne(d => d.IdShowNavigation)
                    .WithMany(p => p.TheaterShows)
                    .HasForeignKey(d => d.IdShow)
                    .HasConstraintName("FK__Theater_S__ID_sh__30F848ED");

                entity.HasOne(d => d.IdTheaterNavigation)
                    .WithMany(p => p.TheaterShows)
                    .HasForeignKey(d => d.IdTheater)
                    .HasConstraintName("FK__Theater_S__ID_th__300424B4");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdReference)
                    .HasConstraintName("FK__Ticket__ID_Refer__398D8EEE");

                entity.HasOne(d => d.IdSessionNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdSession)
                    .HasConstraintName("FK__Ticket__ID_Sessi__38996AB5");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK___User__ID_Role__286302EC");
            });

            modelBuilder.Entity<UserTicket>(entity =>
            {
                entity.HasOne(d => d.IdSessionNavigation)
                    .WithMany(p => p.UserTickets)
                    .HasForeignKey(d => d.IdSession)
                    .HasConstraintName("FK__User_Tick__ID_Se__4222D4EF");

                entity.HasOne(d => d.IdTicketNavigation)
                    .WithMany(p => p.UserTickets)
                    .HasForeignKey(d => d.IdTicket)
                    .HasConstraintName("FK__User_Tick__ID_Ti__4316F928");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserTickets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__User_Tick__ID_Us__412EB0B6");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Wallet__ID_User__46E78A0C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
