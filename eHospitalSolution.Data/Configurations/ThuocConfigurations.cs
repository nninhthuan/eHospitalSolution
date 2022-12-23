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
    public class ThuocConfigurations : IEntityTypeConfiguration<Thuoc>
    {
        public void Configure(EntityTypeBuilder<Thuoc> builder)
        {
            builder.ToTable("THUOC");

            builder.HasKey(x => x.MaThuoc);

            builder.HasOne(x => x.DuocSi).WithMany(x => x.Thuoc).HasForeignKey(x => x.MaDuocSi);
            builder.HasOne(x => x.DonThuoc).WithMany(x => x.Thuoc).HasForeignKey(x => x.MaDonThuoc);
            builder.HasOne(x => x.ThuNgan).WithMany(x => x.Thuoc).HasForeignKey(x => x.MaThungan);
        }
    }
}
