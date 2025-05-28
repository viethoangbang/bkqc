using bkqc.DTO;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DAL
{
    public class NhanVienDAL
    {
        private string connectionString = @"Data Source= DATA/bkqc.db;Version=3;";

        public List<NhanVienDTO> GetAll()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaNhanVien, TenNhanVien, TenDangNhap, MatKhau FROM NhanVien";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVienDTO nv = new NhanVienDTO()
                        {
                            MaNhanVien = reader.GetInt32(0),
                            TenNhanVien = reader.GetString(1),
                            TenDangNhap = reader.GetString(2),
                            MatKhau = reader.GetString(3)
                        };
                        list.Add(nv);
                    }
                }
            }
            return list;
        }

        public NhanVienDTO GetById(int id)
        {
            NhanVienDTO nv = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaNhanVien, TenNhanVien, TenDangNhap, MatKhau FROM NhanVien WHERE MaNhanVien=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nv = new NhanVienDTO()
                        {
                            MaNhanVien = reader.GetInt32(0),
                            TenNhanVien = reader.GetString(1),
                            TenDangNhap = reader.GetString(2),
                            MatKhau = reader.GetString(3)
                        };
                    }
                }
            }
            return nv;
        }

        public bool Insert(NhanVienDTO nv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO NhanVien (TenNhanVien, TenDangNhap, MatKhau) VALUES (@ten, @tdn, @mk)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@ten", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("@tdn", nv.TenDangNhap);
                cmd.Parameters.AddWithValue("@mk", nv.MatKhau);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE NhanVien SET TenNhanVien=@ten, TenDangNhap=@tdn, MatKhau=@mk WHERE MaNhanVien=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@ten", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("@tdn", nv.TenDangNhap);
                cmd.Parameters.AddWithValue("@mk", nv.MatKhau);
                cmd.Parameters.AddWithValue("@id", nv.MaNhanVien);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM NhanVien WHERE MaNhanVien=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
