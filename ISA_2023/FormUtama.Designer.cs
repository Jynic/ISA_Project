
namespace ISA_2023
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahJadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPasianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarPasianToolStripMenuItem,
            this.daftarDokterToolStripMenuItem,
            this.riwayatToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahJadwalToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tambahJadwalToolStripMenuItem
            // 
            this.tambahJadwalToolStripMenuItem.Name = "tambahJadwalToolStripMenuItem";
            this.tambahJadwalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tambahJadwalToolStripMenuItem.Text = "Tambah Jadwal";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // daftarPasianToolStripMenuItem
            // 
            this.daftarPasianToolStripMenuItem.Name = "daftarPasianToolStripMenuItem";
            this.daftarPasianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.daftarPasianToolStripMenuItem.Text = "Daftar Pasian";
            // 
            // daftarDokterToolStripMenuItem
            // 
            this.daftarDokterToolStripMenuItem.Name = "daftarDokterToolStripMenuItem";
            this.daftarDokterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.daftarDokterToolStripMenuItem.Text = "Daftar Dokter";
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.riwayatToolStripMenuItem.Text = "Riwayat Pemeriksaan";
            this.riwayatToolStripMenuItem.Click += new System.EventHandler(this.riwayatToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "FormUtama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarPasianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahJadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}