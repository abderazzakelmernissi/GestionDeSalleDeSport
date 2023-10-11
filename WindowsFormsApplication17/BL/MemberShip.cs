using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication17.BL
{
    class MemberShip
    {
        DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

        public void Update_Month(int Ide, int t)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idm", SqlDbType.Int);
            param[0].Value = Ide;

            param[1] = new SqlParameter("@t", SqlDbType.Int);
            param[1].Value = t;

            Dal.ExucuteCommand("Update_Month", param);

        }

        public DataTable GetMemberMonth(int idm)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idm", SqlDbType.Int);
            param[0].Value = idm;
            return Dal.SelectData("GetMemberMonth",param);
        }

        public DataTable GetNomPaye(int Ide)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idmonth", SqlDbType.Int);
            param[0].Value = Ide;

            return Dal.SelectData("GetNomPaye", param);

        }
    }
}
