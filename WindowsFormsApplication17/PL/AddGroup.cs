using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class AddGroup : Form
    {
        BL.Auter Bl = new BL.Auter();
        BL.Class_Member Blc = new BL.Class_Member();
        BL.Class_Entraineur1 Ble = new BL.Class_Entraineur1();
        public AddGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Groupes g = new Groupes();
            g.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bl.AddGroup(txbNomGroup.Text, int.Parse(cmbEntrineur.SelectedValue.ToString()), int.Parse(cmbSport.SelectedValue.ToString()));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bl.AddSport(txtSport.Text);
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = Blc.GetAllSports();
            if (dt != null)
            {
                cmbSport.DataSource = dt;
                cmbSport.DisplayMember = "NomSport";
                cmbSport.ValueMember = "IdSport";

                cmbSport1.DataSource = dt;
                cmbSport1.DisplayMember = "NomSport";
                cmbSport1.ValueMember = "IdSport";
            }

            dt = Ble.GetAllEntraineur();
            if (dt != null)
            {
            cmbEntrineur.DataSource = dt;
            cmbEntrineur.DisplayMember = "NomEntraineur";
            cmbEntrineur.ValueMember = "IdEntraineur";
            }
        }
    }
}
