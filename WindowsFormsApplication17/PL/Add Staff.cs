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
    public partial class Add_Staff : Form
    {
        public Add_Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff s1 = new Staff();
            s1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            s1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Staff f1 = new Staff();
            f1.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
