using System.Windows.Forms;

namespace LeChucGiang_Buoi5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List<SinhVien> li_sv = new List<SinhVien>();
        private void btnNhap1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txtTen1.Text, txtGioitinh1.Text, txtNgaysinh1.Text, txtMSSV.Text, txtNganh.Text, Convert.ToDouble(txtDTB.Text));
            li_sv.Add(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sv;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<NhanVien> li_nv = new List<NhanVien>();
        private void btnnhap2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtTen2.Text, txtGioitinh2.Text, txtNgaysinh2.Text, txtMSNV.Text, txtLuong.Text, txtChucvu.Text);
            li_nv.Add(nv);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = li_nv;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in li_sv)
            {
                if (txtMSSV.Text == i.MSSV)
                {
                    li_sv.Remove(i);
                    break;
                    
                }
              

            }
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = li_sv;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in li_sv)
            {
                if (txtMSSV.Text == i.MSSV)
                {

                    i.HoTen = txtTen1.Text;
                    i.GioiTinh = txtGioitinh1.Text;
                    i.NgaySinh = txtNgaysinh1.Text;
                    i.NganhHoc = txtNganh.Text;
                    i.DiemTB = double.Parse(txtDTB.Text);
                   
                }
                
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = li_sv;


            }
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            foreach (NhanVien i in li_nv)
            {
                if (txtMSNV.Text == i.MSNV)
                {
                    
                    i.HoTen = txtTen1.Text;
                    i.GioiTinh = txtGioitinh1.Text;
                    i.NgaySinh = txtNgaysinh1.Text;
                    i.MSNV = txtMSSV.Text;
                    i.Luong = txtLuong.Text;
                    i.ChucVu = txtChucvu.Text;

                    dataGridView2.DataSource = null;

                    dataGridView2.DataSource = li_nv;
                }
                
                dataGridView2.DataSource = null;

                dataGridView2.DataSource = li_nv;

            }

        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            foreach (NhanVien i in li_nv)
            {
                if (txtMSNV.Text == i.MSNV)
                {
                    li_nv.Remove(i);
                    break;
                    
                }
                

            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = li_nv;
        }
    }
}
