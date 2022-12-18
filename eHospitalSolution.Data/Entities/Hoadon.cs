using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Hoadon
    {
        public string MaHoadon { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThaiThanhToan { get; set; }
        public DateTime NgayXuat { get; set; }

        public Thungan ThuNgan { get; set; }

    }
}
