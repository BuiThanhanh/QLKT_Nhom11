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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
            dgvsv.DataSource =
                DataAccess.GetTable("select * from tbSinhVien");

            dgvsv.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[5].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[6].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dgvsv.Columns[7].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgvsv.Columns[0].HeaderText = "Mã SV";
            dgvsv.Columns[1].HeaderText = "Tên SV";
            dgvsv.Columns[2].HeaderText = "Lớp";
            dgvsv.Columns[3].HeaderText = "Giới Tính";
            dgvsv.Columns[4].HeaderText = "Ngày Sinh";
            dgvsv.Columns[5].HeaderText = "Quê quán";
            dgvsv.Columns[6].HeaderText = "SĐT";
            dgvsv.Columns[7].HeaderText = "Mã phòng:";



        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "INSERT INTO tbSinhVien(MaSV, TenSV, Lop, GioiTinh,NgaySinh,QueQuan,SDT,Maphong) VALUES(@MaSV,@TenSV,@Lop,@GioiTinh,@NgaySinh,@QueQuan,@SDT,@Maphong)";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);

            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaSV", txtmasv.Text);
            cmd.Parameters.AddWithValue("@TenSV", txttensv.Text);
            cmd.Parameters.AddWithValue("@Lop", txtlop.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbgioitinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(time.Text));
            cmd.Parameters.AddWithValue("@QueQuan", txtquequan.Text);
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@MaPhong", txtmaphong.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();
           dgvsv.DataSource = DataAccess.GetTable("SELECT * FROM tbSinhVien");
            MessageBox.Show("Đã thêm bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection yourSqlConnection = DataAccess.TaoKetNoi();
            string sql = "UPDATE tbSinhVien SET TenSV = @TenSV, Lop = @Lop, GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,QueQuan = @QueQuan,SDT = @SDT,Maphong = @MaPhong WHERE MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);


            // Thêm các tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaSV", txtmasv.Text);
            cmd.Parameters.AddWithValue("@TenSV", txttensv.Text);
            cmd.Parameters.AddWithValue("@Lop", txtlop.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbgioitinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(time.Text));
            cmd.Parameters.AddWithValue("@QueQuan", txtquequan.Text);
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@MaPhong", txtmaphong.Text);

            // Mở kết nối, thực thi lệnh, và đóng kết nối
            yourSqlConnection.Open();
            cmd.ExecuteNonQuery();
            yourSqlConnection.Close();

            // Cập nhật DataGridView
            dgvsv.DataSource = DataAccess.GetTable("SELECT * FROM tbSinhVien");
            MessageBox.Show("Đã cập nhật bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvsv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsv.CurrentRow != null)
            {
                txtmasv.Text =
                    dgvsv.CurrentRow.Cells[0].Value.ToString();
                txttensv.Text =
                    dgvsv.CurrentRow.Cells[1].Value.ToString();
                txtlop.Text =
                    dgvsv.CurrentRow.Cells[2].Value.ToString();
                cbgioitinh.Text =
                    dgvsv.CurrentRow.Cells[3].Value.ToString();
                time.Text =
                    dgvsv.CurrentRow.Cells[4].Value.ToString();
                txtquequan.Text =
                    dgvsv.CurrentRow.Cells[5].Value.ToString();
                txtsdt.Text =
                    dgvsv.CurrentRow.Cells[6].Value.ToString();
                txtmaphong.Text =
                    dgvsv.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbSinhVien where MaSV=N'" +
                txtmasv.Text + "'";
            DataAccess.AddEditDelete(sql);

            dgvsv.DataSource =
               DataAccess.GetTable("select * from tbSinhVien");
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
            foreach (DataGridViewRow row in dgvsv.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString().Equals(searchValue))
                {

                    row.Selected = true;
                    dgvsv.CurrentCell = row.Cells[0];
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
