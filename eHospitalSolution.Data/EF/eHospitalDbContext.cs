using eHospitalSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.EF
{
    public class eHospitalDbContext : DbContext
    {
        public eHospitalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bacsy> BacSy { get; set; }

        public DbSet<Benhnhan> BenhNhan { get; set; }

        public DbSet<Donthuoc> DonThuoc { get; set; }

        public DbSet<Duocsi> DuocSi { get; set; }

        public DbSet<Hoadon> HoaDon { get; set; }

        public DbSet<Hosoyte> HoSoYTe { get; set; }

        public DbSet<Lichlamviec> LichLamViec { get; set; }

        public DbSet<Nhanvien> NhanVien { get; set; }

        public DbSet<Phieukhambenh> PhieuKhamBenh { get; set; }

        public DbSet<Taikhoan> TaiKhoan { get; set; }

        public DbSet<Thebaohiem> TheBaoHiem { get; set; }

        public DbSet<Thungan> ThuNgan { get; set; }

        public DbSet<Thuoc> Thuoc { get; set; }
    }
}
