using eHospitalSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Configurations
{
    public class TaikhoanConfigurations : IEntityTypeConfiguration<Taikhoan>
    {
        public void Configure(EntityTypeBuilder<Taikhoan> builder)
        {
            builder.ToTable("TaiKhoan");

            builder.HasKey(x => x.MaTaikhoan);

            builder.Property(x => x.TenDangNhap).IsRequired();
            builder.Property(x => x.MatKhau).IsRequired();
        }
    }
}
