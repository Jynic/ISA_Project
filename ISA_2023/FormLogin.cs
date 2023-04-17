using rawatJalan_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_2023
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();
                Akun a = Akun.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                MainForm frmMain = (MainForm)this.Owner;
                frmMain.akun = a;
                if(!(a is null))
                {
                    frmMain.status = Akun.CekPosisi(a);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
