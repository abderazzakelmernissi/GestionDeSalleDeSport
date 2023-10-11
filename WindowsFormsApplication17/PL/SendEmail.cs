using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApplication17.PL
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("abderrazzak.elmernissi@gmail.com");
            mail.To.Add(txtTo.Text);
            mail.Subject = txtSubject.Text;
            mail.Body = txtMessage.Text;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("abderrazzak.elmernissi", "Abdelrazzak.93");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("mail Send");

            //try
            //{
               /* SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(
                  "‫abderrazzak.elmernissi@gmail.com‬", "Abdelrazzak.93");
                MailMessage msg = new MailMessage();
                msg.To.Add(txtTo.Text);
                msg.From = new MailAddress("abderrazzak.elmernissi@gmail.com‬");
                msg.Subject = txtSubject.Text;
                msg.Body = txtMessage.Text;
                //Attachment data = new Attachment(textBox_Attachment.Text);
                //msg.Attachments.Add(data);
                client.Send(msg);
                MessageBox.Show("Successfully Sent Message."); */
           // }
            //catch (Exception ex)
           // {
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            members1 f1 = new members1();
            f1.Show();
            this.Close();
        }
    }
}
