using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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
            System.Diagnostics.Debug.WriteLine("UPDATE jenis_tani SET nama_jenistani = '" + namaJenisTani + "' WHERE id_jenistani = '" + idJenisTani + "')");
            System.Diagnostics.Debug.WriteLine(namaJenisTani);
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
                            Longitude = reader.GetDecimal("longitude"),
                            
                        });
                    }
                }
            }

            return list;
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


    }
}