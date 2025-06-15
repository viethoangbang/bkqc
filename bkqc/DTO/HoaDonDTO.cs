using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DTO
{
    public class HoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public double TongTien { get; set; }
    }
}
