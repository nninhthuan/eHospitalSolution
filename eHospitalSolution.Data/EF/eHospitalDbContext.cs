using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.EF
{
    internal class eHospitalDbContext : DbContext
    {
        public eHospitalDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
