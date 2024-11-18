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
    public partial class QLKL : Form
    {
        public QLKL()
        {
            InitializeComponent();
        }

        private void QLKL_Load(object sender, EventArgs e)
        {

            dgvkl.DataSource =
                DataAccess.GetTable("select * from tbKyLuat");

            dgvkl.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvkl.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvkl.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvkl.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgvkl.Columns[0].HeaderText = "Mã KL";
            dgvkl.Columns[1].HeaderText = "Mã SV";
            dgvkl.Columns[2].HeaderText = "Kỷ Luật";
            dgvkl.Columns[3].HeaderText = "Ngày Sinh";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbKyLuat(MaKL,MaSV,KyLuat,NgayKL) VALUES(@MaKL,@MaSV,@KyLuat,@NgayKL)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaKL", txtmakl.Text);
            cmd.Parameters.AddWithValue("@MaSV", txtmasv.Text);
            cmd.Parameters.AddWithValue("@KyLuat", txtkyluat.Text);
            cmd.Parameters.AddWithValue("@NgayKL", DateTime.Parse(time.Text));


            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvkl.DataSource = DataAccess.GetTable("SELECT * FROM tbKyLuat");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbKyLuat SET MaSV=@MaSV,KyLuat=@KyLuat,NgayKL=@NgayKL  WHERE MaKL = @MaKL";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaKL", txtmakl.Text);
            cmd.Parameters.AddWithValue("@MaSV", txtmasv.Text);
            cmd.Parameters.AddWithValue("@KyLuat", txtkyluat.Text);
            cmd.Parameters.AddWithValue("@NgayKL", DateTime.Parse(time.Text));

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvkl.DataSource = DataAccess.GetTable("SELECT * FROM tbKyLuat");
            MessageBox.Show("Đã sửa bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvkl_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvkl.CurrentRow != null)
            {
                txtmakl.Text =
                    dgvkl.CurrentRow.Cells[0].Value.ToString();
                txtmasv.Text =
                    dgvkl.CurrentRow.Cells[1].Value.ToString();
                txtkyluat.Text =
                    dgvkl.CurrentRow.Cells[2].Value.ToString();
                time.Text =
                    dgvkl.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbKyLuat where MaKL=N'" +
               txtmakl.Text + "'";
            DataAccess.AddEditDelete(sql);

            dgvkl.DataSource =
               DataAccess.GetTable("select * from tbKyLuat");
            MessageBox.Show("Đã xóa bản ghi!", " Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập mã cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool found = false;
            foreach (DataGridViewRow row in dgvkl.Rows)
            {
                if (row.Cells["MaKL"].Value != null && row.Cells["MaKL"].Value.ToString().Equals(searchValue))
                {

                    row.Selected = true;
                    dgvkl.CurrentCell = row.Cells[0];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Không tìm thấy mã trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    }

    

