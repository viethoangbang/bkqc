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
        private string connectionString;

        public ChiTietHoaDonDAL()
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATA", "bkqc.db");

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException("Không tìm thấy file cơ sở dữ liệu", fullPath);
            }

            connectionString = $@"Data Source={fullPath};Version=3;";
        }
        public List<ChiTietHoaDonDTO> GetAll()
        {
            var list = new List<ChiTietHoaDonDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaChiTiet, MaHoaDon, MaKhan, SoLuong, DonGia, ThanhTien FROM ChiTietHoaDon";
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
                            DonGia = (double)reader.GetDecimal(4),
                            ThanhTien = (double)reader.GetDecimal(5)
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

                string query = "SELECT MaChiTiet, MaHoaDon, MaKhan, SoLuong, DonGia, ThanhTien FROM ChiTietHoaDon WHERE MaChiTiet=@id";
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
                            DonGia = (double)reader.GetDouble(4),
                            ThanhTien = (double)reader.GetDouble(5)
                        };
                    }
                }
            }
            return ct;
        }
        public List<ChiTietHoaDonDTO> GetByMaHoaDon(int maHoaDon)
        {
            List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();
            string query = "SELECT MaChiTiet, MaHoaDon, MaKhan, SoLuong, DonGia, ThanhTien FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ChiTietHoaDonDTO
                            {
                                MaChiTiet = reader.GetInt32(0),
                                MaHoaDon = reader.GetInt32(1),
                                MaKhan = reader.GetInt32(2),
                                SoLuong = reader.GetInt32(3),
                                DonGia = (double)reader.GetDouble(4),
                                ThanhTien = (double)reader.GetDouble(5)
                            });
                        }
                    }
                }
            }

            return list;
        }


        public bool Insert(ChiTietHoaDonDTO ct)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaKhan, SoLuong, DonGia, ThanhTien) VALUES (@mahd, @makhan, @soluong, @dongia, @thanhtien)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahd", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@makhan", ct.MaKhan);
                cmd.Parameters.AddWithValue("@soluong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@dongia", ct.DonGia);
                cmd.Parameters.AddWithValue("@thanhtien", ct.ThanhTien);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(ChiTietHoaDonDTO ct)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE ChiTietHoaDon SET MaHoaDon=@mahd, MaKhanQuangCo=@makhan, SoLuong=@soluong, DonGia=@dongia WHERE MaChiTiet=@id";
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

                string query = "DELETE FROM ChiTietHoaDon WHERE MaChiTiet=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
