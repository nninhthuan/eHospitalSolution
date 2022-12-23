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
    public class ThebaohiemConfigurations : IEntityTypeConfiguration<Thebaohiem>
    {
        public void Configure(EntityTypeBuilder<Thebaohiem> builder)
        {
            builder.ToTable("TheBaoHiem");

            builder.HasKey(x => x.MaBH);


        }
    }
}
