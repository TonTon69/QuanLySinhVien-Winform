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
    public partial class FormSinhVien : Form
    {
        StudentDB db = new StudentDB();
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                List<SinhVien> listStudents = db.SinhViens.ToList();
                List<Khoa> listFacultys = db.Khoas.ToList();
                FillFacultyCombox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFacultyCombox(List<Khoa> listFacultys)
        {
            this.cmbKhoa.DataSource = listFacultys;
            this.cmbKhoa.DisplayMember = "TenKhoa";
            this.cmbKhoa.ValueMember = "MaKhoa";
        }
        private void BindGrid(List<SinhVien> listStudents)
        {
            dgvSinhVien.Rows.Clear();
            foreach (var item in listStudents)
            {
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = item.MaSo;
                dgvSinhVien.Rows[index].Cells[1].Value = item.HoTen;
                dgvSinhVien.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvSinhVien.Rows[index].Cells[3].Value = item.GioiTinh == true ? "Nữ" : "Nam";
                dgvSinhVien.Rows[index].Cells[4].Value = item.DiaChi;
                dgvSinhVien.Rows[index].Cells[5].Value = item.DienThoai;
                dgvSinhVien.Rows[index].Cells[6].Value = item.Khoa.TenKhoa;
            }
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                if (dgvSinhVien.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên");

                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvSinhVien.Rows.Add();
                    SinhVien sv = new SinhVien()
                    {
                        MaSo = txtMSSV.Text,
                        HoTen = txtHoTen.Text,
                        NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text),
                        DiaChi = txtDiaChi.Text,
                        GioiTinh = optNu.Checked,
                        DienThoai = txtDienThoai.Text,
                        MaKhoa = cmbKhoa.SelectedValue.ToString(),
                    };
                    db.SinhViens.Add(sv);
                    db.SaveChanges();

                    dgvSinhVien.Rows[selectedRow].Cells[0].Value = sv.MaSo;
                    dgvSinhVien.Rows[selectedRow].Cells[1].Value = sv.HoTen;
                    dgvSinhVien.Rows[selectedRow].Cells[2].Value = sv.NgaySinh;
                    dgvSinhVien.Rows[selectedRow].Cells[3].Value = optNu.Checked ? "Nữ" : "Nam";
                    dgvSinhVien.Rows[selectedRow].Cells[4].Value = sv.DiaChi;
                    dgvSinhVien.Rows[selectedRow].Cells[5].Value = sv.DienThoai;
                    dgvSinhVien.Rows[selectedRow].Cells[6].Value = sv.Khoa.TenKhoa;

                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow != -1)
                {
                    SinhVien sv = db.SinhViens.FirstOrDefault(n => n.MaSo == txtMSSV.Text);
                    if (sv != null)
                    {
                        sv.HoTen = txtHoTen.Text;
                        sv.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                        sv.GioiTinh = optNu.Checked;
                        sv.DiaChi = txtDiaChi.Text;
                        sv.DienThoai = txtDienThoai.Text;
                        sv.MaKhoa = cmbKhoa.SelectedValue.ToString();
                        db.SaveChanges();

                        dgvSinhVien.Rows[selectedRow].Cells[0].Value = sv.MaSo;
                        dgvSinhVien.Rows[selectedRow].Cells[1].Value = sv.HoTen;
                        dgvSinhVien.Rows[selectedRow].Cells[2].Value = sv.NgaySinh;
                        dgvSinhVien.Rows[selectedRow].Cells[3].Value = optNu.Checked ? "Nữ" : "Nam";
                        dgvSinhVien.Rows[selectedRow].Cells[4].Value = sv.DiaChi;
                        dgvSinhVien.Rows[selectedRow].Cells[5].Value = sv.DienThoai;
                        dgvSinhVien.Rows[selectedRow].Cells[6].Value = sv.Khoa.TenKhoa;

                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvSinhVien.Rows.RemoveAt(selectedRow);
                        SinhVien st = db.SinhViens.FirstOrDefault(n => n.MaSo == txtMSSV.Text);
                        if (st != null)
                        {
                            db.SinhViens.Remove(st);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            txtMSSV.Text = dgvSinhVien.Rows[selectedRow].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[selectedRow].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvSinhVien.Rows[selectedRow].Cells[2].Value.ToString();
            if (dgvSinhVien.Rows[selectedRow].Cells[3].Value.ToString() == "True")
            {
                optNu.Checked = true;
            }
            else
            {
                optNam.Checked = true;
            }
            txtDiaChi.Text = dgvSinhVien.Rows[selectedRow].Cells[4].Value.ToString();
            txtDienThoai.Text = dgvSinhVien.Rows[selectedRow].Cells[5].Value.ToString();
            cmbKhoa.Text = dgvSinhVien.Rows[selectedRow].Cells[6].Value.ToString();
        }
    }
}
