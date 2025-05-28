using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DAL
{
    public class ChiTietHoaDonDAL
    {
        private string connectionString = @"Data Source=your_database_path.db;Version=3;";

        public List<ChiTietHoaDonDTO> GetAll()
        {
            var list = new List<ChiTietHoaDonDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaChiTietHoaDon, MaHoaDon, MaKhanQuangCo, SoLuong, DonGia FROM ChiTietHoaDon";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ChiTietHoaDonDTO
                        {
                            MaChiTiet = reader.GetInt32(0),
                            MaHoaDon = reader.GetInt32(1),
                            MaKhan = reader.GetInt32(2),
                            SoLuong = reader.GetInt32(3),
                            DonGia = (double)reader.GetDecimal(4)
                        });
                    }
                }
            }
            return list;
        }

        public ChiTietHoaDonDTO GetById(int id)
        {
            ChiTietHoaDonDTO ct = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaChiTietHoaDon, MaHoaDon, MaKhanQuangCo, SoLuong, DonGia FROM ChiTietHoaDon WHERE MaChiTietHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ct = new ChiTietHoaDonDTO
                        {
                            MaChiTiet = reader.GetInt32(0),
                            MaHoaDon = reader.GetInt32(1),
                            MaKhan = reader.GetInt32(2),
                            SoLuong = reader.GetInt32(3),
                            DonGia = (double)reader.GetDecimal(4)
                        };
                    }
                }
            }
            return ct;
        }

        public bool Insert(ChiTietHoaDonDTO ct)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaKhanQuangCo, SoLuong, DonGia) VALUES (@mahd, @makhan, @soluong, @dongia)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahd", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@makhan", ct.MaKhan);
                cmd.Parameters.AddWithValue("@soluong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@dongia", ct.DonGia);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(ChiTietHoaDonDTO ct)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE ChiTietHoaDon SET MaHoaDon=@mahd, MaKhanQuangCo=@makhan, SoLuong=@soluong, DonGia=@dongia WHERE MaChiTietHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahd", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@makhan", ct.MaKhan);
                cmd.Parameters.AddWithValue("@soluong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@dongia", ct.DonGia);
                cmd.Parameters.AddWithValue("@id", ct.MaChiTiet);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM ChiTietHoaDon WHERE MaChiTietHoaDon=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
