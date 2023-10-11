using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication17.PL
{
    public partial class Incom : Form
    {
        public Incom()
        {
            InitializeComponent();
        }
        public static int t;
        private void Incom_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Jan");
            comboBox1.Items.Add("Feb");
            comboBox1.Items.Add("Mar");
            comboBox1.Items.Add("Apr");
            comboBox1.Items.Add("May");
            comboBox1.Items.Add("Jun");
            comboBox1.Items.Add("Jul");
            comboBox1.Items.Add("Aug");
            comboBox1.Items.Add("Sep");
            comboBox1.Items.Add("Oct");
            comboBox1.Items.Add("Nov");
            comboBox1.Items.Add("Dece");

            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
            textBox5.Text = "00";
            textBox6.Text = "00";


           dataGridView2.Rows[0].Cells[0].Value = "hjkhk";
            dataGridView2.Rows.Add();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = t;
            x -= (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) +
                int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text));

            label8.Text ="Total "+ x.ToString() + " DHs";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataReader dr;

            SqlConnection cn = new SqlConnection("Data Source=USER6EB4;Initial Catalog=GGYM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            string x = comboBox1.SelectedItem.ToString();
            switch (x)
            {
                case "Jan": cmd.CommandText = "select count(*) from mois where Jan= 1"; break;
                case "Feb": cmd.CommandText = "select count(*) from mois where Feb= 1"; break;
                case "Mar": cmd.CommandText = "select count(*) from mois where Mar= 1"; break;
                case "Apr": cmd.CommandText = "select count(*) from mois where Apr= 1"; break;
                case "May": cmd.CommandText = "select count(*) from mois where May= 1"; break;
                case "Jun": cmd.CommandText = "select count(*) from mois where Jun= 1"; break;
                case "Jul": cmd.CommandText = "select count(*) from mois where Jul= 1"; break;
                case "Aug": cmd.CommandText = "select count(*) from mois where Aug= 1"; break;
                case "Sep": cmd.CommandText = "select count(*) from mois where Sep= 1"; break;
                case "Oct": cmd.CommandText = "select count(*) from mois where Oct= 1"; break;
                case "Nov": cmd.CommandText = "select count(*) from mois where Nov= 1"; break;
                case "Dece": cmd.CommandText = "select count(*) from mois where Dece= 1"; break;
            }

            cn.Open();

            dr = cmd.ExecuteReader();
            dr.Read();

            t = int.Parse(dr[0].ToString()) * 300;

            label9.Text = "Les bénéfices des ce mois sans dépenses : " + t.ToString();
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
