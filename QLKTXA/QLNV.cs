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
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            dgvnv.DataSource =
                DataAccess.GetTable("select * from tbNhanVien");

            dgvnv.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvnv.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvnv.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvnv.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvnv.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvnv.Columns[5].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvnv.Columns[6].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
           
            dgvnv.Columns[0].HeaderText = "Mã NV";
            dgvnv.Columns[1].HeaderText = "Tên NV";
            dgvnv.Columns[2].HeaderText = "Giới Tính";
            dgvnv.Columns[3].HeaderText = "Ngày Sinh";
            dgvnv.Columns[4].HeaderText = "SĐT";
            dgvnv.Columns[5].HeaderText = "Quê quán";
            dgvnv.Columns[6].HeaderText = "Hệ Số Lương";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbNhanVien(MaNV, TenNV,GioiTinh,NgaySinh,SDT,QueQuan,HeSoLuong) VALUES(@MaSV,@TenSV,@GioiTinh,@NgaySinh,@SDT,@QueQuan,@HeSoLuong)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("@TenNV", txttennv.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbgioitinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(time.Text));
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@QueQuan", txtquequan.Text);
            cmd.Parameters.AddWithValue("@HeSoLuong", txthsl.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvnv.DataSource = DataAccess.GetTable("SELECT * FROM tbNhanVien");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbNhanVien SET TenNV = @TenNV, GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,SDT = @SDT,QueQuan = @QueQuan,HeSoLuong = @HeSoLuong WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("@TenNV", txttennv.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbgioitinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(time.Text));
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@QueQuan", txtquequan.Text);
            cmd.Parameters.AddWithValue("@HeSoLuong", txthsl.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
            dgvnv.DataSource = DataAccess.GetTable("SELECT * FROM tbNhanVien");
            MessageBox.Show("Đã sửa bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvnv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvnv.CurrentRow != null)
            {
                txtmanv.Text =
                    dgvnv.CurrentRow.Cells[0].Value.ToString();
                txttennv.Text =
                    dgvnv.CurrentRow.Cells[1].Value.ToString();
                cbgioitinh.Text =
                    dgvnv.CurrentRow.Cells[2].Value.ToString();
                time.Text =
                    dgvnv.CurrentRow.Cells[3].Value.ToString();
                txtsdt.Text =
                    dgvnv.CurrentRow.Cells[5].Value.ToString();
                txtquequan.Text =
                    dgvnv.CurrentRow.Cells[4].Value.ToString();
                txthsl.Text =
                    dgvnv.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbNhanVien where MaNV=N'" +
                txtmanv.Text + "'";
            DataAccess.AddEditDelete(sql);

            dgvnv.DataSource =
               DataAccess.GetTable("select * from tbNhanVien");
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
            foreach (DataGridViewRow row in dgvnv.Rows)
            {
                if (row.Cells["MaNV"].Value != null && row.Cells["MaNV"].Value.ToString().Equals(searchValue))
                {

                    row.Selected = true;
                    dgvnv.CurrentCell = row.Cells[0];
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
