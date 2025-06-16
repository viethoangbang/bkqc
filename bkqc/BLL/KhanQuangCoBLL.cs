using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class KhanQuangCoBLL
    {
        private KhanQuangCoDAL dal = new KhanQuangCoDAL();

        public List<KhanQuangCoDTO> GetAll()
        {
            return dal.GetAll();
        }

        public KhanQuangCoDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(KhanQuangCoDTO kq)
        {
            if (string.IsNullOrWhiteSpace(kq.TenKhan) || kq.MaLoaiKhan <= 0 || kq.MaNhaCungCap <= 0 || kq.GiaBan <= 0 || kq.SoLuongTon < 0)
                return false;

            return dal.Insert(kq);
        }

        public bool Update(KhanQuangCoDTO kq)
        {
            if (kq.MaKhan <= 0 || string.IsNullOrWhiteSpace(kq.TenKhan) || kq.MaLoaiKhan <= 0 || kq.MaNhaCungCap <= 0 || kq.GiaBan <= 0 || kq.SoLuongTon < 0)
                return false;

            return dal.Update(kq);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
        public bool TruSoLuongTon(int maKhan, int soLuong)
        {
            var khan = dal.GetById(maKhan);
            if (khan == null || khan.SoLuongTon < soLuong)
                return false;

            khan.SoLuongTon -= soLuong;
            return dal.Update(khan);
        }

    }
}
