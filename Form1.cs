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
    }
}
