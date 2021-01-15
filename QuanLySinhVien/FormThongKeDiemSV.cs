using Microsoft.Reporting.WinForms;
using QuanLySinhVien.Models;
using QuanLySinhVien.Reportings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormThongKeDiemSV : Form
    {
        StudentDB db = new StudentDB();
        public FormThongKeDiemSV()
        {
            InitializeComponent();
        }

        private void FormThongKeDiemSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSVDataSet.Mon);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

            BindGrid();
            this.cmbMonHoc.SelectedIndex = -1;
        }

        private void BindGrid()
        {
            string truyVanSQL = "SELECT s.MaSo, s.HoTen, kq.Diem, m.TenMH, k.TenKhoa " +
                                "FROM Mon m, SinhVien s, KetQua kq, Khoa k " +
                                "WHERE s.MaKhoa = k.MaKhoa AND s.MaSo = kq.MaSo AND kq.MaMH = m.MaMH ";
            List<StudentReport> list = db.Database.SqlQuery<StudentReport>(truyVanSQL).ToList();
            if (cmbMonHoc.SelectedIndex >= 0)
            {
                list = list.Where(x => x.TenMH == cmbMonHoc.Text).ToList();
            }
            this.rptvThongKeSV.LocalReport.ReportPath = "rptQLSVReport.rdlc";
            var reportDataSource = new ReportDataSource("ReportStudentDataset", list);
            this.rptvThongKeSV.LocalReport.DataSources.Clear();
            this.rptvThongKeSV.LocalReport.DataSources.Add(reportDataSource);
            this.rptvThongKeSV.RefreshReport();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
