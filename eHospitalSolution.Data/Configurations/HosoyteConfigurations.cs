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
    public class HosoyteConfigurations : IEntityTypeConfiguration<Hosoyte>
    {
        public void Configure(EntityTypeBuilder<Hosoyte> builder)
        {
            builder.ToTable("HoSoYTe");

            builder.HasKey(x => x.MaHoso);

            builder.Property(x => x.CanNang).IsRequired().HasDefaultValue("kg");
            builder.Property(x => x.ChieuCao).IsRequired().HasDefaultValue("cm");
        }
    }
}
