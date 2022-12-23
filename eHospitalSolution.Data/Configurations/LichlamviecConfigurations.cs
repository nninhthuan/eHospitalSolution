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
    public class LichlamviecConfigurations : IEntityTypeConfiguration<Lichlamviec>
    {
        public void Configure(EntityTypeBuilder<Lichlamviec> builder)
        {
            builder.ToTable("LichLamViec");

            builder.HasKey(x => x.MaLichLam);


        }
    }
}
