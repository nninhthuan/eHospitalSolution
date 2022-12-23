using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Thungan
    {
        public int MaThungan { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string ViTri { get; set; }

        public int MaThuoc { get; set; }
        public List<Thuoc> Thuoc { get; set; }

        public int MaHoadon { get; set; }
        public List<Hoadon> HoaDon { get; set; }

        public int MaTaikhoan { get; set; }
        public Taikhoan TaiKhoan { get; set; }
    }
}
