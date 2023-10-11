using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17.PL
{
    public partial class RestoreBD : Form
    {
        public RestoreBD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog1.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "restore Database GGYM FROM Disk='" + textBox1.Text + "'";

            SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=GGYM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, cn);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("BackUp", "", MessageBoxButtons.OK);
        }
    }
}
