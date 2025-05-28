using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                string query = "SELECT MaKhan, TenKhan, MaLoaiKhan FROM KhanQuangCo";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhanQuangCoDTO
                        {
                            MaKhan = reader.GetInt32(0),
                            TenKhan = reader.GetString(1),
                            MaLoaiKhan = reader.GetInt32(2)
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

                string query = "SELECT MaKhanQuangCo, TenKhan, MaLoaiKhan FROM KhanQuangCo WHERE MaKhanQuangCo=@id";
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
                            MaLoaiKhan = reader.GetInt32(2)
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

                string query = "INSERT INTO KhanQuangCo (TenKhan, MaLoaiKhan) VALUES (@ten, @maloai)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", kqc.TenKhan);
                cmd.Parameters.AddWithValue("@maloai", kqc.MaLoaiKhan);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(KhanQuangCoDTO kqc)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE KhanQuangCo SET TenKhan=@ten, MaLoaiKhan=@maloai WHERE MaKhanQuangCo=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", kqc.TenKhan);
                cmd.Parameters.AddWithValue("@maloai", kqc.MaLoaiKhan);
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

                string query = "DELETE FROM KhanQuangCo WHERE MaKhanQuangCo=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
