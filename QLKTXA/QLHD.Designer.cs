﻿namespace QLKTXA
{
    partial class QLHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHD));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvQLHD = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttiencoc = new System.Windows.Forms.TextBox();
            this.timekt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.timebd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.timelap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvQLHD);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1040, 252);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Mục Hợp Đồng: ";
            // 
            // dgvQLHD
            // 
            this.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLHD.Location = new System.Drawing.Point(19, 38);
            this.dgvQLHD.Name = "dgvQLHD";
            this.dgvQLHD.RowHeadersWidth = 51;
            this.dgvQLHD.RowTemplate.Height = 24;
            this.dgvQLHD.Size = new System.Drawing.Size(1000, 192);
            this.dgvQLHD.TabIndex = 0;
            this.dgvQLHD.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLHD_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(694, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 274);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(52, 88);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(155, 27);
            this.txttimkiem.TabIndex = 3;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(37, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "    Tìm kiếm:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttiencoc);
            this.groupBox1.Controls.Add(this.timekt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.timebd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmahd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.timelap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 289);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hợp Đồng ";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(117, 190);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(159, 27);
            this.txtmaphong.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mã Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tiền cọc:";
            // 
            // txttiencoc
            // 
            this.txttiencoc.Location = new System.Drawing.Point(403, 190);
            this.txttiencoc.Name = "txttiencoc";
            this.txttiencoc.Size = new System.Drawing.Size(159, 27);
            this.txttiencoc.TabIndex = 27;
            // 
            // timekt
            // 
            this.timekt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timekt.Location = new System.Drawing.Point(403, 135);
            this.timekt.Name = "timekt";
            this.timekt.Size = new System.Drawing.Size(159, 27);
            this.timekt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ngày KT:";
            // 
            // timebd
            // 
            this.timebd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timebd.Location = new System.Drawing.Point(403, 81);
            this.timebd.Name = "timebd";
            this.timebd.Size = new System.Drawing.Size(159, 27);
            this.timebd.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày BĐ:";
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(117, 138);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(159, 27);
            this.txttensv.TabIndex = 21;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(447, 239);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 30);
            this.btnthoat.TabIndex = 20;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(305, 239);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(177, 239);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 30);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(52, 239);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 30);
            this.btnthem.TabIndex = 17;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hđ:";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(117, 30);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(159, 27);
            this.txtmahd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sv:";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(117, 81);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(159, 27);
            this.txtmasv.TabIndex = 6;
            // 
            // timelap
            // 
            this.timelap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timelap.Location = new System.Drawing.Point(403, 27);
            this.timelap.Name = "timelap";
            this.timelap.Size = new System.Drawing.Size(159, 27);
            this.timelap.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên sv:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày lập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản Lý Hợp Đồng ";
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1107, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QLHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLHD";
            this.Load += new System.EventHandler(this.QLHD_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvQLHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.DateTimePicker timelap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttiencoc;
        private System.Windows.Forms.DateTimePicker timekt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timebd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label9;
    }
}