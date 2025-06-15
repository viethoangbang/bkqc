using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace bkqc.DAL
{
    public class KhanQuangCoDAL
    {
        private string relativePath = @"..\..\..\DATA\bkqc.db";
        private string connectionString;

        public KhanQuangCoDAL()
        {
            string fullPath = Path.GetFullPath(Path.Combine(Application.StartupPath, relativePath));
            connectionString = $@"Data Source={fullPath};Version=3;";
        }

        public List<KhanQuangCoDTO> GetAll()
        {
            var list = new List<KhanQuangCoDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaKhan, TenKhan, MaLoaiKhan, GiaBan, SoLuongTon, MaNhaCungCap FROM KhanQuangCo";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhanQuangCoDTO
                        {
                            MaKhan = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            TenKhan = reader.IsDBNull(1) ? "" : reader.GetString(1),
                            MaLoaiKhan = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                            GiaBan = reader.IsDBNull(3) ? 0 : reader.GetDouble(3),
                            SoLuongTon = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            MaNhaCungCap = reader.IsDBNull(5) ? 0 : reader.GetInt32(5)
                        });
                    }
                }
            }
            return list;
        }

        public KhanQuangCoDTO GetById(int id)
        {
            KhanQuangCoDTO kqc = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaKhan, TenKhan, MaLoaiKhan, GiaBan, SoLuongTon, MaNhaCungCap FROM KhanQuangCo WHERE MaKhan=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kqc = new KhanQuangCoDTO
                        {
                            MaKhan = reader.GetInt32(0),
                            TenKhan = reader.GetString(1),
                            MaLoaiKhan = reader.GetInt32(2),
                            GiaBan = reader.GetDouble(3),
                            SoLuongTon = reader.GetInt32(4),
                            MaNhaCungCap = reader.GetInt32(5)
                        };
                    }
                }
            }
            return kqc;
        }

        public bool Insert(KhanQuangCoDTO kqc)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    INSERT INTO KhanQuangCo 
                    (TenKhan, MaLoaiKhan, GiaBan, SoLuongTon, MaNhaCungCap) 
                    VALUES 
                    (@ten, @maloai, @giaban, @soluong, @mancc);
                    SELECT last_insert_rowid();";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", kqc.TenKhan);
                cmd.Parameters.AddWithValue("@maloai", kqc.MaLoaiKhan);
                cmd.Parameters.AddWithValue("@giaban", kqc.GiaBan);
                cmd.Parameters.AddWithValue("@soluong", kqc.SoLuongTon);
                cmd.Parameters.AddWithValue("@mancc", kqc.MaNhaCungCap);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    kqc.MaKhan = Convert.ToInt32(result);
                    return true;
                }

                return false;
            }
        }

        public bool Update(KhanQuangCoDTO kqc)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE KhanQuangCo 
                    SET 
                        TenKhan = @ten,
                        MaLoaiKhan = @maloai,
                        GiaBan = @giaban,
                        SoLuongTon = @soluong,
                        MaNhaCungCap = @mancc
                    WHERE MaKhan = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", kqc.TenKhan);
                cmd.Parameters.AddWithValue("@maloai", kqc.MaLoaiKhan);
                cmd.Parameters.AddWithValue("@giaban", kqc.GiaBan);
                cmd.Parameters.AddWithValue("@soluong", kqc.SoLuongTon);
                cmd.Parameters.AddWithValue("@mancc", kqc.MaNhaCungCap);
                cmd.Parameters.AddWithValue("@id", kqc.MaKhan);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM KhanQuangCo WHERE MaKhan=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
