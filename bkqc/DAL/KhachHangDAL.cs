using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DAL
{
    public class KhachHangDAL
    {
        private string relativePath = @"..\..\..\DATA\bkqc.db";
        private string connectionString;

        public KhachHangDAL()
        {
            string fullPath = Path.GetFullPath(Path.Combine(Application.StartupPath, relativePath));
            connectionString = $@"Data Source={fullPath};Version=3;";
        }


        public List<KhachHangDTO> GetAll()
        {
            var list = new List<KhachHangDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaKhachHang, TenKhachHang, SoDienThoai, NgayDangKy FROM KhachHang";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHangDTO
                        {
                            MaKhachHang = reader.GetInt32(0),
                            TenKhachHang = reader.GetString(1),
                            SoDienThoai = reader.IsDBNull(2) ? null : reader.GetString(2),
                            NgayDangKy = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3)
                        });
                    }
                }
            }
            return list;
        }

        public KhachHangDTO GetById(int id)
        {
            KhachHangDTO kh = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaKhachHang, TenKhachHang, SoDienThoai, NgayDangKy FROM KhachHang WHERE MaKhachHang=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh = new KhachHangDTO
                        {
                            MaKhachHang = reader.GetInt32(0),
                            TenKhachHang = reader.GetString(1),
                            SoDienThoai = reader.IsDBNull(2) ? null : reader.GetString(2),
                            NgayDangKy = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3)
                        };
                    }
                }
            }
            return kh;
        }

        public bool Insert(KhachHangDTO kh)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO KhachHang (TenKhachHang, SoDienThoai, NgayDangKy) VALUES (@ten, @sdt, @ngay)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@sdt", (object)kh.SoDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ngay", (object)kh.NgayDangKy ?? DBNull.Value);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(KhachHangDTO kh)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE KhachHang SET TenKhachHang=@ten, SoDienThoai=@sdt, NgayDangKy=@ngay WHERE MaKhachHang=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@sdt", (object)kh.SoDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ngay", (object)kh.NgayDangKy ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", kh.MaKhachHang);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM KhachHang WHERE MaKhachHang=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
