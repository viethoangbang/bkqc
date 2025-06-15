using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class ChiTietHoaDonBLL
    {
        private ChiTietHoaDonDAL dal = new ChiTietHoaDonDAL();

        public List<ChiTietHoaDonDTO> GetAll()
        {
            return dal.GetAll();
        }

        public ChiTietHoaDonDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(ChiTietHoaDonDTO ct)
        {
            if (ct.MaHoaDon <= 0 || ct.MaKhan <= 0 || ct.SoLuong <= 0 || ct.DonGia <= 0)
                return false;

            return dal.Insert(ct);
        }

        public bool Update(ChiTietHoaDonDTO ct)
        {
            if (ct.MaChiTiet <= 0 || ct.MaHoaDon <= 0 || ct.MaKhan <= 0 || ct.SoLuong <= 0 || ct.DonGia <= 0)
                return false;

            return dal.Update(ct);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
    }
}
