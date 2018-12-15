using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Metani.Models
{
    public class MetaniContext
    {

        private MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["metaniEntities"].ConnectionString;
            return new MySqlConnection(connectionString);
        }

        public User Login(User user)
        {
            User userDb = new User();
            string username = user.Username;
            string password = CalculateMD5Hash(user.Password);

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username='" + username + "' AND password='" + password + "'", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userDb.UserId = reader.GetInt32("id_user");
                        userDb.Username = reader.GetString("username");
                        userDb.Password = reader.GetString("password");
                    }
                }
            }

            return userDb;
        }

        public List<JenisTani> GetAllJenisTani()
        {
            List<JenisTani> list = new List<JenisTani>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM jenis_tani", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new JenisTani
                        {
                            IdJenisTani = reader.GetInt32("id_jenistani"),
                            NamaJenisTani = reader.GetString("nama_jenistani")
                        });
                    }
                }
            }

            return list;
        }

        public void PostJenisTani(string namaJenisTani)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO jenis_tani(nama_jenistani) values('" + namaJenisTani + "')", conn);
                cmd.ExecuteNonQuery();
            }          
        }

        public void DeleteJenisTani(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM jenis_tani WHERE id_jenistani = '" + id + "'", conn);
                cmd.ExecuteNonQuery();

            }
            
        }

        public void EditJenisTani(int idJenisTani, string namaJenisTani)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE jenis_tani SET nama_jenistani = '" + namaJenisTani + "' WHERE id_jenistani = '"+ idJenisTani +"'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public JenisTani FindJenisTani(int idJenisTani)
        {
            JenisTani jenisTani = new JenisTani();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM jenis_tani WHERE id_jenistani = ('" + idJenisTani + "')", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jenisTani.IdJenisTani = reader.GetInt32("id_jenistani");
                        jenisTani.NamaJenisTani = reader.GetString("nama_jenistani");
           
                    }
                }

            }

            return jenisTani;
        }

        public List<JenisTanah> GetAllJenisTanah()
        {
            List<JenisTanah> list = new List<JenisTanah>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM jenis_tanah", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new JenisTanah
                        {
                            IdJenisTanah = reader.GetInt32("id_jenistanah"),
                            NamaJenisTanah = reader.GetString("nama_jenistanah")
                        });
                    }
                }
            }

            return list;
        }

        public void PostJenisTanah(string namaJenisTanah)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO jenis_tanah(nama_jenistanah) values('" + namaJenisTanah + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteJenisTanah(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM jenis_tanah WHERE id_jenistanah = '" + id + "'", conn);
                cmd.ExecuteNonQuery();

            }

        }

        public void EditJenisTanah(int idJenisTanah, string namaJenisTanah)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE jenis_tanah SET nama_jenistanah = '" + namaJenisTanah + "' WHERE id_jenistanah = '" + idJenisTanah + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public JenisTanah FindJenisTanah(int idJenisTanah)
        {
            JenisTanah jenisTanah = new JenisTanah();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM jenis_tanah WHERE id_jenistanah = ('" + idJenisTanah + "')", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jenisTanah.IdJenisTanah = reader.GetInt32("id_jenistanah");
                        jenisTanah.NamaJenisTanah = reader.GetString("nama_jenistanah");

                    }
                }

            }

            return jenisTanah;
        }

        public List<HasilTani> GetAllHasilTani()
        {
            List<HasilTani> list = new List<HasilTani>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM hasil_tani", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HasilTani
                        {
                            IdHasilTani = reader.GetInt32("id_hasil"),
                            IdJenisTani = reader.GetInt32("id_jenistani"),
                            Jumlah = reader.GetInt32("jumlah"),
                            IdLokasi = reader.GetInt32("id_lokasi")

                        });
                    }
                }
            }

            return list;
        }

        public List<Lokasi> GetAllLokasiTani()
        {
            List <Lokasi> list = new List<Lokasi>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lokasi", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Lokasi
                        {
                            IdLokasi = reader.GetInt32("id_lokasi"),
                            Kecamatan = reader.GetString("kecamatan"),
                            Kabupaten = reader.GetString("kabupaten"),
                            Provinsi = reader.GetString("provinsi"),
                            KodePos = reader.GetInt32("kode_pos"),
                            Latitude = reader.GetDecimal("latitude"),
                            Longitude = reader.GetDecimal("longtitude"),
                            
                        });
                    }
                }
            }

            return list;
        }

        public Lokasi FindLokasiTani(int idLokasi)
        {
            Lokasi lokasi = new Lokasi();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lokasi WHERE id_lokasi = ('" + idLokasi + "')", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lokasi.IdLokasi= reader.GetInt32("id_lokasi");
                        lokasi.Kecamatan = reader.GetString("kecamatan");
                        lokasi.Kabupaten = reader.GetString("kabupaten");
                        lokasi.Provinsi = reader.GetString("provinsi");
                        lokasi.KodePos = reader.GetInt32("kode_pos");
                        lokasi.Latitude = reader.GetDecimal("latitude");
                        lokasi.Longitude = reader.GetDecimal("longtitude");

                    }
                }

            }

            return lokasi;
        }

        public void PostLokasi(string kecamatan, string kabupaten, string provinsi, string kodepos, decimal latitude, decimal longitude)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO lokasi(kecamatan, kabupaten, provinsi, kode_pos, latitude, longtitude) values('" + kecamatan + "' , '" + kabupaten + "' , '" + provinsi + "' , '" + kodepos + "' , '" + latitude + "' , '" + longitude + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLokasi(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM lokasi WHERE id_lokasi = '" + id + "'", conn);
                cmd.ExecuteNonQuery();

            }

        }

        public void EditLokasi(int idLokasi, string kecamatan, string kabupaten, string provinsi, string kodepos, decimal latitude, decimal longitude)
        {
            System.Diagnostics.Debug.WriteLine("UPDATE lokasi SET kecamatan = '" + kecamatan + "' , kabupaten = '" + kabupaten + "' , provinsi = '" + provinsi + "' , kode_pos = '" + kodepos + "' , latitude = '" + latitude + "' , longtitude = '" + longitude + "' WHERE id_lokasi = '" + idLokasi + "'");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE lokasi SET kecamatan = '" + kecamatan + "' , kabupaten = '" + kabupaten + "' , provinsi = '" + provinsi + "' , kode_pos = '" + kodepos + "' , latitude = '" + latitude + "' , longtitude = '" + longitude + "' WHERE id_lokasi = '" + idLokasi + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Tanah> GetAllTanahTani()
        {
            List<Tanah> list = new List<Tanah>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tanah", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Tanah
                        {
                            IdTanah = reader.GetInt32("id_tanah"),
                            IdLokasi = reader.GetInt32("id_lokasi"),
                            IdJenisTanah = reader.GetInt32("id_jenistanah"),
                            LuasTanah = reader.GetInt32("luas_tanah"),
                            Suhu = reader.GetInt32("suhu")
                        });
                    }
                }
            }

            return list;
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}