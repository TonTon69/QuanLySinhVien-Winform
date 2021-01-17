
namespace QuanLySinhVien
{
    partial class FormNhapDiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.cmbMaSo = new System.Windows.Forms.ComboBox();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new QuanLySinhVien.QLSVDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.sinhVienTableAdapter = new QuanLySinhVien.QLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new QuanLySinhVien.QLSVDataSetTableAdapters.KetQuaTableAdapter();
            this.monTableAdapter = new QuanLySinhVien.QLSVDataSetTableAdapters.MonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(310, 201);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(108, 22);
            this.txtDiem.TabIndex = 11;
            // 
            // cmbMaSo
            // 
            this.cmbMaSo.DataSource = this.sinhVienBindingSource;
            this.cmbMaSo.DisplayMember = "MaSo";
            this.cmbMaSo.FormattingEnabled = true;
            this.cmbMaSo.Location = new System.Drawing.Point(310, 38);
            this.cmbMaSo.Name = "cmbMaSo";
            this.cmbMaSo.Size = new System.Drawing.Size(176, 24);
            this.cmbMaSo.TabIndex = 12;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sinhVienBindingSource;
            this.comboBox2.DisplayMember = "HoTen";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(310, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataSource = this.monBindingSource;
            this.cmbMaMH.DisplayMember = "MaMH";
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(310, 118);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(176, 24);
            this.cmbMaMH.TabIndex = 12;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.qLSVDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.monBindingSource;
            this.comboBox4.DisplayMember = "TenMH";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(310, 158);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(281, 24);
            this.comboBox4.TabIndex = 12;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(496, 281);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(95, 40);
            this.btnNhap.TabIndex = 13;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.qLSVDataSet;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbMaSo);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapDiem";
            this.Text = "FormNhapDiem";
            this.Load += new System.EventHandler(this.FormNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.ComboBox cmbMaSo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnNhap;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private QLSVDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private System.Windows.Forms.BindingSource monBindingSource;
        private QLSVDataSetTableAdapters.MonTableAdapter monTableAdapter;
    }
}