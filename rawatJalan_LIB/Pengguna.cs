using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Pengguna
    {
        private int id;
        private string nama;
        private string nik;
        private string alamat;
        private DateTime ttl;
        private Posisi posisi;
        private string username;
        private string password;

        public Pengguna(int id, string nama, string nik, string alamat, DateTime ttl, Posisi posisi, string username, string password)
        {
            this.Id = id;
            this.Nama = nama;
            this.Nik = nik;
            this.Alamat = alamat;
            this.Ttl = ttl;
            this.Posisi = posisi;
            this.Username = username;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Ttl { get => ttl; set => ttl = value; }
        public Posisi Posisi { get => posisi; set => posisi = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static Pengguna CekLogin(string username, string password)
        {
            string sql = "select * from akun where username = '"+username+"' and password = '"+password+"' ";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                Posisi po = new Posisi(hasil.GetString(5));
                Pengguna p = new Pengguna(int.Parse(hasil.GetString(0)), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), 
                    DateTime.Parse(hasil.GetString(4)), po, hasil.GetString(6), hasil.GetString(7));

                return p;
            }

            return null;
        }
        public static void TambahData(Pengguna p, Posisi po)
        {
            string sql = "insert into akun(id, nama, nik, alamat, ttl, posisi_id, username, password) " +
                "values ('"+p.Id+"', '"+p.Nama+"', '"+p.Nik+"', '"+p.Alamat+"', '"+p.Ttl+"', '"+po.Nama+"', '"+p.Username+"', " +
                "'"+p.Password+"') ";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static void UbahData(Pengguna p, Posisi po)
        {
            string sql = "update akun set nama = '" + p.Nama + "', nik='" + p.Nik + "', alamat='" + p.Alamat + "', ttl='" + p.Ttl + "', " +
                "posisi_id='" + po.Nama + "', username='" + p.Username + "', password='" + p.Password + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
    }
}
