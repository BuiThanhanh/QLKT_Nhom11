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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLKTXA
{
    public partial class QLPhong : Form
    {
        public QLPhong()
        {
            InitializeComponent();
        }

        

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbPhong(MaPhong,LoaiPhong,SVHienTai,SVToiDa) VALUES(@MaPhong,@LoaiPhong,@SVHienTai,@SVToiDa)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaPhong", txtmaphong.Text);
            cmd.Parameters.AddWithValue("@LoaiPhong", cbloai.Text);
            cmd.Parameters.AddWithValue("@SVHienTai", txtsvht.Text);
            cmd.Parameters.AddWithValue("@SVToiDa", txtsvtd.Text);
           

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvphong.DataSource = DataAccess.GetTable("SELECT * FROM tbPhong");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
           dgvphong.DataSource =
                DataAccess.GetTable("select * from tbPhong");

           dgvphong.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
           dgvphong.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
           dgvphong.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
           dgvphong.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
          

           dgvphong.Columns[0].HeaderText = "Mã Phòng";
           dgvphong.Columns[1].HeaderText = "Loại Phòng";
           dgvphong.Columns[2].HeaderText = "SV Hiện Tại";
           dgvphong.Columns[3].HeaderText = "SV Tối Đa";
          
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbPhong SET LoaiPhong = @LoaiPhong, SVHienTai = @SVHienTai, SVToiDa = @SVToiDa WHERE MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            cmd.Parameters.AddWithValue("@MaPhong", txtmaphong.Text);
            cmd.Parameters.AddWithValue("@LoaiPhong", cbloai.Text);
            cmd.Parameters.AddWithValue("@SVHienTai", txtsvht.Text);
            cmd.Parameters.AddWithValue("@SVToiDa", txtsvtd.Text);

            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();

            // Cập nhật DataGridView
           dgvphong.DataSource = DataAccess.GetTable("SELECT * FROM tbPhong");
            MessageBox.Show("Đã cập nhật bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbPhong where MaPhong=N'" +
                txtmaphong.Text + "'";
            DataAccess.AddEditDelete(sql);

           dgvphong.DataSource =
               DataAccess.GetTable("select * from tbPhong");
            MessageBox.Show("Đã xóa bản ghi!", " Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvphong_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvphong.CurrentRow != null)
            {
                txtmaphong.Text =
                   dgvphong.CurrentRow.Cells[0].Value.ToString();
                cbloai.Text =
                   dgvphong.CurrentRow.Cells[1].Value.ToString();
                txtsvht.Text =
                   dgvphong.CurrentRow.Cells[2].Value.ToString();
                txtsvtd.Text =
                   dgvphong.CurrentRow.Cells[3].Value.ToString();
               
            }
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
            foreach (DataGridViewRow row in dgvphong.Rows)
            {
                if (row.Cells["MaPhong"].Value != null && row.Cells["MaPhong"].Value.ToString().Equals(searchValue))
                {

                    row.Selected = true;
                   dgvphong.CurrentCell = row.Cells[0];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Không tìm thấy mã trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
