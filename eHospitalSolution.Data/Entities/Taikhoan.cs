using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Taikhoan
    {
        public int MaTaikhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public Bacsy BacSy { get; set; }

        public Duocsi DuocSi { get; set; }

        public Thungan ThuNgan { get; set; }

        public Benhnhan BenhNhan { get; set; }

    }
}
