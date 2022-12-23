using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHospitalSolution.Data.Entities;

namespace eHospitalSolution.Data.Configurations
{
    public  class BacsyConfigurations : IEntityTypeConfiguration<Bacsy>
    {
         public void Configure(EntityTypeBuilder<Bacsy> builder)
         {
             builder.ToTable("BacSy");
         
             builder.HasKey(x => x.MaBacsy);

            builder.HasOne(x => x.LichLamViec).WithMany(x => x.BacSy).HasForeignKey(x => x.MaLichLam);
         }
        
    }
}
