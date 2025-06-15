using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DAL
{
    public class NhaCungCapDAL
    {
        private string relativePath = @"..\..\..\DATA\bkqc.db";
        private string connectionString;

        public NhaCungCapDAL()
        {
            string fullPath = Path.GetFullPath(Path.Combine(Application.StartupPath, relativePath));
            connectionString = $@"Data Source={fullPath};Version=3;";
        }

        public List<NhaCungCapDTO> GetAll()
        {
            var list = new List<NhaCungCapDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi FROM NhaCungCap";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhaCungCapDTO
                        {
                            MaNhaCungCap = reader.GetInt32(0),
                            TenNhaCungCap = reader.GetString(1),
                            SoDienThoai = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DiaChi = reader.IsDBNull(3) ? null : reader.GetString(3)
                        });
                    }
                }
            }
            return list;
        }

        public NhaCungCapDTO GetById(int id)
        {
            NhaCungCapDTO ncc = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi FROM NhaCungCap WHERE MaNhaCungCap=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ncc = new NhaCungCapDTO
                        {
                            MaNhaCungCap = reader.GetInt32(0),
                            TenNhaCungCap = reader.GetString(1),
                            SoDienThoai = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DiaChi = reader.IsDBNull(3) ? null : reader.GetString(3)
                        };
                    }
                }
            }
            return ncc;
        }

        public bool Insert(NhaCungCapDTO ncc)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO NhaCungCap (TenNhaCungCap, SoDienThoai, DiaChi) VALUES (@ten, @sdt, @diachi)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", ncc.TenNhaCungCap);
                cmd.Parameters.AddWithValue("@sdt", (object)ncc.SoDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@diachi", (object)ncc.DiaChi ?? DBNull.Value);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(NhaCungCapDTO ncc)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE NhaCungCap SET TenNhaCungCap=@ten, SoDienThoai=@sdt, DiaChi=@diachi WHERE MaNhaCungCap=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", ncc.TenNhaCungCap);
                cmd.Parameters.AddWithValue("@sdt", (object)ncc.SoDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@diachi", (object)ncc.DiaChi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", ncc.MaNhaCungCap);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM NhaCungCap WHERE MaNhaCungCap=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
