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
    
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
           
            InitializeComponent();
           
        }

        private void themMoi_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            
            f.Show();
        }
        public void AddDataItem(ListViewItem item)
        {
            listView1.Items.Add(item);
        }
        public ListView DataListView
        {
            get { return listView1; }
        }

        // Các phương thức hoặc thuộc tính khác trong UserControl
    }
}
