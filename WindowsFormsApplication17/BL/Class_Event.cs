using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication17.BL
{
    class Class_Event
    {
        DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

        public void Insert_Event(string nomE, DateTime Dte, string desc) {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@nomE", SqlDbType.VarChar);
            param[0].Value = nomE;

            param[1] = new SqlParameter("@Dte", SqlDbType.Date);
            param[1].Value = Dte;

            param[2] = new SqlParameter("@desc", SqlDbType.VarChar);
            param[2].Value = desc;

            Dal.ExucuteCommand("Insert_event", param);
        }

        public DataTable GetAllEvent() {

            return Dal.SelectData("GetAllEvent", null);
        }


        public void update_event(string nomE, DateTime Dte, string desc,int id)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@nome", SqlDbType.VarChar);
            param[0].Value = nomE;

            param[1] = new SqlParameter("@dte", SqlDbType.Date);
            param[1].Value = Dte;

            param[2] = new SqlParameter("@desc", SqlDbType.VarChar);
            param[2].Value = desc;

            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = id;

            Dal.ExucuteCommand("update_event", param);
        }

        public void delete_event(int id) {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.ExucuteCommand("delete_event", param);
        }

    }
}
