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
    public class DuocsiConfigurations : IEntityTypeConfiguration<Duocsi>
    {
        public void Configure(EntityTypeBuilder<Duocsi> builder)
        {
            builder.ToTable("Duocsi");

            builder.HasKey(x => x.MaDuocSi);
        }
    }
}
