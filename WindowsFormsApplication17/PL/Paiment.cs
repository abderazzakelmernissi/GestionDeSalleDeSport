using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication17
{
    public partial class Groupes : Form
    {
        BL.Class_Member bl = new BL.Class_Member();
        BL.MemberShip clm = new BL.MemberShip();
        public static int AA;
        public Groupes()
        {
            InitializeComponent();
            cmbMois.Items.Add("Janvier");
            cmbMois.Items.Add("février ");
            cmbMois.Items.Add("Mars");
            cmbMois.Items.Add("Avril");
            cmbMois.Items.Add("Mai");
            cmbMois.Items.Add("juin");
            cmbMois.Items.Add("juillet");
            cmbMois.Items.Add("août");
            cmbMois.Items.Add("septembre");
            cmbMois.Items.Add("octobre");
            cmbMois.Items.Add("novembre");
            cmbMois.Items.Add("décembre");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddGroup ad = new AddGroup();
            ad.Show();
            this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
          
        }

        private void Groupes_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource =  bl.GetAllMember();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txbNom.Text = dataGridView1.CurrentRow.Cells[1].ToString();
           // txbPrenom.Text = dataGridView1.CurrentRow.Cells[2].ToString();
            
           AA = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txbIDM.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txbNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbPrenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            byte[] image = (byte[])bl.GetImageMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void txbRech_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl.RechMember(txbRech.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //int b = cmbMois.SelectedIndex;
            clm.Update_Month(a, cmbMois.SelectedIndex +1);
            //MessageBox.Show("le mois bien ajouter", "Bien", MessageBoxButtons.OK);

            //label9.Text = cmbMois.SelectedItem. ;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
          int m= int.Parse(DateTime.Now.Month.ToString());
            dataGridView1.DataSource= clm.GetNomPaye(m);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int m = int.Parse(DateTime.Now.Month.ToString());
            dataGridView1.DataSource = clm.GetNomPaye(m);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PL.Months M = new PL.Months();
            PL.Months.BB = AA;
            M.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PL.SMS SM = new PL.SMS();
            SM.txtNum.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            SM.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PL.SendEmail SM = new PL.SendEmail();
            SM.txtTo.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            SM.txtMessage.Text = "Bonjour " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            SM.Show();
        }
    }
}
