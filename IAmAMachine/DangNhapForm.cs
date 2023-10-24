using IAmAMachine.DAO;
using IAmAMachine.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IAmAMachine
{
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
            tenDangNhapTxt.Text = "Nhập tên người dùng";
            tenDangNhapTxt.ForeColor = Color.Silver;
            matKhauTxt.Text = "Nhập mật khẩu";
            matKhauTxt.ForeColor = Color.Silver;
            this.ActiveControl = null;
            List<DanhMucThuocDTO> trinh = DanhMucThuocDAO.Instance.GetAllDanhMucThuoc();
        }

        private void tenDangNhapTxt_Click(object sender, EventArgs e)
        {
            if (tenDangNhapTxt.Text.Trim() == "Nhập tên người dùng")
            {
                tenDangNhapTxt.Text = "";
                tenDangNhapTxt.ForeColor = Color.Black;
            }
        }

        private void tenDangNhapTxt_Leave(object sender, EventArgs e)
        {
            if(tenDangNhapTxt.Text.Trim() == "")
            {
                tenDangNhapTxt.Text = "Nhập tên người dùng";
                tenDangNhapTxt.ForeColor = Color.Silver;
            }
        }

        private void matKhauTxt_Click(object sender, EventArgs e)
        {
            matKhauTxt.Text = "";
            matKhauTxt.ForeColor = Color.Black;
        }

        private void xemMatKhauBtn_MouseHover(object sender, EventArgs e)
        {
            this.xemMatKhauBtn.Image = IAmAMachine.Properties.Resources.green_view;
            matKhauTxt.UseSystemPasswordChar = false;
        }

        private void xemMatKhauBtn_MouseLeave(object sender, EventArgs e)
        {
            this.xemMatKhauBtn.Image = IAmAMachine.Properties.Resources.green_hide;
            matKhauTxt.UseSystemPasswordChar = true;

        }
        private void quenMatKhauBtn_Click(object sender, EventArgs e)
        {
                NetworkCredential login = new NetworkCredential("quangduy162003@gmail.com", "ymzq ztfr jpll ukqb");
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = Convert.ToInt32("587");
                client.EnableSsl = true;
                client.Credentials = login;
                MailMessage msg = new MailMessage { From = new MailAddress("quangduy162003@gmail.com", "Quang Duy", Encoding.UTF8) };
                msg.To.Add(new MailAddress("duyclone2023@gmail.com"));
                //if (!string.IsNullOrEmpty(txtCC.Text))
                    //msg.To.Add(new MailAddress(txtCC.Text));
                msg.Subject = "HAHA";
                msg.Body = "LOL";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                //Send email async
                client.SendAsync(msg, userstate);


        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dangNhapBtn_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

