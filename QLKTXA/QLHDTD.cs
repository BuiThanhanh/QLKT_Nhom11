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
    public partial class QLHDTD : Form
    {
        public QLHDTD()
        {
            InitializeComponent();
        }

        

        private void QLHDTD_Load(object sender, EventArgs e)
        {

            dgvhdtd.DataSource =
                DataAccess.GetTable("select * from tbHoaDonTienDien");

            dgvhdtd.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[5].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[6].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvhdtd.Columns[7].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgvhdtd.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvhdtd.Columns[1].HeaderText = "Ngày Lập";
            dgvhdtd.Columns[2].HeaderText = "Số Điện";
            dgvhdtd.Columns[3].HeaderText = "Gía Điện";
            dgvhdtd.Columns[4].HeaderText = "Số Nước";
            dgvhdtd.Columns[5].HeaderText = "Giá Nước";
            dgvhdtd.Columns[6].HeaderText = "Tổng tiền";
            dgvhdtd.Columns[7].HeaderText = "Tình trạng đóng";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbHoaDonTienDien(MaHoaDon, NgayLapHoaDon, SoDien, GiaDien, SoNuoc,GiaNuoc,TongTien,TinhTrangDong) VALUES(@MaHoaDon, @NgayLapHoaDon, @SoDien, @GiaDien, @SoNuoc,@GiaNuoc,@TongTien,@TinhTrangDong)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaHoaDon", txtmahd.Text);
            cmd.Parameters.AddWithValue("@NgayLapHoaDon", DateTime.Parse(timelap.Text));
            cmd.Parameters.AddWithValue("@SoDien", txtsodien.Text);
            cmd.Parameters.AddWithValue("@GiaDien", txtgiadien.Text);
            cmd.Parameters.AddWithValue("@SoNuoc", txtsonuoc.Text);
            cmd.Parameters.AddWithValue("@GiaNuoc", txtgianuoc.Text);
            cmd.Parameters.AddWithValue("@TongTien", txttien.Text);
            cmd.Parameters.AddWithValue("@TinhTrangDong", txttinhtrang.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvhdtd.DataSource = DataAccess.GetTable("SELECT * FROM tbHoaDonTienDien");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbHoaDonTienDien SET NgayLapHoaDon = @NgayLapHoaDon, SoDien=@SoDien, GiaDien=@GiaDien, SoNuoc=@SoNuoc,GiaNuoc=@GiaNuoc,TongTien=@TongTien,TinhTrangDong=@TinhTrangDong WHERE MaHoaDon = @MaHoaDon";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);


            cmd.Parameters.AddWithValue("@MaHoaDon", txtmahd.Text);
            cmd.Parameters.AddWithValue("@NgayLapHoaDon", DateTime.Parse(timelap.Text));
            cmd.Parameters.AddWithValue("@SoDien", txtsodien.Text);
            cmd.Parameters.AddWithValue("@GiaDien", txtgiadien.Text);
            cmd.Parameters.AddWithValue("@SoNuoc", txtsonuoc.Text);
            cmd.Parameters.AddWithValue("@GiaNuoc", txtgianuoc.Text);
            cmd.Parameters.AddWithValue("@TongTien", txttien.Text);
            cmd.Parameters.AddWithValue("@TinhTrangDong", txttinhtrang.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();

            // Cập nhật DataGridView
            dgvhdtd.DataSource = DataAccess.GetTable("SELECT * FROM tbHoaDonTienDien");
            MessageBox.Show("Đã cập nhật bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvhdtd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhdtd.CurrentRow != null)
            {
                txtmahd.Text =
                    dgvhdtd.CurrentRow.Cells[0].Value.ToString();
                timelap.Text =
                    dgvhdtd.CurrentRow.Cells[1].Value.ToString();
                txtsodien.Text =
                    dgvhdtd.CurrentRow.Cells[2].Value.ToString();
                txtgiadien.Text =
                    dgvhdtd.CurrentRow.Cells[3].Value.ToString();
                txtsonuoc.Text =
                    dgvhdtd.CurrentRow.Cells[4].Value.ToString();
                txtgianuoc.Text =
                    dgvhdtd.CurrentRow.Cells[5].Value.ToString();
                txttien.Text =
                    dgvhdtd.CurrentRow.Cells[6].Value.ToString();
                txttinhtrang.Text =
                    dgvhdtd.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbHoaDonTienDien where MaHoaDon=N'" +
               txtmahd.Text + "'";
            DataAccess.AddEditDelete(sql);

            dgvhdtd.DataSource =
               DataAccess.GetTable("select * from tbHoaDonTienDien");
            MessageBox.Show("Đã xóa bản ghi!", " Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập mã cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool found = false;
            foreach (DataGridViewRow row in dgvhdtd.Rows)
            {
                if (row.Cells["MaHoaDon"].Value != null && row.Cells["MaHoaDon"].Value.ToString().Equals(searchValue))
                {

                    row.Selected = true;
                    dgvhdtd.CurrentCell = row.Cells[0];
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
