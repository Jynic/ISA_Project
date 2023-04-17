using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class JadwalTemu
    {
        int id;
        DateTime tanggal;
        string status;
        string keluhan;
        Akun akun_pasien;
        Akun akun_dokter;

        public JadwalTemu(int id, DateTime tanggal, string status, string keluhan, Akun akun_pasien, Akun akun_dokter)
        {
            Id = id;
            Tanggal = tanggal;
            Status = status;
            Keluhan = keluhan;
            Akun_pasien = akun_pasien;
            Akun_dokter = akun_dokter;
        }
        public JadwalTemu()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            Status = "";
            Keluhan = "";
            Akun_pasien = new Akun();
            Akun_dokter = new Akun();
        }
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Status { get => status; set => status = value; }
        public string Keluhan { get => keluhan; set => keluhan = value; }
        public Akun Akun_pasien { get => akun_pasien; set => akun_pasien = value; }
        public Akun Akun_dokter { get => akun_dokter; set => akun_dokter = value; }
    }
}
