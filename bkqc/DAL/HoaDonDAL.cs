using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DAL
{
    public class HoaDonDAL
    {
        private string connectionString;

        public HoaDonDAL()
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATA", "bkqc.db");

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException("Không tìm thấy file cơ sở dữ liệu", fullPath);
            }

            connectionString = $@"Data Source={fullPath};Version=3;";
        }
        public List<HoaDonDTO> GetAll()
        {
            var list = new List<HoaDonDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaHoaDon, MaKhachHang, NgayLap, MaNhanVien, TongTien FROM HoaDon";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDonDTO
                        {
                            MaHoaDon = reader.GetInt32(0),
                            MaKhachHang = reader.GetInt32(1),
                            NgayLap = reader.GetDateTime(2),
                            MaNhanVien = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            TongTien = reader.IsDBNull(4) ? 0 : Convert.ToDouble(reader["TongTien"]),
                        });

                    }
                }
            }
            return list;
        }

        public HoaDonDTO GetById(int id)
        {
            HoaDonDTO hd = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaHoaDon, MaKhachHang, NgayLap, MaNhanVien, TongTien FROM HoaDon WHERE MaHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hd = new HoaDonDTO
                        {
                            MaHoaDon = reader.GetInt32(0),
                            MaKhachHang = reader.GetInt32(1),
                            NgayLap = reader.GetDateTime(2),
                            MaNhanVien = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            TongTien = reader.IsDBNull(4) ? 0 : Convert.ToDouble(reader["TongTien"])
                        };
                    }
                }
            }
            return hd;
        }


        public int Insert(HoaDonDTO hd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO HoaDon (MaKhachHang, MaNhanVien, NgayLap, TongTien) VALUES (@makh, @manv, @ngaylap, @tongtien); " +
                               "SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@makh", hd.MaKhachHang);
                    cmd.Parameters.AddWithValue("@manv", hd.MaNhanVien);
                    cmd.Parameters.AddWithValue("@ngaylap", hd.NgayLap);
                    cmd.Parameters.AddWithValue("@tongtien", hd.TongTien);

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }


        public bool Update(HoaDonDTO hd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE HoaDon SET MaKhachHang=@makh, MaNhanVien=@manv, NgayBan=@ngayban, TongTien=@tongtien WHERE MaHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", hd.MaKhachHang);
                cmd.Parameters.AddWithValue("@ngayban", hd.NgayLap);
                cmd.Parameters.AddWithValue("@tongtien", hd.TongTien);
                cmd.Parameters.AddWithValue("@id", hd.MaHoaDon);
                cmd.Parameters.AddWithValue("@manv", hd.MaNhanVien);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM HoaDon WHERE MaHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
