using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication17.BL
{
    class Auter
    {

        public void AddGroup(string Nom, int IDE,int IdSport) {

            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@nomG", SqlDbType.VarChar, 30);
            param[0].Value = Nom;

            param[1] = new SqlParameter("@idEntrineur", SqlDbType.Int);
            param[1].Value = IDE;

            param[2] = new SqlParameter("@idSport", SqlDbType.Int);
            param[2].Value = IdSport;

            Dal.ExucuteCommand("AddGroup", param);
        
        }

        public void AddSport(string Nom)
        {

            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NomSport", SqlDbType.VarChar, 30);
            param[0].Value = Nom;

            Dal.ExucuteCommand("AddSport", param);

        }

    }
}
