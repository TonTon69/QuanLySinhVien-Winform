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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            FormAboutQLSV aboutQLSV = new FormAboutQLSV();
            aboutQLSV.MdiParent = this;
            aboutQLSV.Show();
        }

        private void tsbThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần mềm?", "YES/NO", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f.Name == "FormSinhVien")
                {
                    f.Activate();
                    return;
                }
            }
            FormSinhVien frmSV = new FormSinhVien();
            frmSV.MdiParent = this;
            frmSV.Show();
        }

        private void tsbKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            FormKhoa frmKhoa = new FormKhoa();
            frmKhoa.MdiParent = this;
            frmKhoa.Show();
        }

        private void tsbMonHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormMonHoc")
                {
                    f.Activate();
                    return;
                }
            }
            FormMonHoc frmMH = new FormMonHoc();
            frmMH.MdiParent = this;
            frmMH.Show();
        }

        private void tsbNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormNhapDiem")
                {
                    f.Activate();
                    return;
                }
            }
            FormNhapDiem frmNhapDiem = new FormNhapDiem();
            frmNhapDiem.MdiParent = this;
            frmNhapDiem.Show();
        }

        private void tsbXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormXemDiem")
                {
                    f.Activate();
                    return;
                }
            }
            FormXemDiem frmXemDiem = new FormXemDiem();
            frmXemDiem.MdiParent = this;
            frmXemDiem.Show();
        }

        private void tsbThongKeKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormThongKeKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            FormThongKeKhoa frmTKKhoa = new FormThongKeKhoa();
            frmTKKhoa.MdiParent = this;
            frmTKKhoa.Show();
        }
    }
}
