using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHospitalSolution.Data.Entities
{
    public class Hosoyte
    {
        public int MaHoso { get; set; }
        public string GioiTinh { get; set; }
        public float CanNang { get; set; }
        public string ChieuCao { get; set; }
        public string Nhommau { get; set; }
        public string NhipTim { get; set; }

        public int MaBenhnhan { get; set; }
        public Benhnhan BenhNhan { get; set; }

        public int MaBH { get; set; }
        public Thebaohiem TheBaoHiem { get; set; }

    }
}
