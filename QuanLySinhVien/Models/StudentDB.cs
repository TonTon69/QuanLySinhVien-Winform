using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien.Models
{
    public partial class StudentDB : DbContext
    {
        public StudentDB()
            : base("name=StudentDB")
        {
        }

        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KetQua>()
                .Property(e => e.MaMH)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .Property(e => e.MaMH)
                .IsUnicode(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.KetQuas)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.KetQuas)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);
        }
    }
}
