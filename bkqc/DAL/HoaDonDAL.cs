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
        private string connectionString = @"Data Source=your_database_path.db;Version=3;";

        public List<HoaDonDTO> GetAll()
        {
            var list = new List<HoaDonDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaHoaDon, MaKhachHang, NgayBan, TongTien FROM HoaDon";
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
                            TongTien = (double)reader.GetDecimal(3)
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

                string query = "SELECT MaHoaDon, MaKhachHang, NgayBan, TongTien FROM HoaDon WHERE MaHoaDon=@id";
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
                            TongTien = (double)reader.GetDecimal(3)
                        };
                    }
                }
            }
            return hd;
        }

        public bool Insert(HoaDonDTO hd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO HoaDon (MaKhachHang, NgayBan, TongTien) VALUES (@makh, @ngayban, @tongtien)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", hd.MaKhachHang);
                cmd.Parameters.AddWithValue("@ngayban", hd.NgayLap);
                cmd.Parameters.AddWithValue("@tongtien", hd.TongTien);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(HoaDonDTO hd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE HoaDon SET MaKhachHang=@makh, NgayBan=@ngayban, TongTien=@tongtien WHERE MaHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", hd.MaKhachHang);
                cmd.Parameters.AddWithValue("@ngayban", hd.NgayLap);
                cmd.Parameters.AddWithValue("@tongtien", hd.TongTien);
                cmd.Parameters.AddWithValue("@id", hd.MaHoaDon);

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
