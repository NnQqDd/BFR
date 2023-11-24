using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace IAmAMachine
{
    public partial class FormDS : Form
    {
        DSNhanVIen dSNhanVIen = new DSNhanVIen();
        DSKhachHang dSKhachHang = new DSKhachHang();
        DSThuoc dDSThuoc = new DSThuoc();
        DSCongDung dDSCongDung = new DSCongDung();
        DSThanhPhan dSThanhPhan = new DSThanhPhan();
        public FormDS()
        {
            InitializeComponent();
            
            panel1.Height = btndsNV.Height;
            panel1.Top = btndsNV.Top;
            this.Controls.Add(dSNhanVIen);
            this.Controls.Add(dSKhachHang);
            this.Controls.Add(dDSThuoc);
            this.Controls.Add(dSThanhPhan);
            this.Controls.Add(dDSCongDung);
            dSNhanVIen.Left = sidePanel.ClientSize.Width;
            dSNhanVIen.Top = sidePanel.Top;
            dSKhachHang.Left = sidePanel.ClientSize.Width;
            dSKhachHang.Top = sidePanel.Top;
            dDSThuoc.Left = sidePanel.ClientSize.Width;
            dDSThuoc.Top = sidePanel.Top;
            dDSCongDung.Left = sidePanel.ClientSize.Width;
            dDSCongDung.Top = sidePanel.Top;
            dSThanhPhan.Left = sidePanel.ClientSize.Width;
            dSThanhPhan.Top = sidePanel.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = btndsNV.Height;
            panel1.Top = btndsNV.Top;
            dSNhanVIen.BringToFront();
        }

        private void btndsKH_Click(object sender, EventArgs e)
        {
            panel1.Height = btndsNV.Height;
            panel1.Top = btndsNV.Top;
            dSKhachHang.BringToFront();
        }

        private void btndsT_Click(object sender, EventArgs e)
        {
            panel1.Height = btndsNV.Height;
            panel1.Top = btndsNV.Top;
            dDSThuoc.BringToFront();
        }

        private void btndsCD_Click(object sender, EventArgs e)
        {
            panel1.Height = btndsNV.Height;
            panel1.Top = btndsNV.Top;
            dDSCongDung.BringToFront();
        }

        private void btndsTP_Click(object sender, EventArgs e)
        {
            panel1.Height = btndsNV.Height;
            panel1.Top = btndsNV.Top;
            dSThanhPhan.BringToFront();
        }
    }
}
