using API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;



namespace API.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<tbNhanVien> NhanViens { get; set; }

        public DbSet<tbPhim> Phims { get; set; }

        public DbSet<tbKhachHang> KhachHangs { get; set; }
        public DbSet<tbQuanLi> QuanLis { get; set; }
        public DbSet<tbTheLoaiPhim> TheLoaiPhims { get; set; }
        public DbSet<tbBinhLuan> BinhLuans { get; set; }
        public DbSet<tbPhongChieu> PhongChieus { get; set; }
        public DbSet<tbCaChieu> CaChieus { get; set; }
        public DbSet<tbSuatChieu> SuatChieus { get; set; }
        public DbSet<tbGhe> Ghes { get; set; }
        public DbSet<tbVe> Ves { get; set; }
        public DbSet<tbBookVe> BookVes { get; set; }
        public DbSet<tbBookGhe> BookGhes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Định nghĩa index
            modelBuilder.Entity<tbNhanVien>()
                .HasIndex(nv => new { nv.TenTK, nv.MatKhau })
                .IsUnique()
                .HasDatabaseName("U_nv_user");

            modelBuilder.Entity<tbNhanVien>()
                .HasIndex(nv => nv.Sdt)
                .IsUnique()
                .HasDatabaseName("U_nv_sdt");

            modelBuilder.Entity<tbNhanVien>()
                .HasIndex(nv => nv.Cccd)
                .IsUnique()
                .HasDatabaseName("U_nv_cccd");
        }
    }
}

