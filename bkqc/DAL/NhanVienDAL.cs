using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace bkqc.DAL
{
    public class NhanVienDAL
    {
        private string connectionString;

        public NhanVienDAL()
        {
            // Đường dẫn sqlite sẽ được tự động copy nhờ .csproj
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATA", "bkqc.db");

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException("Không tìm thấy file cơ sở dữ liệu", fullPath);
            }

            connectionString = $@"Data Source={fullPath};Version=3;";
        }

        public List<NhanVienDTO> GetAll()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaNhanVien, TenNhanVien, TenDangNhap, MatKhau FROM NhanVien";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienDTO
                        {
                            MaNhanVien = reader.GetInt32(0),
                            TenNhanVien = reader.GetString(1),
                            TenDangNhap = reader.GetString(2),
                            MatKhau = reader.GetString(3)
                        });
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
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nv = new NhanVienDTO
                            {
                                MaNhanVien = reader.GetInt32(0),
                                TenNhanVien = reader.GetString(1),
                                TenDangNhap = reader.GetString(2),
                                MatKhau = reader.GetString(3)
                            };
                        }
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
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", nv.TenNhanVien);
                    cmd.Parameters.AddWithValue("@tdn", nv.TenDangNhap);
                    cmd.Parameters.AddWithValue("@mk", nv.MatKhau);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE NhanVien SET TenNhanVien=@ten, TenDangNhap=@tdn, MatKhau=@mk WHERE MaNhanVien=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", nv.TenNhanVien);
                    cmd.Parameters.AddWithValue("@tdn", nv.TenDangNhap);
                    cmd.Parameters.AddWithValue("@mk", nv.MatKhau);
                    cmd.Parameters.AddWithValue("@id", nv.MaNhanVien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM NhanVien WHERE MaNhanVien=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public NhanVienDTO DangNhap(string tenDangNhap, string matKhau)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, VaiTro, TrangThai 
                                 FROM NhanVien 
                                 WHERE TenDangNhap = @tdn AND MatKhau = @mk AND TrangThai = 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tdn", tenDangNhap);
                    cmd.Parameters.AddWithValue("@mk", matKhau);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new NhanVienDTO
                            {
                                MaNhanVien = reader.GetInt32(0),
                                TenNhanVien = reader.GetString(1),
                                TenDangNhap = reader.GetString(2),
                                MatKhau = reader.GetString(3),
                                VaiTro = reader.GetString(4),
                                TrangThai = reader.GetInt32(5)
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
