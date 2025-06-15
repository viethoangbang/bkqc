using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class LoaiKhanBLL
    {
        private LoaiKhanDAL dal = new LoaiKhanDAL();

        public List<LoaiKhanDTO> GetAll()
        {
            return dal.GetAll();
        }

        public LoaiKhanDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(LoaiKhanDTO loai)
        {
            if (string.IsNullOrWhiteSpace(loai.TenLoai))
                return false;

            return dal.Insert(loai);
        }

        public bool Update(LoaiKhanDTO loai)
        {
            if (loai.MaLoaiKhan <= 0 || string.IsNullOrWhiteSpace(loai.TenLoai))
                return false;

            return dal.Update(loai);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
    }

}
