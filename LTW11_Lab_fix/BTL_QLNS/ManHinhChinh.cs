using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BTL_QLNS
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }
        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            Quanlynhanvien frmnv = new Quanlynhanvien();
            frmnv.Show();
            //this.Hide();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            this.Close();
            Quanlyphongban frmpb = new Quanlyphongban();
            frmpb.Show();
            //this.Hide();
        }

        private void btnDuan_Click(object sender, EventArgs e)
        {
            this.Close();
            Quanlyduan frmda = new Quanlyduan();
            frmda.Show();
            //this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap frmdn = new DangNhap();
            frmdn.Show();
            //this.Hide();
        }

        private void lblLicense_Click(object sender, EventArgs e)
        {

        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            SoundPlayer msplay = new SoundPlayer(@"D:\Winform\Racing1\Sounds\music1 (mp3cut.net).wav");
            msplay.Play();
        }
    }
}
