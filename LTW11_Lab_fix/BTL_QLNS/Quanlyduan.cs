using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_QLNS.BUS;
namespace BTL_QLNS
{
    public partial class Quanlyduan : Form
    {
        public Quanlyduan()
        {
            InitializeComponent();
        }
        DuAn_BUS dab = new DuAn_BUS();
        private void btnExit_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            //this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDuAn.DataSource=dab.Search(txtSearch.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
             int sonv = 0;
            if (txtMaDA.Text.Trim() == "")
                MessageBox.Show("Mã dự án không được để trống !");
            else if (txtTenDA.Text.Trim() == "")
                MessageBox.Show("Tên dự án không được để trống !");
            else
                dab.insertDA(txtMaDA.Text, txtTenDA.Text, sonv, txtMotaDA.Text, txtPhanDA.Text, cmbTienDo.Text, rtxtNoiDung.Text,rtxtChuaht.Text, txtlinkDa.Text);
            Quanlyduan_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int sonv = 0;
            if (txtMaDA.Text.Trim() == "")
                MessageBox.Show("Mã dự án không được để trống !");
            else if (txtTenDA.Text.Trim() == "")
                MessageBox.Show("Tên dự án không được để trống !");
            else
            {
                try
                {
                    dab.updateDA(txtMaDA.Text, txtTenDA.Text, int.Parse(txtSoNVDA.Text), txtMotaDA.Text, txtPhanDA.Text, cmbTienDo.Text, rtxtNoiDung.Text, rtxtChuaht.Text, txtlinkDa.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Số nhân viên phải là kiểu số nguyên !" + ex.Message);
                }
            }
            Quanlyduan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dab.deleteDA(txtMaDA.Text);
            Quanlyduan_Load(sender, e);
        }

        private void Quanlyduan_Load(object sender, EventArgs e)
        {
            dgvDuAn.DataSource = dab.getDUAN();
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                cmbTienDo.Items.Clear();
                txtMaDA.Text = dgvDuAn.Rows[index].Cells[0].Value.ToString();
                txtTenDA.Text = dgvDuAn.Rows[index].Cells[1].Value.ToString();
                txtSoNVDA.Text = dgvDuAn.Rows[index].Cells[2].Value.ToString();
                txtMotaDA.Text = dgvDuAn.Rows[index].Cells[3].Value.ToString();
                txtPhanDA.Text= dgvDuAn.Rows[index].Cells[4].Value.ToString();
                //lblTongTD.Text= dgvDuAn.Rows[index].Cells[4].Value.ToString();
                cmbTienDo.Text= dgvDuAn.Rows[index].Cells[5].Value.ToString();
                rtxtNoiDung.Text= dgvDuAn.Rows[index].Cells[6].Value.ToString();
                rtxtChuaht.Text = dgvDuAn.Rows[index].Cells[7].Value.ToString();
                //txtlinkDa.Text= dgvDuAn.Rows[index].Cells[8].Value.ToString();
                linkLabel1.Text = dgvDuAn.Rows[index].Cells[8].Value.ToString();

                int x = 0;
                x = int.Parse(dgvDuAn.Rows[index].Cells[4].Value.ToString());
                string y = x.ToString();
                //lblTongTD.Text = y;
                for (int i = 0; i <= x; i++)
                {
                    cmbTienDo.Items.Add(i);
                }
            }
            int indexy = e.ColumnIndex;
            if(indexy == 8)
            {
                Process.Start(dgvDuAn.Rows[index].Cells[8].Value.ToString());
                //txtlinkDa.Text = dgvDuAn.Rows[index].Cells[8].Value.ToString();
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cmbTienDo.Items.Clear();
            int x = 0;
            x = int.Parse(txtPhanDA.Text);
            string y = x.ToString();
            //lblTongTD.Text = y;
            for(int i=0;i<=x;i++)
            {
                cmbTienDo.Items.Add(i);
            }    
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.linkLabel1.Text);
        }
    }
}
