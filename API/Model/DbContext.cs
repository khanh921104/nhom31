using API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace API.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<tbNhanVien> NhanViens { get; set; }

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

