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
    public partial class members1 : Form
    {
        BL.Class_Member BL = new BL.Class_Member();
        public members1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddMember AD = new AddMember();
            AD.Show();
            this.Close();
        }

        private void members1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = BL.GetAllMember();
            label3.Text = label3.Text + " " + dataGridView1.Rows.Count.ToString();
            if (dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows[0].Selected = true;
                byte[] image = (byte[])BL.GetImageMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbRech_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= BL.RechMember(txbRech.Text);
            label3.Text = dataGridView1.Rows.Count.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print.AllMember PM = new Print.AllMember();
            Print.Form_Print FM = new Print.Form_Print();
            FM.crystalReportViewer1.ReportSource = PM;
            FM.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PL.SendEmail SM = new PL.SendEmail();
            SM.txtTo.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            SM.txtMessage.Text = "Bonjour " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            SM.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PL.SMS SM = new PL.SMS();
            SM.txtNum.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            SM.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // label4.Text = this.dataGridView1.SelectedRows[0].Index.ToString();
            byte[] image = (byte[])BL.GetImageMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddMember fm = new AddMember();

            
          // fm.txbID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
         
            fm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PL.Months M = new PL.Months();
            PL.Months.BB = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ;
            M.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Print.Print_Member PM = new Print.Print_Member();
            PM.SetParameterValue("@id", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Print.Form_Print FM = new Print.Form_Print();
            FM.crystalReportViewer1.ReportSource = PM;
            FM.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PL.Archive ar = new PL.Archive();
            ar.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult d =  MessageBox.Show("Voulez Archiver ce member??", "", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try{
                BL.ArchiverMember(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Ce Member a été Bien Archiver", "Bien", MessageBoxButtons.OK);
                }
            catch{
            MessageBox.Show("Selectioner un Member");
            }
            }
            dataGridView1.DataSource = BL.GetAllMember();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddMember fm = new AddMember();


         //fm.txbID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            fm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddMember fm = new AddMember();


            //fm.txbID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            fm.Show();
            this.Close();
        }
    }
}
