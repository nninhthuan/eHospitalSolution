using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Lichlamviec
    {
        public int MaLichLam { get; set; }
        public DateTime NgayTruc { get; set; }
        public DateTime CaTruc { get; set; }

        public List<Bacsy> BacSy { get; set; }


    }
}
