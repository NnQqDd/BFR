using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IAmAMachine
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = DESKTOP-5A97KRU; Initial Catalog = QLGiaiBongDaN; Integrated Security = True";
            SqlDataAdapter ad = new SqlDataAdapter("select top 4 TenDoi,sum(SoLuongCT) as sl from DoiBong group by TenDoi",con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "TenDoi";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "tong so luong";
            chart1.Series["Series1"].XValueMember = "TenDoi";
            chart1.Series["Series1"].YValueMembers = "sl";
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Xóa lưới theo trục dọc (ngang)
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
