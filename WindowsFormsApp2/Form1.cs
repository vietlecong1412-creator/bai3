using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy họ tên
            string hoTen = textBox1.Text;

            // Lấy ngày sinh
            string ngaySinh = dateTimePicker1.Value.ToShortDateString();

            // Lấy giới tính
            string gioiTinh = "";
            if (radioButton1.Checked)
                gioiTinh = "Nam";
            else if (radioButton2.Checked)
                gioiTinh = "Nữ";

            // Lấy sở thích
            List<string> soThich = new List<string>();
            if (checkBox1.Checked) soThich.Add("Thể thao");
            if (checkBox2.Checked) soThich.Add("Phim ảnh");
            if (checkBox3.Checked) soThich.Add("Du lịch");

            string soThichStr = string.Join(", ", soThich);

            // Ghép thông tin
            string thongTin = $"Họ tên: {hoTen}\n" +
                              $"Ngày sinh: {ngaySinh}\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Sở thích: {soThichStr}";

            // Xuất ra hộp thoại
            MessageBox.Show(thongTin, "Thông tin cá nhân");
        }
    }
}
