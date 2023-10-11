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
namespace WindowsFormsApplication17.PL
{
    public partial class Archive : Form
    {
        BL.Class_Member BL = new BL.Class_Member();
        public Archive()
        {
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = BL.GetAllMemberArchiver();
            label3.Text = label3.Text + " " + dataGridView1.Rows.Count.ToString();
        }

        private void txbRech_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.RechMember(txbRech.Text);
            label3.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = this.dataGridView1.SelectedRows[0].Index.ToString();
            byte[] image = (byte[])BL.GetImageMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BL.ReArchiverMember(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show("ce member Bien Rendre a la liste des member","Bien",MessageBoxButtons.OK);

            dataGridView1.DataSource = BL.GetAllMemberArchiver();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            members1 f1 = new members1();
            f1.Show();
            this.Close();
        }
    }
}
