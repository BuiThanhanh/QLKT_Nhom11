using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTXA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        private void btnqlsv_Click(object sender, EventArgs e)
        {
            QLSV sv = new QLSV();
            this.Hide();
            sv.ShowDialog();
            this.Show();
        }

        private void btnqlnv_Click(object sender, EventArgs e)
        {
            QLNV nv = new QLNV();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void btnqlphong_Click(object sender, EventArgs e)
        {
            QLPhong p = new QLPhong();
            this.Hide();
            p.ShowDialog();
            this.Show();

        }

        private void btnqlhoadon_Click(object sender, EventArgs e)
        {
            QLHDTD hd = new QLHDTD();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void btnquanlykyluat_Click(object sender, EventArgs e)
        {
            QLKL kl = new QLKL();
            this.Hide();
            kl.ShowDialog();
            this.Show();
        }

        private void btnqlhopdong_Click(object sender, EventArgs e)
        {
            QLHD hdtd = new QLHD();
            this.Hide();
            hdtd.ShowDialog();
            this.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
