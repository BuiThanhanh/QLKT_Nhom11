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
    public partial class CSVC : Form
    {
        public CSVC()
        {
            InitializeComponent();
        }

        private void CSVC_Load(object sender, EventArgs e)
        {
            dgvCSVC.DataSource =
    DataAccess.GetTable("select * from tbCSVC");

            dgvCSVC.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvCSVC.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvCSVC.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvCSVC.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;


            dgvCSVC.Columns[0].HeaderText = "TenCSVC";
            dgvCSVC.Columns[1].HeaderText = "LýDoPhatSinh";
            dgvCSVC.Columns[2].HeaderText = "NgayPhatSinh";
            dgvCSVC.Columns[3].HeaderText = "TienSua";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbCSVC(TenCSVC,LýDoPhatSinh, NgayPhatSinh, TienSua) VALUES(@TenCSVC,@LýDoPhatSinh,@NgayPhatSinh,@TienSua)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@TenCSVC", txttencsvc.Text);
            cmd.Parameters.AddWithValue("@LýDoPhatSinh", txttenlydo.Text);
            cmd.Parameters.AddWithValue("@NgayPhatSinh", DateTime.Parse(timephatsinh.Text));
            cmd.Parameters.AddWithValue("@TienSua", txttiensua.Text);


            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvCSVC.DataSource = DataAccess.GetTable("SELECT * FROM tbCSVC");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbCSVC SET TenCSVC = @TenCSVC, LýDoPhatSinh =@LýDoPhatSinh, NgayPhatSinh =@NgayPhatSinh, TienSua = @TienSua";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);


            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@TenCSVC", txttencsvc.Text);
            cmd.Parameters.AddWithValue("@LýDoPhatSinh", txttenlydo.Text);
            cmd.Parameters.AddWithValue("@NgayPhatSinh", DateTime.Parse(timephatsinh.Text));
            cmd.Parameters.AddWithValue("@TienSua", txttiensua.Text);



            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();

            // Cập nhật DataGridView
            dgvCSVC.DataSource = DataAccess.GetTable("SELECT * FROM tbCSVC");
            MessageBox.Show("Đã cập nhật bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbCSVC where TenCSVC = N'" +
     txttencsvc.Text + "'";
            DataAccess.AddEditDelete(sql);

            dgvCSVC.DataSource =
               DataAccess.GetTable("select * from tbCSVC");
            MessageBox.Show("Đã xóa bản ghi!", " Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCSVC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCSVC.CurrentRow != null)
            {
                txttencsvc.Text =
                    dgvCSVC.CurrentRow.Cells[0].Value.ToString();
                txttenlydo.Text =
                    dgvCSVC.CurrentRow.Cells[1].Value.ToString();
                timephatsinh.Text =
                    dgvCSVC.CurrentRow.Cells[2].Value.ToString();
                txttiensua.Text =
                    dgvCSVC.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
