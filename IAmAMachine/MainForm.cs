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
    public partial class MainForm : Form
    {
        UserControl1 userControl1 = new UserControl1();
        UserControl2 userControl2 = new UserControl2();
        UserControl3 userControl3 = new UserControl3();
        UserControl4 userControl4 = new UserControl4();
        public MainForm()
        {

            InitializeComponent();

            panel1.Height = btnTonKho.Height;
            panel1.Top = btnTonKho.Top;
            this.Controls.Add(userControl1);
            this.Controls.Add(userControl2);
            this.Controls.Add(userControl3);
            this.Controls.Add(userControl4);
            userControl2.Left = sidePanel.ClientSize.Width;
            userControl1.Left = sidePanel.Width;
            userControl1.Top = sidePanel.Top;
            userControl2.Top = sidePanel.Top;
            userControl3.Left = sidePanel.Width;
            userControl3.Top = sidePanel.Top;
            userControl4.Left = sidePanel.Width;
            userControl4.Top = sidePanel.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = btnTonKho.Height;
            panel1.Top = btnTonKho.Top;
            userControl1.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Height = btnNhaCungCap.Height;
            panel1.Top = btnNhaCungCap.Top;
            userControl2.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDieuChuyenKho_Click(object sender, EventArgs e)
        {
            panel1.Height = btnTonKho.Height;
            panel1.Top = btnTonKho.Top;
            userControl3.BringToFront();
        }

        private void btnDieuChinhTon_Click(object sender, EventArgs e)
        {
            panel1.Height = btnTonKho.Height;
            panel1.Top = btnTonKho.Top;
            userControl4.BringToFront();
        }
    }
}
