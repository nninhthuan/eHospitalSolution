using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Bacsy
    {
        public int MaBacsy { get; set; }
        public string HoTen { get; set; }
        public string ChuyenKhoa{ get; set; }
        public string AnhDaiDien { get; set; }

        public int MaTaikhoan { get; set; }
        public Taikhoan TaiKhoan { get; set; }


        public int MaLichLam { get; set; }
        public Lichlamviec LichLamViec { get; set; }


        public int MaPhieukham { get; set; }
        public List<Phieukhambenh> PhieuKhamBenh { get; set; }    

    }
}
