using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Thuoc
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string SoLuong { get; set; }
        public string Gia { get; set; }

        public Duocsi DuocSi { get; set; }

        public Donthuoc DonThuoc { get; set; }
        public Thungan ThuNgan { get; set; }

    }
}
