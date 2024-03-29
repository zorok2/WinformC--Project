﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class Payment : Form
    {
        private double tongTien;
        private string maHD;
        private int khuyenMai;
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(double total, string maHD, int khuyenMai)
        {
            InitializeComponent();
            this.tongTien = total;
            this.maHD = maHD;
            this.khuyenMai = khuyenMai;
        }


        private double customerMoney = 0;
        private void iconPic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void iconPic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double money = Convert.ToDouble(button.Tag);
            customerMoney += money;
            txtKhachDua.Text = String.Format("{0:0.000}", customerMoney);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtTotalPrice.Text = String.Format("{0:0.000}", (tongTien-((khuyenMai * tongTien)/100)));
            txtDiscount.Text = String.Format("{0:0.000}", (khuyenMai*tongTien)/100);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double tong = Convert.ToDouble(txtTotalPrice.Text);

            double khachDua = Convert.ToDouble(txtKhachDua.Text);

            lblResult.Text = String.Format("{0:0.000}", (khachDua - tong)) + "   VNĐ";
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtKhachDua.Clear();
            lblResult.Text = "";
            customerMoney = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                reportView reportView = new reportView();
                reportView.Show();
            }
            else
            {
                this.Close();

            }

        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr =  MessageBox.Show("bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
