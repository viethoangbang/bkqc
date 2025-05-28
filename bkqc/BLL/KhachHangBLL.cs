using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHangDTO> GetAll()
        {
            return dal.GetAll();
        }

        public KhachHangDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKhachHang))
                return false;

            return dal.Insert(kh);
        }

        public bool Update(KhachHangDTO kh)
        {
            if (kh.MaKhachHang <= 0 || string.IsNullOrWhiteSpace(kh.TenKhachHang))
                return false;

            return dal.Update(kh);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
    }
}
