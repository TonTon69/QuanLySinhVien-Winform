using QuanLySinhVien.Models;
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
    public partial class FormNhapDiem : Form
    {
        StudentDB db = new StudentDB();
        public FormNhapDiem()
        {
            InitializeComponent();
        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSVDataSet.Mon);
            // TODO: This line of code loads data into the 'qLSVDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.qLSVDataSet.KetQua);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiem.Text == "")
                    throw new Exception("Vui lòng nhập điểm cho sinh viên");

                if (double.Parse(txtDiem.Text) > 10 || double.Parse(txtDiem.Text) < 0)
                    throw new Exception("Vui lòng nhập điểm trong khoảng từ 0-10!!!");

                KetQua kq = new KetQua()
                {
                    MaSo = cmbMaSo.Text,
                    MaMH = cmbMaMH.Text,
                    Diem = Convert.ToDouble(txtDiem.Text),
                };
                db.KetQuas.Add(kq);
                db.SaveChanges();

                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            txtDiem.MaxLength = 4;
        }
    }
}
