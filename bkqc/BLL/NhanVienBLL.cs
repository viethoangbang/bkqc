using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dal = new NhanVienDAL();
        public NhanVienDTO DangNhap(string tenDangNhap, string matKhau)
        {
            return dal.DangNhap(tenDangNhap, matKhau);
        }

        public List<NhanVienDTO> GetAll()
        {
            return dal.GetAll();
        }

        public NhanVienDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNhanVien) || string.IsNullOrWhiteSpace(nv.TenDangNhap) || string.IsNullOrWhiteSpace(nv.MatKhau))
                return false;

            return dal.Insert(nv);
        }

        public bool Update(NhanVienDTO nv)
        {
            if (nv.MaNhanVien <= 0 || string.IsNullOrWhiteSpace(nv.TenNhanVien) || string.IsNullOrWhiteSpace(nv.TenDangNhap) || string.IsNullOrWhiteSpace(nv.MatKhau))
                return false;

            return dal.Update(nv);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
    }
}
