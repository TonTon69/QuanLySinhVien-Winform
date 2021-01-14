
namespace QuanLySinhVien
{
    partial class FormThongKeKhoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvThongKeTheoKhoa = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new QuanLySinhVien.QLSVDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QuanLySinhVien.QLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.khoaTableAdapter = new QuanLySinhVien.QLSVDataSetTableAdapters.KhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeTheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKeTheoKhoa
            // 
            this.dgvThongKeTheoKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeTheoKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeTheoKhoa.Location = new System.Drawing.Point(52, 133);
            this.dgvThongKeTheoKhoa.Name = "dgvThongKeTheoKhoa";
            this.dgvThongKeTheoKhoa.RowHeadersWidth = 51;
            this.dgvThongKeTheoKhoa.RowTemplate.Height = 24;
            this.dgvThongKeTheoKhoa.Size = new System.Drawing.Size(692, 278);
            this.dgvThongKeTheoKhoa.TabIndex = 33;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(522, 55);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(95, 37);
            this.btnXem.TabIndex = 32;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.khoaBindingSource;
            this.comboBox2.DisplayMember = "TenKhoa";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 24);
            this.comboBox2.TabIndex = 30;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.khoaBindingSource;
            this.comboBox1.DisplayMember = "MaKhoa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã khoa";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSVDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongKeKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvThongKeTheoKhoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongKeKhoa";
            this.Text = "Xem sinh viên theo Khoa";
            this.Load += new System.EventHandler(this.FormThongKeKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeTheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKeTheoKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QLSVDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
    }
}