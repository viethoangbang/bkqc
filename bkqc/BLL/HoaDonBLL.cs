using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public List<HoaDonDTO> GetAll()
        {
            return dal.GetAll();
        }

        public HoaDonDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(HoaDonDTO hd)
        {
            if (hd.MaKhachHang <= 0 || hd.MaNhanVien <= 0 || hd.NgayLap == null || hd.TongTien < 0)
                return false;

            return dal.Insert(hd);
        }

        public bool Update(HoaDonDTO hd)
        {
            if (hd.MaHoaDon <= 0 || hd.MaKhachHang <= 0 || hd.MaNhanVien <= 0 || hd.NgayLap == null || hd.TongTien < 0)
                return false;

            return dal.Update(hd);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
    }
}
