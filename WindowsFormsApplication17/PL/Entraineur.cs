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
    public partial class Entraineur : Form
    {
        BL.Class_Entraineur1 Bl = new BL.Class_Entraineur1();
        public Entraineur()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTrainor A1 = new AddTrainor();
            A1.Show();
            this.Hide();
        }


       // ToolTip t1 = new ToolTip();
        private void button7_MouseHover(object sender, EventArgs e)
        {
           // t1.Show("Save",button7);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
      //  ToolTip t2 = new ToolTip();
        private void button8_MouseHover(object sender, EventArgs e)
        {
          //  t2.Show("Print", button8);
        }

        private void Entraineur_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Bl.GetAllEntraineur();

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                label3.Text = dataGridView1.Rows.Count.ToString();
                if (dataGridView1.Rows.Count > 0)
                {
                    this.dataGridView1.Rows[0].Selected = true;
                    byte[] image = (byte[])Bl.GetImageEntraineur(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddTrainor AT = new AddTrainor();
            AT.Show();
            this.Close();
        }

        private void txbNom_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bl.RechEntraineur(txbNom.Text);
            label3.Text = dataGridView1.Rows.Count.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PL.SendEmail SM = new PL.SendEmail();
            SM.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PL.SMS SM = new PL.SMS();
            SM.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] image = (byte[])Bl.GetImageEntraineur(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
        }

        
    }
}
