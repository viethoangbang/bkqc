using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL dal = new NhaCungCapDAL();

        public List<NhaCungCapDTO> GetAll()
        {
            return dal.GetAll();
        }

        public NhaCungCapDTO GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Insert(NhaCungCapDTO ncc)
        {
            if (string.IsNullOrWhiteSpace(ncc.TenNhaCungCap))
                return false;

            return dal.Insert(ncc);
        }

        public bool Update(NhaCungCapDTO ncc)
        {
            if (ncc.MaNhaCungCap <= 0 || string.IsNullOrWhiteSpace(ncc.TenNhaCungCap))
                return false;

            return dal.Update(ncc);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;

            return dal.Delete(id);
        }
    }
}
