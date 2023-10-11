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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
             
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            BL.C_LOGIN LG = new BL.C_LOGIN();

            DataTable DT = LG.LOGIN(txtLogin.Text, txtPass.Text);

            if(DT.Rows.Count>0)
            {
                Form1 H1 = new Form1();
                //F_Home H1 = new F_Home();
                H1.Show();
            }
            else { MessageBox.Show("Error", "Error login", MessageBoxButtons.OK);
            txtLogin.Clear();
            txtPass.Clear();
            }

            
            
        

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

         
    }
}
