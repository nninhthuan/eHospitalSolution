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
    public class DonthuocConfigurations : IEntityTypeConfiguration<Donthuoc>
    {
        public void Configure(EntityTypeBuilder<Donthuoc> builder)
        {
            builder.ToTable("DonThuoc");

            builder.HasKey(x => x.MaDonThuoc);

            builder.Property(x => x.Dongia).HasDefaultValue(0);
        }
    }
}
