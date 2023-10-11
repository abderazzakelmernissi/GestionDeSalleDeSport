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
    public partial class AddTrainor : Form
    {
        ///BL.Class_Entraineur Bl = new BL.Class_Entraineur();
        BL.Class_Entraineur1 Bl = new BL.Class_Entraineur1();

        BL.Class_Entraineur1 CLSE = new BL.Class_Entraineur1();
        public AddTrainor()
        {
            InitializeComponent();
            cmbSexe.Items.Add("Male");
            cmbSexe.Items.Add("Female");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Entraineur E1 = new Entraineur();
            E1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Entraineur e1 = new Entraineur();
            e1.Show();
        }

        private void AddTrainor_Load(object sender, EventArgs e)
        {
            cmbSport.DataSource = Bl.GetAllSports();
            cmbSport.DisplayMember = "NomSport";
            cmbSport.ValueMember = "IdSport";
            txbNom.Focus();

            DataTable dt;
            dt = Bl.GetAllEntraineur();
            if (dt != null)
            {
                dataGridView1.DataSource = Bl.GetAllEntraineur();
                label8.Text = dataGridView1.Rows.Count.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try{
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                //Bl.Add_Entraineur(txbNom.Text, txbPrenom.Text, cmbSexe.SelectedValue.ToString(), dateTimePicker1.Value, txbNumTele.Text, txbEmail.Text, txbAdress.Text, int.Parse(cmbSport.SelectedValue.ToString()), byteimage);
                Bl.Add_Entraineur(txbNom.Text, txbPrenom.Text, cmbSexe.SelectedItem.ToString(), dateTimePicker1.Value, txbNumTele.Text, txbEmail.Text, txbAdress.Text, int.Parse(cmbSport.SelectedValue.ToString()), byteimage);

                MessageBox.Show("Ajoute Bien Effectee", "Bien Ajour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = Bl.GetAllEntraineur();
            }
            catch
            {
                MessageBox.Show("verifier les donne");
            }
         

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                Bl.Edit_Entraineur(txbNom.Text, txbPrenom.Text, cmbSexe.SelectedItem.ToString(), dateTimePicker1.Value, txbNumTele.Text, txbEmail.Text, txbAdress.Text, int.Parse(cmbSport.SelectedValue.ToString()), byteimage, int.Parse(txbID.Text));
                MessageBox.Show("Modifier Bien Effectee", "Bien Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = Bl.GetAllEntraineur();
            }
            catch (Exception)
            {
                MessageBox.Show("verifier les Donnes");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Vous Avez Vraiment suuprime ce Entraineur", "Suppr", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try{
                Bl.DeleteEntraineur(int.Parse(txbID.Text));

                dataGridView1.DataSource = Bl.GetAllEntraineur();
                MessageBox.Show("Supprission Bien Effectee", "Bien Suppr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Selectioner Un member");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txbNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbPrenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbSexe.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txbNumTele.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txbEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txbAdress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbSport.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            //byte[] imagebyte = (byte[])Bl.GetImageEntraineur(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            byte[] image = (byte[])Bl.GetImageEntraineur(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bl.RechEntraineur(textBox1.Text);
            label8.Text = dataGridView1.Rows.Count.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Entraineur f1 = new Entraineur();
            f1.Show();
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
