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
    public class BenhnhanConfigurations : IEntityTypeConfiguration<Benhnhan>
    {
        public void Configure(EntityTypeBuilder<Benhnhan> builder)
        {
            builder.ToTable("BenhNhan");

            builder.HasKey(x => x.MaBenhnhan);



        }
    }
}
