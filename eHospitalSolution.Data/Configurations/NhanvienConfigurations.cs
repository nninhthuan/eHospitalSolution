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
    public class NhanvienConfigurations : IEntityTypeConfiguration<Nhanvien>
    {
        public void Configure(EntityTypeBuilder<Nhanvien> builder)
        {
            builder.ToTable("NhanVien");

            builder.HasKey(x => x.MaNhanvien);

        }
    }
}
