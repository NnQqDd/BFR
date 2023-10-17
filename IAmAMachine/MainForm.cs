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
        public MainForm()
        {

            InitializeComponent();

            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            this.Controls.Add(userControl1);
            this.Controls.Add(userControl2);
            userControl2.Left = sidePanel.ClientSize.Width;
            userControl1.Left = sidePanel.Width;
            userControl1.Top = sidePanel.Top;
            userControl2.Top = sidePanel.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            userControl1.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Height = button2.Height;
            panel1.Top = button2.Top;
            userControl2.BringToFront();
        }
    }
}
