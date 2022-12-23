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
    public class HoadonConfigurations : IEntityTypeConfiguration<Hoadon>
    {
        public void Configure(EntityTypeBuilder<Hoadon> builder)
        {
            builder.ToTable("HoaDon");

            builder.HasKey(x => x.MaHoadon);

            builder.HasOne(x => x.ThuNgan).WithMany(x => x.HoaDon).HasForeignKey(x => x.MaThungan);
        }
    }
}
