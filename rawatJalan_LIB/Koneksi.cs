using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rawatJalan_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;


        #region PROPERTIES
        public Koneksi(MySqlConnection koneksiDB)
        {
            KoneksiDB = koneksiDB;
        }
        #endregion'

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        #region METHOD
        public void Connect()
        {
            //jika connection sedang terbuka maka tutup dahulu
            if (koneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        public void Disconnect()
        {
            if (koneksiDB.State == System.Data.ConnectionState.Closed)
            {
                KoneksiDB.Open();
            }
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            //MySqlDataReader result = null;
            Koneksi connection = new Koneksi();
            MySqlCommand comm = new MySqlCommand(sql, connection.KoneksiDB);
            MySqlDataReader hasil = comm.ExecuteReader();
            return hasil;
        }
        public static int JalankanPerintahDML(string sql)
        {
            Koneksi connection = new Koneksi();
            MySqlCommand comm = new MySqlCommand(sql, connection.KoneksiDB);
            int result = comm.ExecuteNonQuery();
            return result;
        }
        public static int JalankanPerintahDML(string sql, Koneksi dbConnection)
        {
            MySqlCommand command = new MySqlCommand(sql, dbConnection.KoneksiDB);
            return command.ExecuteNonQuery();
        }
        #endregion

        #region Constuctor 
        public Koneksi()
        {
            //Membuat konfigurasi App.Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Ambi section userSettings yang otomatis dibuat berdasarkan file .settings
            ConfigurationSectionGroup userSettings = config.SectionGroups["userSettings"];

            //Ambil bagian setting
            var settingSection = userSettings.Sections["ISA_2023.db"] as ClientSettingsSection;

            //Ambil tiap variable setting
            string DbServer = settingSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;
            //tambahkan sslmode=none jika tidak bisa konek 
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = strCon;

            //panggil method Connect
            Connect();
        }
        #endregion

    }
}
