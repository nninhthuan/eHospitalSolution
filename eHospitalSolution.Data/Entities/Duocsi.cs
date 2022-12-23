using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Duocsi
    {
        public int MaDuocSi { get; set; }
        public string HoTen { get; set; }
        public string KinhNghiem { get; set; }
        public string BangCap { get; set; }


        public int MaThuoc { get; set; }
        public List<Thuoc> Thuoc { get; set; }

        public int MaTaikhoan { get; set; }
        public Taikhoan TaiKhoan { get; set; }
    }
}
