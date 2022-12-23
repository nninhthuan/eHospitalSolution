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
    public class PhieukhambenhConfigurations : IEntityTypeConfiguration<Phieukhambenh>
    {
        public void Configure(EntityTypeBuilder<Phieukhambenh> builder)
        {
            builder.ToTable("PhieuKhamBenh");

            builder.HasKey(x => x.MaPhieukham);

            builder.HasOne(x => x.BacSy).WithMany(x => x.PhieuKhamBenh).HasForeignKey(x => x.MaBacsy);
        }
    }
}
