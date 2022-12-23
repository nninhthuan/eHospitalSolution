using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Benhnhan
    {
        public int MaBenhnhan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChiNha { get; set; }
        public string SoDienThoai { get; set; }
        public string NguoiThan { get; set; }


        public int MaTaikhoan { get; set; }
        public Taikhoan TaiKhoan { get; set; }

        public int MaHoso { get; set; }
        public Hosoyte HoSoYTe { get; set; }

        public int MaPhieukham { get; set; }
        public Phieukhambenh PhieuKhamBenh { get; set; }

        public int MaBH { get; set; }
        public Thebaohiem TheBaoHiem { get; set; }

    }
}
