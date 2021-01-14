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
    public partial class FormXemDiem : Form
    {
        StudentDB db = new StudentDB();
        public FormXemDiem()
        {
            InitializeComponent();
        }

        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLSVDataSet.Khoa);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //string con = global::QuanLySinhVien.Properties.Settings.Default.QLSVConnectionString;
            //string str;
            //str = string.Format("Select TenMH, Diem From KetQua kq, Mon mh where kq.MaMH = mh.MaMH and MaSo = {0}", cmbMaSo.Text);
            //SqlDataAdapter da = new SqlDataAdapter(str, con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dgvXemDiem.DataSource = ds.Tables[0];
            var queryResult = (from a
                               in db.KetQuas
                               join b in db.Mons on a.MaMH equals b.MaMH
                               select new
                               {
                                  TenMH = b.TenMH,
                                  Diem = a.Diem,
                               }).ToList();
            dgvXemDiem.DataSource = queryResult;
        }
    }
}
