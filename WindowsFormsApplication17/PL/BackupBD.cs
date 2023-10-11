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
    public partial class BackupBD : Form
    {
        public BackupBD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {

                textBox1.Text = folderBrowserDialog1.SelectedPath;
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string FileName = textBox1.Text + "//BackUp" + DateTime.Now.ToShortDateString().Replace('/', '-') + DateTime.Now.ToShortTimeString().Replace(':', '-');
            string query = "Backup Database GGYM to Disk='" + FileName+".bak'";

            SqlConnection cn = new SqlConnection("Data Source=USER6EB4;Initial Catalog=GGYM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query,cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("BackUp","",MessageBoxButtons.OK);
        }

        private void BackupBD_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
