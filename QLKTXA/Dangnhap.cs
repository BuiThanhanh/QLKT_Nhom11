using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKTXA
{
    public partial class Dangnhap : Form
    {
        string DuongDan = @"Data Source=MINHTHUW\MAY1;Initial Catalog=dbQLKTX;Integrated Security=True;Encrypt=False";

        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            string password = txtmatkhau.Text;
            SqlConnection connection = new SqlConnection(DuongDan);
            connection.Open();
            string query = "SELECT COUNT(*) FROM tbDangNhap WHERE TenTK = '" + username + "' AND MatKhau = '" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);

            int count = (int)command.ExecuteScalar();
            command.ExecuteNonQuery();
            connection.Close();

            if (count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
