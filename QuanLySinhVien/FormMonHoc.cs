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
    public partial class FormMonHoc : Form
    {
        StudentDB db = new StudentDB();
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                List<Mon> listMonHoc = db.Mons.ToList();
                dgvMonHoc.Rows.Clear();
                foreach (var item in listMonHoc)
                {
                    int index = dgvMonHoc.Rows.Add();
                    dgvMonHoc.Rows[index].Cells[0].Value = item.MaMH;
                    dgvMonHoc.Rows[index].Cells[1].Value = item.TenMH;
                    dgvMonHoc.Rows[index].Cells[2].Value = item.SoTiet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GetSelectedRow(string monID)
        {
            for (int i = 0; i < dgvMonHoc.Rows.Count; i++)
            {
                if (dgvMonHoc.Rows[i].Cells[0].Value.ToString() == monID)
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
                if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTiet.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin môn học");

                int selectedRow = GetSelectedRow(txtMaMH.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvMonHoc.Rows.Add();
                    Mon mh = new Mon()
                    {
                        MaMH = txtMaMH.Text,
                        TenMH = txtTenMH.Text,
                        SoTiet = Int32.Parse(txtSoTiet.Text)
                    };
                    db.Mons.Add(mh);
                    db.SaveChanges();

                    dgvMonHoc.Rows[selectedRow].Cells[0].Value = mh.MaMH;
                    dgvMonHoc.Rows[selectedRow].Cells[1].Value = mh.TenMH;
                    dgvMonHoc.Rows[selectedRow].Cells[2].Value = mh.SoTiet;

                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
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
                int selectedRow = GetSelectedRow(txtMaMH.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy mã môn học cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvMonHoc.Rows.RemoveAt(selectedRow);
                        Mon mh = db.Mons.FirstOrDefault(n => n.MaMH == txtMaMH.Text);
                        if (mh != null)
                        {
                            db.Mons.Remove(mh);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK);
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
                int selectedRow = GetSelectedRow(txtMaMH.Text);
                if (selectedRow != -1)
                {
                    Mon mh = db.Mons.FirstOrDefault(n => n.MaMH == txtMaMH.Text);
                    if (mh != null)
                    {
                        mh.TenMH = txtTenMH.Text;
                        mh.SoTiet = Int32.Parse(txtSoTiet.Text);
                        db.SaveChanges();

                        dgvMonHoc.Rows[selectedRow].Cells[0].Value = mh.MaMH;
                        dgvMonHoc.Rows[selectedRow].Cells[1].Value = mh.TenMH;
                        dgvMonHoc.Rows[selectedRow].Cells[2].Value = mh.SoTiet;

                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[selectedRow].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[selectedRow].Cells[1].Value.ToString();
            txtSoTiet.Text = dgvMonHoc.Rows[selectedRow].Cells[2].Value.ToString();
        }

    }
}
