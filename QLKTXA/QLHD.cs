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
    public partial class QLHD : Form
    {
        public QLHD()
        {
            InitializeComponent();
        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            dgvQLHD.DataSource =
     DataAccess.GetTable("select * from tbHopDong");

            dgvQLHD.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[5].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[6].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLHD.Columns[7].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgvQLHD.Columns[0].HeaderText = "Mã HĐ";
            dgvQLHD.Columns[1].HeaderText = "Mã SV";
            dgvQLHD.Columns[2].HeaderText = "Tên SV";
            dgvQLHD.Columns[3].HeaderText = "Mã Phòng";
            dgvQLHD.Columns[4].HeaderText = "Ngày Lạp";
            dgvQLHD.Columns[5].HeaderText = "Ngày BD";
            dgvQLHD.Columns[6].HeaderText = "Ngày KT";
            dgvQLHD.Columns[7].HeaderText = "Tiền Cọc";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbHopDong(MaHopDong,MaSV, TenSV,MaPhong, NgayLap, NgayBD,NgayKT,TienCoc) VALUES(@MaHopDong,@MaSV,@TenSV,@MaPhong,@NgayLap,@NgayBD,@NgayKT,@TienCoc)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaHopDong", txtmahd.Text);
            cmd.Parameters.AddWithValue("@MaSV", txtmasv.Text);
            cmd.Parameters.AddWithValue("@TenSV", txttensv.Text);
            cmd.Parameters.AddWithValue("@MaPhong", txtmaphong.Text);
            cmd.Parameters.AddWithValue("@NgayLap", DateTime.Parse(timelap.Text));
            cmd.Parameters.AddWithValue("@NgayBD", DateTime.Parse(timebd.Text));
            cmd.Parameters.AddWithValue("@NgayKT", DateTime.Parse(timekt.Text));
            cmd.Parameters.AddWithValue("@TienCoc", txttiencoc.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvQLHD.DataSource = DataAccess.GetTable("SELECT * FROM tbHopDong");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbHopDong SET MaSV = @MaSV, TenSV=@TenSV, NgayLap=@NgayLap, NgayBD=@NgayBD,NgayKT=@NgayKT,TienCoc=@TienCoc WHERE MaHopDong=@MaHopDong";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaHopDong", txtmahd.Text);
            cmd.Parameters.AddWithValue("@MaSV", txtmasv.Text);
            cmd.Parameters.AddWithValue("@TenSV", txttensv.Text);
            cmd.Parameters.AddWithValue("@NgayLap", DateTime.Parse(timelap.Text));
            cmd.Parameters.AddWithValue("@NgayBD", DateTime.Parse(timebd.Text));
            cmd.Parameters.AddWithValue("@NgayKT", DateTime.Parse(timekt.Text));
            cmd.Parameters.AddWithValue("@TienCoc", txttiencoc.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvQLHD.DataSource = DataAccess.GetTable("SELECT * FROM tbHopDong");
            MessageBox.Show("Đã  cập nhật bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvQLHD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLHD.CurrentRow != null)
            {
                txtmahd.Text =
                    dgvQLHD.CurrentRow.Cells[0].Value.ToString();
                txtmasv.Text =
                    dgvQLHD.CurrentRow.Cells[1].Value.ToString();
                txttensv.Text =
                    dgvQLHD.CurrentRow.Cells[2].Value.ToString();
                txtmaphong.Text =
                    dgvQLHD.CurrentRow.Cells[3].Value.ToString();
                timelap.Text =
                    dgvQLHD.CurrentRow.Cells[4].Value.ToString();
                timebd.Text =
                    dgvQLHD.CurrentRow.Cells[5].Value.ToString();
                timekt.Text =
                    dgvQLHD.CurrentRow.Cells[6].Value.ToString();
                txttiencoc.Text =
                    dgvQLHD.CurrentRow.Cells[7].Value.ToString();

            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập mã cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool found = false;
            foreach (DataGridViewRow row in dgvQLHD.Rows)
            {
                if (row.Cells["MaHopDong"].Value != null && row.Cells["MaHopDong"].Value.ToString().Equals(searchValue))
                {

                    row.Selected = true;
                    dgvQLHD.CurrentCell = row.Cells[0];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Không tìm thấy mã trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbHopDong where MaHopDong=N'" +
                txtmahd.Text + "'";
            DataAccess.AddEditDelete(sql);

            dgvQLHD.DataSource =
               DataAccess.GetTable("select * from tbHopDong");
            MessageBox.Show("Đã xóa bản ghi!", " Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
