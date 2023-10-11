using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication17.PL
{
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }
        SerialPort sp;
        private void btnSend_Click(object sender, EventArgs e)
        {
            
            string x = txtNum.Text;
            string f = txtMessage.Text;
           
             sp = new SerialPort();
             sp.PortName = txtCOM.Text;
            
            sp.ReadTimeout = 2000;

            sp.Open();

            sp.Write("AT\r");

            sp.Write("AT+CMGF=1\r");

            System.Threading.Thread.Sleep(1500);

            sp.Write("AT+CMGS=\"" +txtNum.Text + "\"\r\n");

            System.Threading.Thread.Sleep(1500);

            sp.Write(txtMessage.Text + "\x1A");

            MessageBox.Show("sent");

            sp.Close();



        }

        private void SMS_Load(object sender, EventArgs e)
        {
            //sp = new SerialPort();
            //sp.PortName = "COM3";
            //sp.BaudRate = 9600;
            //sp.Parity = Parity.None;
            //sp.DataBits = 8;
            //sp.StopBits = StopBits.One;
            //sp.ReadTimeout = 3000;
            //sp.WriteTimeout = 3000;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            members1 f1 = new members1();
            f1.Show();
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
