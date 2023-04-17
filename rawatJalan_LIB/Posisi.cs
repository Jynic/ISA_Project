using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Posisi
    {
        int id;
        string nama;

        public Posisi(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public Posisi()
        {
            Id = 0;
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }

}
