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
    public partial class Months : Form
    {
        public static int BB;
        public Months()
        {
            InitializeComponent();
        }
        BL.MemberShip bl = new BL.MemberShip();
        private void Months_Load(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();
            dt = bl.GetMemberMonth(BB);
            if (dt.Rows[0][1].ToString() == "1") { btnJan.Visible = true; }
            if (dt.Rows[0][2].ToString() == "1") { btnFeb.Visible = true; }
            if (dt.Rows[0][3].ToString() == "1") { btnMar.Visible = true; }
            if (dt.Rows[0][4].ToString() == "1") { btnApr.Visible = true; }
            if (dt.Rows[0][5].ToString() == "1") { btnMay.Visible = true; }
            if (dt.Rows[0][6].ToString() == "1") { btnJun.Visible = true; }
            if (dt.Rows[0][7].ToString() == "1") { btnJul.Visible = true; }
            if (dt.Rows[0][8].ToString() == "1") { btnAug.Visible = true; }
            if (dt.Rows[0][9].ToString() == "1") { btnSep.Visible = true; }
            if (dt.Rows[0][10].ToString() == "1") { btnOct.Visible = true; }
            if (dt.Rows[0][11].ToString() == "1") { btnNov.Visible = true; }
            if (dt.Rows[0][12].ToString() == "1") { btnDec.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
