﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS {
    public partial class frmHocSinh : Form {
        public frmHocSinh() {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e) {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e) {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e) {

        }

        private void textDiaChi_TextChanged(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void mskPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void frmHocSinh_Load(object sender, EventArgs e) {
            DatabaseConnection.Connected();
            if (!DatabaseConnection.IsConnect()) {
                MessageBox.Show("Không kết nối được dữ liệu");
                return;
            }
            FillDataGridView();
        }
        void FillDataGridView() {
            string query = "SELECT * " +
                "FROM HOCSINH";
            dgvHS.DataSource = DatabaseConnection.GetDataTable(query);
            // adapter.Dispose();
        }

        private void button4_Click(object sender, EventArgs e) {
            
        }
        //bool GeneralCheck() {
        //    bool flag = true;
        //    if (txtHoTen.Text == "") {
        //        flag = false;
        //        //provider
        //    }
        //    if (cboGioiTinh.Text == "") {
        //        flag = false;
        //        //provider
        //    }
        //    //if (dtpNgSinh.)
        //    return flag;
        //}
    }
}
