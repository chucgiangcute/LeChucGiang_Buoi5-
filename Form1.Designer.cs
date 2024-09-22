namespace LeChucGiang_Buoi5_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTen1 = new TextBox();
            txtGioitinh1 = new TextBox();
            txtNgaysinh1 = new TextBox();
            btnNhap1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            NganhHoc = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMSSV = new TextBox();
            txtNganh = new TextBox();
            txtDTB = new TextBox();
            txtTen2 = new TextBox();
            txtGioitinh2 = new TextBox();
            txtNgaysinh2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtMSNV = new TextBox();
            txtLuong = new TextBox();
            txtChucvu = new TextBox();
            btnnhap2 = new Button();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13F);
            label1.Location = new Point(65, 149);
            label1.Name = "label1";
            label1.Size = new Size(176, 42);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(65, 236);
            label2.Name = "label2";
            label2.Size = new Size(148, 42);
            label2.TabIndex = 0;
            label2.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(65, 334);
            label3.Name = "label3";
            label3.Size = new Size(170, 42);
            label3.TabIndex = 0;
            label3.Text = "Ngày sinh";
            // 
            // txtTen1
            // 
            txtTen1.Font = new Font("Tahoma", 13F);
            txtTen1.Location = new Point(322, 149);
            txtTen1.Name = "txtTen1";
            txtTen1.Size = new Size(330, 49);
            txtTen1.TabIndex = 1;
            txtTen1.TextChanged += textBox1_TextChanged;
            // 
            // txtGioitinh1
            // 
            txtGioitinh1.Font = new Font("Tahoma", 13F);
            txtGioitinh1.Location = new Point(322, 236);
            txtGioitinh1.Name = "txtGioitinh1";
            txtGioitinh1.Size = new Size(330, 49);
            txtGioitinh1.TabIndex = 1;
            txtGioitinh1.TextChanged += textBox1_TextChanged;
            // 
            // txtNgaysinh1
            // 
            txtNgaysinh1.Font = new Font("Tahoma", 13F);
            txtNgaysinh1.Location = new Point(322, 327);
            txtNgaysinh1.Name = "txtNgaysinh1";
            txtNgaysinh1.Size = new Size(330, 49);
            txtNgaysinh1.TabIndex = 1;
            txtNgaysinh1.TextChanged += textBox1_TextChanged;
            // 
            // btnNhap1
            // 
            btnNhap1.Font = new Font("Tahoma", 13F);
            btnNhap1.Location = new Point(322, 37);
            btnNhap1.Name = "btnNhap1";
            btnNhap1.Size = new Size(150, 60);
            btnNhap1.TabIndex = 3;
            btnNhap1.Text = "Nhập";
            btnNhap1.UseVisualStyleBackColor = true;
            btnNhap1.Click += btnNhap1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, GioiTinh, Column2, Column3, NganhHoc, Column4 });
            dataGridView1.Location = new Point(65, 736);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(748, 457);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "hoTen";
            Column1.HeaderText = "Họ Tên";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "gioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 10;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ngaySinh";
            Column2.HeaderText = "Ngày sinh";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "mSSV";
            Column3.HeaderText = "MSSV";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // NganhHoc
            // 
            NganhHoc.DataPropertyName = "nganhHoc";
            NganhHoc.HeaderText = "Ngành học";
            NganhHoc.MinimumWidth = 10;
            NganhHoc.Name = "NganhHoc";
            NganhHoc.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "diemTB";
            Column4.HeaderText = "ĐTB";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.Location = new Point(905, 149);
            label5.Name = "label5";
            label5.Size = new Size(176, 42);
            label5.TabIndex = 0;
            label5.Text = "Họ và Tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13F);
            label6.Location = new Point(905, 239);
            label6.Name = "label6";
            label6.Size = new Size(148, 42);
            label6.TabIndex = 0;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13F);
            label7.Location = new Point(911, 334);
            label7.Name = "label7";
            label7.Size = new Size(170, 42);
            label7.TabIndex = 0;
            label7.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(65, 424);
            label4.Name = "label4";
            label4.Size = new Size(106, 42);
            label4.TabIndex = 0;
            label4.Text = "MSSV";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 13F);
            label8.Location = new Point(65, 525);
            label8.Name = "label8";
            label8.Size = new Size(184, 42);
            label8.TabIndex = 0;
            label8.Text = "Ngành học";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 13F);
            label9.Location = new Point(71, 622);
            label9.Name = "label9";
            label9.Size = new Size(83, 42);
            label9.TabIndex = 0;
            label9.Text = "ĐTB";
            // 
            // txtMSSV
            // 
            txtMSSV.Font = new Font("Tahoma", 13F);
            txtMSSV.Location = new Point(322, 417);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(330, 49);
            txtMSSV.TabIndex = 1;
            txtMSSV.TextChanged += textBox1_TextChanged;
            // 
            // txtNganh
            // 
            txtNganh.Font = new Font("Tahoma", 13F);
            txtNganh.Location = new Point(322, 508);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(330, 49);
            txtNganh.TabIndex = 1;
            txtNganh.TextChanged += textBox1_TextChanged;
            // 
            // txtDTB
            // 
            txtDTB.Font = new Font("Tahoma", 13F);
            txtDTB.Location = new Point(313, 602);
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(330, 49);
            txtDTB.TabIndex = 1;
            txtDTB.TextChanged += textBox1_TextChanged;
            // 
            // txtTen2
            // 
            txtTen2.Font = new Font("Tahoma", 13F);
            txtTen2.Location = new Point(1198, 142);
            txtTen2.Name = "txtTen2";
            txtTen2.Size = new Size(330, 49);
            txtTen2.TabIndex = 1;
            txtTen2.TextChanged += textBox1_TextChanged;
            // 
            // txtGioitinh2
            // 
            txtGioitinh2.Font = new Font("Tahoma", 13F);
            txtGioitinh2.Location = new Point(1198, 236);
            txtGioitinh2.Name = "txtGioitinh2";
            txtGioitinh2.Size = new Size(330, 49);
            txtGioitinh2.TabIndex = 1;
            txtGioitinh2.TextChanged += textBox1_TextChanged;
            // 
            // txtNgaysinh2
            // 
            txtNgaysinh2.Font = new Font("Tahoma", 13F);
            txtNgaysinh2.Location = new Point(1198, 327);
            txtNgaysinh2.Name = "txtNgaysinh2";
            txtNgaysinh2.Size = new Size(330, 49);
            txtNgaysinh2.TabIndex = 1;
            txtNgaysinh2.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13F);
            label10.Location = new Point(911, 424);
            label10.Name = "label10";
            label10.Size = new Size(109, 42);
            label10.TabIndex = 0;
            label10.Text = "MSNV";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 13F);
            label11.Location = new Point(911, 515);
            label11.Name = "label11";
            label11.Size = new Size(115, 42);
            label11.TabIndex = 0;
            label11.Text = "Lương";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 13F);
            label12.Location = new Point(911, 605);
            label12.Name = "label12";
            label12.Size = new Size(144, 42);
            label12.TabIndex = 0;
            label12.Text = "Chức vụ";
            // 
            // txtMSNV
            // 
            txtMSNV.Font = new Font("Tahoma", 13F);
            txtMSNV.Location = new Point(1198, 424);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(330, 49);
            txtMSNV.TabIndex = 1;
            txtMSNV.TextChanged += textBox1_TextChanged;
            // 
            // txtLuong
            // 
            txtLuong.Font = new Font("Tahoma", 13F);
            txtLuong.Location = new Point(1198, 512);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(330, 49);
            txtLuong.TabIndex = 1;
            txtLuong.TextChanged += textBox1_TextChanged;
            // 
            // txtChucvu
            // 
            txtChucvu.Font = new Font("Tahoma", 13F);
            txtChucvu.Location = new Point(1198, 605);
            txtChucvu.Name = "txtChucvu";
            txtChucvu.Size = new Size(330, 49);
            txtChucvu.TabIndex = 1;
            txtChucvu.TextChanged += textBox1_TextChanged;
            // 
            // btnnhap2
            // 
            btnnhap2.Font = new Font("Tahoma", 13F);
            btnnhap2.Location = new Point(1275, 37);
            btnnhap2.Name = "btnnhap2";
            btnnhap2.Size = new Size(150, 60);
            btnnhap2.TabIndex = 5;
            btnnhap2.Text = "Nhập";
            btnnhap2.UseVisualStyleBackColor = true;
            btnnhap2.Click += btnnhap2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView2.Location = new Point(921, 736);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(841, 457);
            dataGridView2.TabIndex = 6;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "hoTen";
            Column5.HeaderText = "Họ Tên";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "gioiTinh";
            Column6.HeaderText = "Giới tính";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ngaySinh";
            Column7.HeaderText = "Ngày sinh";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "mSNV";
            Column8.HeaderText = "MSNV";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "luong";
            Column9.HeaderText = "Lương";
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "chucVu";
            Column10.HeaderText = "Chức vụ";
            Column10.MinimumWidth = 10;
            Column10.Name = "Column10";
            Column10.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 1310);
            Controls.Add(dataGridView2);
            Controls.Add(btnnhap2);
            Controls.Add(dataGridView1);
            Controls.Add(btnNhap1);
            Controls.Add(txtDTB);
            Controls.Add(txtNganh);
            Controls.Add(txtMSSV);
            Controls.Add(txtNgaysinh1);
            Controls.Add(txtGioitinh1);
            Controls.Add(txtChucvu);
            Controls.Add(txtLuong);
            Controls.Add(txtMSNV);
            Controls.Add(txtNgaysinh2);
            Controls.Add(txtGioitinh2);
            Controls.Add(txtTen2);
            Controls.Add(txtTen1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTen1;
        private TextBox txtGioitinh1;
        private TextBox txtNgaysinh1;
        private Button btnNhap1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label9;
        private TextBox txtMSSV;
        private TextBox txtNganh;
        private TextBox txtDTB;
        private TextBox txtTen2;
        private TextBox txtGioitinh2;
        private TextBox txtNgaysinh2;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtMSNV;
        private TextBox txtLuong;
        private TextBox txtChucvu;
        private Button btnnhap2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn NganhHoc;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
