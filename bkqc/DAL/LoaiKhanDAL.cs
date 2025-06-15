using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkqc.DAL
{
    public class LoaiKhanDAL
    {
        private string relativePath = @"..\..\..\DATA\bkqc.db";
        private string connectionString;

        public LoaiKhanDAL()
        {
            string fullPath = Path.GetFullPath(Path.Combine(Application.StartupPath, relativePath));
            connectionString = $@"Data Source={fullPath};Version=3;";
        }

        public List<LoaiKhanDTO> GetAll()
        {
            var list = new List<LoaiKhanDTO>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaLoaiKhan, TenLoai FROM LoaiKhan";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoaiKhanDTO
                        {
                            MaLoaiKhan = reader.GetInt32(0),
                            TenLoai = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public LoaiKhanDTO GetById(int id)
        {
            LoaiKhanDTO loai = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaLoaiKhan, TenLoai FROM LoaiKhan WHERE MaLoaiKhan=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        loai = new LoaiKhanDTO
                        {
                            MaLoaiKhan = reader.GetInt32(0),
                            TenLoai = reader.GetString(1)
                        };
                    }
                }
            }
            return loai;
        }

        public bool Insert(LoaiKhanDTO loai)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO LoaiKhan (TenLoai) VALUES (@ten)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", loai.TenLoai);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Update(LoaiKhanDTO loai)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE LoaiKhan SET TenLoai=@ten WHERE MaLoaiKhan=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", loai.TenLoai);
                cmd.Parameters.AddWithValue("@id", loai.MaLoaiKhan);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM LoaiKhan WHERE MaLoaiKhan=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
