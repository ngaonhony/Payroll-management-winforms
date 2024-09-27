using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using QLTL.Models;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTL
{
    internal class EFDbContext : DbContext
    {
        public DbSet<NHANVIEN> NHANVIEN { get; set; }
        public DbSet<KHENTHUONGKYLUAT> KHENTHUONGKYLUAT { get; set; }
        public DbSet<CHAMCONG> CHAMCONG { get; set; }
        public DbSet<PHONGBAN> PHONGBAN { get; set; }
        public DbSet<CHUCVU> CHUCVU { get; set; }

        public DbSet<USER> USER { get; set; }


        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USER>().HasData(
                new USER
                {
                    USERNAME = "1",
                    PASSWORD = "1"
                },
                new USER
                {
                    USERNAME = "NHOM1",
                    PASSWORD = "1"
                });
        }
    }

}