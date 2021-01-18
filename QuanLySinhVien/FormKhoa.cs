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
    public partial class FormKhoa : Form
    {
        StudentDB db = new StudentDB();
        public FormKhoa()
        {
            InitializeComponent();
        }
        private void FormKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                List<Khoa> listFacultys = db.Khoas.ToList();
                dgvKhoa.Rows.Clear();
                foreach (var item in listFacultys)
                {
                    int index = dgvKhoa.Rows.Add();
                    dgvKhoa.Rows[index].Cells[0].Value = item.MaKhoa;
                    dgvKhoa.Rows[index].Cells[1].Value = item.TenKhoa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GetSelectedRow(string facultyID)
        {
            for (int i = 0; i < dgvKhoa.Rows.Count; i++)
            {
                if (dgvKhoa.Rows[i].Cells[0].Value.ToString() == facultyID)
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
                if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khoa");

                var checkMaKhoa = db.Khoas.FirstOrDefault(x => x.MaKhoa == txtMaKhoa.Text);
                if (checkMaKhoa != null)
                    throw new Exception("Mã khoa đã tồn tại!!");
                else
                {
                    int selectedRow = GetSelectedRow(txtMaKhoa.Text);
                    if (selectedRow == -1)
                    {
                        selectedRow = dgvKhoa.Rows.Add();
                        Khoa khoa = new Khoa()
                        {
                            MaKhoa = txtMaKhoa.Text,
                            TenKhoa = txtTenKhoa.Text
                        };
                        db.Khoas.Add(khoa);
                        db.SaveChanges();

                        dgvKhoa.Rows[selectedRow].Cells[0].Value = khoa.MaKhoa;
                        dgvKhoa.Rows[selectedRow].Cells[1].Value = khoa.TenKhoa;

                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaKhoa.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy mã khoa cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvKhoa.Rows.RemoveAt(selectedRow);
                        Khoa khoa = db.Khoas.FirstOrDefault(n => n.MaKhoa == txtMaKhoa.Text);
                        if (khoa != null)
                        {
                            db.Khoas.Remove(khoa);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
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
                int selectedRow = GetSelectedRow(txtMaKhoa.Text);
                if (selectedRow != -1)
                {
                    Khoa khoa = db.Khoas.FirstOrDefault(n => n.MaKhoa == txtMaKhoa.Text);
                    if (khoa != null)
                    {
                        khoa.TenKhoa = txtTenKhoa.Text;
                        db.SaveChanges();

                        dgvKhoa.Rows[selectedRow].Cells[0].Value = khoa.MaKhoa;
                        dgvKhoa.Rows[selectedRow].Cells[1].Value = khoa.TenKhoa;

                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[selectedRow].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[selectedRow].Cells[1].Value.ToString();
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            txtMaKhoa.MaxLength = 6;
            
        }
    }
}
