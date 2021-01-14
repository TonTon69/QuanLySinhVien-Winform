using QuanLySinhVien.Models;
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

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //var queryResult = (from a
            //                   in db.Khoas
            //                   join b in db.SinhViens on a.MaKhoa equals b.MaKhoa
            //                   select new
            //                   {
            //                       MSSV = b.MaSo,
            //                       HoTen = b.HoTen,
            //                       NgaySinh = b.NgaySinh,
            //                       GioiTinh = b.GioiTinh,
            //                       DiaChi = b.DiaChi,
            //                       DienThoai = b.DienThoai
            //                   }).ToList();
            //    dgvThongKeTheoKhoa.DataSource = queryResult;
            string con = global::QuanLySinhVien.Properties.Settings.Default.QLSVConnectionString;
            string str;
            str = string.Format("Select MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai From Khoa a, SinhVien b where a.MaKhoa = b.MaKhoa", comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvThongKeTheoKhoa.DataSource = ds.Tables[0];
        }
    }
}
