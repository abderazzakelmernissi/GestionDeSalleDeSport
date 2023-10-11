using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17.PL
{
    public partial class Event : Form
    {
        BL.Class_Event cle = new BL.Class_Event();

        public void remplisage() {
            dataGridView1.DataSource = cle.GetAllEvent();
        }

        public Event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cle.delete_event(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            remplisage();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cle.update_event(textBox1.Text, dateTimePicker1.Value, textBox2.Text,int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            remplisage();
        }
        
        private void btnAjout_Click(object sender, EventArgs e)
        {
            cle.Insert_Event(textBox1.Text, dateTimePicker1.Value, textBox2.Text);
            remplisage();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            remplisage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
