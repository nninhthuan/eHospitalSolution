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
    public class ThunganConfigurations : IEntityTypeConfiguration<Thungan>
    {
        public void Configure(EntityTypeBuilder<Thungan> builder)
        {
            builder.ToTable("ThuNgan");

            builder.HasKey(x => x.MaThungan);
        }
    }
}
