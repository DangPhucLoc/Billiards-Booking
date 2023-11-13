using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BussinessObject.Models
{
    public partial class BBP_CSharpContext : DbContext
    {
        public BBP_CSharpContext()
        {
        }

        public BBP_CSharpContext(DbContextOptions<BBP_CSharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<BookingDetail> BookingDetails { get; set; } = null!;
        public virtual DbSet<Club> Clubs { get; set; } = null!;
        public virtual DbSet<Price> Prices { get; set; } = null!;
        public virtual DbSet<Slot> Slots { get; set; } = null!;
        public virtual DbSet<Table> Tables { get; set; } = null!;
        public virtual DbSet<TableType> TableTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-38G8KJF;Database=BBP_CSharp;User Id=sa;Password=12345;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingId");

                entity.Property(e => e.BookDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bookDate");

                entity.Property(e => e.BookingStatus).HasColumnName("bookingStatus");

                entity.Property(e => e.ClubId).HasColumnName("clubId");

                entity.Property(e => e.ClubStaffId).HasColumnName("clubStaffId");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.ClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_ClubId");
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.ToTable("BookingDetail");

                entity.Property(e => e.BookingDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingDetailId");

                entity.Property(e => e.BookingId).HasColumnName("bookingId");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.Property(e => e.TableId).HasColumnName("tableId");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookingDetail_BookingId");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.SlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookingDetail_SlotId");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookingDetail_TableId");
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.ToTable("Club");

                entity.Property(e => e.ClubId)
                    .ValueGeneratedNever()
                    .HasColumnName("clubId");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.AvatarLink)
                    .HasMaxLength(255)
                    .HasColumnName("avatarLink");

                entity.Property(e => e.CloseTime).HasColumnName("closeTime");

                entity.Property(e => e.ClubName)
                    .HasMaxLength(255)
                    .HasColumnName("clubName");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FanpageLink)
                    .HasMaxLength(255)
                    .HasColumnName("fanpageLink");

                entity.Property(e => e.OpenTime).HasColumnName("openTime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasKey(e => new { e.TableTypeId, e.SlotId })
                    .HasName("PK__Price__4EB20321E7F47A2F");

                entity.ToTable("Price");

                entity.Property(e => e.TableTypeId).HasColumnName("tableTypeId");

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.Property(e => e.Price1).HasColumnName("price");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.SlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Price_SlotId");

                entity.HasOne(d => d.TableType)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.TableTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Price_TableTypeId");
            });

            modelBuilder.Entity<Slot>(entity =>
            {
                entity.ToTable("Slot");

                entity.Property(e => e.SlotId)
                    .ValueGeneratedNever()
                    .HasColumnName("slotId");

                entity.Property(e => e.EndTime).HasColumnName("endTime");

                entity.Property(e => e.StartTime).HasColumnName("startTime");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Table");

                entity.Property(e => e.TableId)
                    .ValueGeneratedNever()
                    .HasColumnName("tableId");

                entity.Property(e => e.ClubId).HasColumnName("clubId");

                entity.Property(e => e.IsAvailable).HasColumnName("isAvailable");

                entity.Property(e => e.TableTypeId).HasColumnName("tableTypeId");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Tables)
                    .HasForeignKey(d => d.ClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_ClubId");

                entity.HasOne(d => d.TableType)
                    .WithMany(p => p.Tables)
                    .HasForeignKey(d => d.TableTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_TableTypeId");
            });

            modelBuilder.Entity<TableType>(entity =>
            {
                entity.ToTable("TableType");

                entity.Property(e => e.TableTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("tableTypeId");

                entity.Property(e => e.TypeDescription)
                    .HasMaxLength(255)
                    .HasColumnName("typeDescription");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(255)
                    .HasColumnName("typeName");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.AvatarLink)
                    .HasMaxLength(255)
                    .HasColumnName("avatarLink");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Role)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
