using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Donthuoc
    {
        public int MaDonThuoc { get; set; }
        public string Soluong { get; set; }
        public string Dongia { get; set; }
        public string TongTien { get; set; }
        public string LieuDung { get; set; }


        public int MaThuoc { get; set; }
        public List<Thuoc> Thuoc { get; set; }
    }
}
