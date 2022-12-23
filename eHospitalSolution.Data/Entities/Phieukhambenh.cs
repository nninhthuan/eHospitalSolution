using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Phieukhambenh
    {
        public int MaPhieukham { get; set; }
        public string TenBenhNhan { get; set; }
        public DateTime NgayKham { get; set; }
        public string TenBenh { get; set; }
        public string LoaiThuoc { get; set; }
        public string ChiPhiKham { get; set; }


        public int MaBacsy { get; set; }
        public Bacsy BacSy { get; set; }

        public int MaBenhnhan { get; set; }
        public Benhnhan BenhNhan { get; set; }

    }
}
