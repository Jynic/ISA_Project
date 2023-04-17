using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class KartuKontrol
    {
        int id;
        DateTime tanggal;
        string deskripsi;
        Akun id_pasien;

        public KartuKontrol(int id, DateTime tanggal, string deskripsi, Akun id_pasien)
        {
            Id = id;
            Tanggal = tanggal;
            Deskripsi = deskripsi;
            Id_pasien = id_pasien;
        }
        public KartuKontrol()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            Deskripsi = "";
            Id_pasien = new Akun();

        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public Akun Id_pasien { get => id_pasien; set => id_pasien = value; }
    }
}
