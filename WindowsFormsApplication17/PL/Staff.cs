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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // panel3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Staff AS = new Add_Staff();
            AS.Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();   
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Add_Staff ad = new Add_Staff();
            ad.Show();
            this.Close();
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

        private void Staff_Load(object sender, EventArgs e)
        {
            cmbFonction.Items.Add("Admin");
            cmbFonction.Items.Add("Staff");
            cmbFonction.SelectedIndex = 0;
        }

        private void BtnRegestrer_Click(object sender, EventArgs e)
        {
            BL.C_LOGIN Bl = new BL.C_LOGIN();
            try
            {
                Bl.AddUser(txtUser.Text, txtPass.Text, cmbFonction.SelectedItem.ToString());
                MessageBox.Show("Ajout bien effectee");
            }
            catch {
                MessageBox.Show("Error D'Ajoute");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PL.BackupBD bu = new PL.BackupBD();
            bu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.RestoreBD bu = new PL.RestoreBD();
            bu.Show();
        }
    }
}
