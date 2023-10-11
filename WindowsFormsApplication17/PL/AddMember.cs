using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCharpWebCam;
using System.IO;
namespace WindowsFormsApplication17
    
{
    public partial class AddMember : Form
    {
        BL.Class_Member Bl = new BL.Class_Member();
        public AddMember()
        {
            InitializeComponent();

          
                cmbSport.DataSource = Bl.GetAllSports();
                cmbSport.DisplayMember = "NomSport";
                cmbSport.ValueMember = "IdSport";
                cmbSport.SelectedItem = null;
                cmbSexe.Items.Add("Male");
                cmbSexe.Items.Add("Female");
                DataTable dt = new DataTable();

                dt = Bl.GetAllMember();
                {
                dataGridView1.DataSource = dt;
                label15.Text = dataGridView1.Rows.Count.ToString();
                }
                
            
            cmbassurance.Items.Add("Non");
            cmbassurance.Items.Add("Oui");

            cmbceinture.Items.Add("--none--");
            cmbceinture.Items.Add("Blanche");
            
            cmbceinture.Items.Add("Jaune");
            cmbceinture.Items.Add("Jaune Barrette");

            cmbceinture.Items.Add("Verte");
            cmbceinture.Items.Add("Verte Barrette");

            cmbceinture.Items.Add("Bleue");
            cmbceinture.Items.Add("Bleue Barrette");

            cmbceinture.Items.Add("Rouge");
            cmbceinture.Items.Add("Rouge Barrette");

            cmbceinture.Items.Add("Noire 1DAN");
            cmbceinture.Items.Add("Noire 2DAN");
            cmbceinture.Items.Add("Noire 1DAN");
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            //cmbSport.DataSource = mbr.GetAllSports();
            //cmbSport.DisplayMember = "NomSport";
            //cmbSport.ValueMember = "IdSport";
            txbNom.Focus();

            

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

        private void button5_Click(object sender, EventArgs e)
        {
            //cameraControl1.Visible = true;
            //TakePictureDialog d = new TakePictureDialog();
            //if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    Image i = d.Image;
            //    i.Save("C:\\snapshot.bmp");
            }
            //saveFileDialog1.InitialDirectory = @"L:\Pics";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK) { pictureBox1.Image.Save(saveFileDialog1.FileName); }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "choisir une photo | *.JPG; *.JPEG; *.PNG; *.GIF";
            if (ofp.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(ofp.FileName);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            members1 M1 = new members1();
            M1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectMember();
          //  txbID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
          //  txbNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          //  txbPrenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          //  DTPDDN.Value = DateTime.Parse( dataGridView1.CurrentRow.Cells[3].Value.ToString()) ;
          //  txbNumTele.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          //  txbEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
          //  txbAdress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
          //  txbPois.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
          //  txbHeuteur.Text  = dataGridView1.CurrentRow.Cells[8].Value.ToString();
          //  cmbGroup.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
          //  cmbSexe.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
          //cmbSport.SelectedIndex = cmbSport.FindStringExact(dataGridView1.CurrentRow.Cells[12].Value.ToString());
          //  //cmbSport.SelectedItem = dataGridView1.CurrentRow.Cells[12].Value.ToString();
          //  //label16.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
          //  cmbEntrineur.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
          //  //cmbassurance.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
          //  cmbassurance.SelectedItem = dataGridView1.CurrentRow.Cells[13].Value.ToString();
          //  cmbceinture.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
          //  //label16.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

          // //// cmbEntrineur.SelectedIndex = cmbEntrineur.FindStringExact(dataGridView1.CurrentRow.Cells[9].Value.ToString());
           
          //  //int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
          //  byte[] image = (byte[])Bl.GetImageMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
          //  MemoryStream ms = new MemoryStream(image);
          //  pictureBox1.Image = Image.FromStream(ms);

        }
        public void selectMember() {
            txbID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txbNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbPrenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DTPDDN.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txbNumTele.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txbEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txbAdress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txbPois.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txbHeuteur.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbGroup.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cmbSexe.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cmbSport.SelectedIndex = cmbSport.FindStringExact(dataGridView1.CurrentRow.Cells[12].Value.ToString());
            //cmbSport.SelectedItem = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            //label16.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cmbEntrineur.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //cmbassurance.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cmbassurance.SelectedItem = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cmbceinture.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            //label16.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            // cmbEntrineur.SelectedIndex = cmbEntrineur.FindStringExact(dataGridView1.CurrentRow.Cells[9].Value.ToString());

            //int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])Bl.GetImageMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                Bl.Add_Member(txbNom.Text, txbPrenom.Text, cmbSexe.SelectedItem.ToString(), DateTime.Parse(DTPDDN.Value.ToString()), txbNumTele.Text, txbEmail.Text, txbAdress.Text, int.Parse(txbPois.Text), float.Parse(txbHeuteur.Text), int.Parse(cmbEntrineur.SelectedValue.ToString()), int.Parse(cmbGroup.SelectedValue.ToString()), byteimage, int.Parse(cmbSport.SelectedValue.ToString()), cmbassurance.SelectedItem.ToString(), cmbceinture.SelectedItem.ToString());
                MessageBox.Show("Ajoute Bien Effectee", "Bien Ajour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = Bl.GetAllMember();
            }
            catch{
            MessageBox.Show("verifier les donne");
            }

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

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void cmbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BL.Class_Member mbr = new BL.Class_Member();
            cmbEntrineur.DataSource = Bl.GetEntraineur(cmbSport.SelectedIndex+1);
            cmbEntrineur.DisplayMember = "NomEntraineur";
            cmbEntrineur.ValueMember = "IdEntraineur";
            cmbEntrineur.SelectedItem = null;

            
            
            //label16.Text = ""+cmbSport.SelectedValue ;

           
            }

        private void cmbEntrineur_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                //cmbGroup.DataSource = Bl.GetGroup(cmbEntrineur.SelectedIndex + 1);
                //int b = Convert.ToInt16( cmbEntrineur.SelectedValue);
                //label16.Text = b.ToString();
               // cmbGroup.DataSource = Bl.GetGroup(int.Parse(b.ToString()));
      
            cmbGroup.DataSource = Bl.GetGroup(cmbEntrineur.SelectedIndex+1);
            cmbGroup.DisplayMember = "NomGroupe";
            cmbGroup.ValueMember = "IdGroupe";
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Vous Avez Vraiment suuprime ce member", "Suppr", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try{
                    Bl.DeleteMember(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    }
                     catch{
                             MessageBox.Show("verifier les donne");
                            }
                    dataGridView1.DataSource = Bl.GetAllMember();
                    MessageBox.Show("Supprission Bien Effectee", "Bien Suppr", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
           

        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try{
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                Bl.Edit_Member(txbNom.Text, txbPrenom.Text, cmbSexe.SelectedItem.ToString(), DTPDDN.Value, txbNumTele.Text, txbEmail.Text, txbAdress.Text, int.Parse(txbPois.Text), float.Parse(txbHeuteur.Text), int.Parse(cmbEntrineur.SelectedValue.ToString()), int.Parse(cmbGroup.SelectedValue.ToString()), byteimage, int.Parse(cmbSport.SelectedValue.ToString()), int.Parse(txbID.Text), cmbassurance.SelectedItem.ToString(), cmbceinture.SelectedItem.ToString());
                MessageBox.Show("Modifier Bien Effectee", "Bien Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = Bl.GetAllMember();
            }
            catch
            {
                MessageBox.Show("verifier les donne");
            }
        }

        private void txbRech_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bl.RechMember(txbRech.Text);
            label15.Text = dataGridView1.Rows.Count.ToString();
            //dataGridView1.DataSource = Bl.RechMember(txbRech.Text); 
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            try
            {
                int AA = int.Parse(txbID.Text);
                PL.Months Mo = new PL.Months();
                PL.Months.BB = AA;
                Mo.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Selectioner Un Member");
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            //label16.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cmbassurance.SelectedIndex = 0;
            cmbceinture.SelectedIndex = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                selectMember();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Print.Print_Member PM = new Print.Print_Member();
                PM.SetParameterValue("@id", this.txbID.Text);
                Print.Form_Print FM = new Print.Form_Print();
                FM.crystalReportViewer1.ReportSource = PM;
                FM.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Selectioner Un member");
            }
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            members1 f1 = new members1();
            f1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
