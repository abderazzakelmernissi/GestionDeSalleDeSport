using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication17.BL
{
    class C_LOGIN
    {
        public DataTable LOGIN(string ID, string MDP)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;

            param[1] = new SqlParameter("@MDP", SqlDbType.VarChar, 30);
            param[1].Value = MDP;
            DAL.open();
            return DAL.SelectData("SP_LOGIN", param);
        }

        public void AddUser(string User, string Pass, string type) {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@user", SqlDbType.VarChar, 30);
            param[0].Value = User;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 30);
            param[1].Value = Pass;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 30);
            param[2].Value = type;

            Dal.ExucuteCommand("AddUser",param);
        
        }
    }
}