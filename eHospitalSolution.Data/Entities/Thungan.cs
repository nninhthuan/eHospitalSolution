using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Thungan
    {
        public string MaThungan { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string ViTri { get; set; }

        public LinkedList<Thuoc> Thuoc { get; set; }
        public LinkedList<Hoadon> HoaDon { get; set; }

        public Taikhoan TaiKhoan { get; set; }
    }
}
