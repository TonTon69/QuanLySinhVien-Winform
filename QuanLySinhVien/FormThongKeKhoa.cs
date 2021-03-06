﻿using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormThongKeKhoa : Form
    {
        StudentDB db = new StudentDB();
        public FormThongKeKhoa()
        {
            InitializeComponent();
        }

        private void FormThongKeKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLSVDataSet.Khoa);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            string con = global::QuanLySinhVien.Properties.Settings.Default.QLSVConnectionString;
            string str;
            str = string.Format("Select b.MaSo, b.HoTen, b.NgaySinh, b.GioiTinh, b.DiaChi, b.DienThoai From Khoa a, SinhVien b where a.MaKhoa = b.MaKhoa and b.MaKhoa = '" + comboBox1.Text + "'");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvThongKeTheoKhoa.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
