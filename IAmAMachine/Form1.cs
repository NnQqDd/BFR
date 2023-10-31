using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAmAMachine
{
    public partial class Form1 : Form
    {
        private int Stt = 0;
        private int tongtien = 0;
        UserControl1 userControl1 = new UserControl1();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float a = 0.0f;
            float soLuong = 0.0f;
            float giaNhap = 0.0f;
            int giaban = 0;
            if (float.TryParse(txtSoLuong.Text, out soLuong) && float.TryParse(txtGiaNhap.Text, out giaNhap))
            {
                a = soLuong * giaNhap;
            }
            ListViewItem item = new ListViewItem();
      
            item.Text = Stt.ToString();
            Stt++;
            item.SubItems.Add(txtTHuoc.Text);
            item.SubItems.Add(cbDonvi.Text);
            item.SubItems.Add(txtSoLuong.Text);
            item.SubItems.Add(txtGiaNhap.Text);
            item.SubItems.Add(a.ToString());
            item.SubItems.Add(txtSoLo.Text);
            item.SubItems.Add(dtHanDung.Text);
            item.SubItems.Add(txtGiaBan.Text);
            
            tongtien = tongtien + (int)a;
            listView1.Items.Add(item);
            txtTongTienHang.Text=tongtien.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int giaban = 0;
            // Lấy chỉ mục dòng đầu tiên được chọn
            int indexToRemove = listView1.SelectedIndices[0];
            if (int.TryParse(listView1.Items[indexToRemove].SubItems[5].Text, out giaban))
            {
                // Trừ giá bán ra khỏi tổng tiền
                tongtien -= giaban;
            }
            // Xóa mục được chọn
            listView1.Items.RemoveAt(indexToRemove);
            
            
            txtTongTienHang.Text = tongtien.ToString();
            // Cập nhật lại số thứ tự (STT)
            for (int i = indexToRemove; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Text = (i).ToString();
            }
        }

        private void txtTongTienHang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float soLo = 0;
            float a = 0;
            if (float.TryParse(txtSoLo.Text, out soLo))
            {
                a = soLo * tongtien;
            }

            // Tạo một đối tượng dữ liệu mới dựa trên giá trị nhập từ Form
            ListViewItem item = new ListViewItem();
            item.Text = Stt.ToString();
            Stt++;
            item.SubItems.Add(txtSoPhieuNhap.Text);
            item.SubItems.Add(dtNgayNhap.Text);
            item.SubItems.Add(tongtien.ToString());
            item.SubItems.Add(a.ToString());
            item.SubItems.Add("NO");

            // Truy cập vào UserControl và thêm đối tượng dữ liệu vào ListView
            userControl1.AddDataItem(item);

            this.Close();
        }
        private string GenerateRandomReceiptNumber()
        {
            // Định dạng số phiếu nhập cố định
            string prefix = "PN";
            int randomDigits = 5; // Số chữ số ngẫu nhiên

            // Tạo số phiếu nhập ngẫu nhiên
            Random random = new Random();
            string randomNumber = random.Next(0, (int)Math.Pow(10, randomDigits)).ToString("D" + randomDigits);

            // Kết hợp định dạng số phiếu nhập và số ngẫu nhiên
            string receiptNumber = prefix + randomNumber;

            return receiptNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoPhieuNhap.Text = GenerateRandomReceiptNumber();
        }
    }

}
