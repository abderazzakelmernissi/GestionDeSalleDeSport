using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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

        private void button5_Click(object sender, EventArgs e)
        {
            Entraineur E1 = new Entraineur();
            E1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staff f1 = new Staff();
            f1.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Members M1 = new Members();
            //M1.Show();
            //this.Hide();
            members1 M1 = new members1();
            M1.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Entraineur E1 = new Entraineur();
            E1.Show();
            this.Hide();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
            Groupes gr = new Groupes();
            gr.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PL.Event gr = new PL.Event();
            gr.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PL.Incom gr = new PL.Incom();
            gr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
