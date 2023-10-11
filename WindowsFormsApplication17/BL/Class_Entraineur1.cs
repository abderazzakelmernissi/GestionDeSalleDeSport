using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication17.BL
{
    class Class_Entraineur1
    {
        public DataTable GetAllSports()
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();

            Dt = DAL.SelectData("GetAllSports", null);
            return Dt;
        }

        public DataTable GetAllEntraineur()
        {

            DataTable Dt = new DataTable();
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            Dt = Dal.SelectData("GetAllEntraineur", null);
            return Dt;
        }

        public void Add_Entraineur(string NomE,string PrenomE,string sexeE, DateTime DDNE,string NumTelE,string EmailE, string AdressE, int IdSport, byte[] image)
        {

            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("NomEntraineur", SqlDbType.VarChar, 25);
            param[0].Value = NomE;

            param[1] = new SqlParameter("PrenomEntraineur", SqlDbType.VarChar, 25);
            param[1].Value = PrenomE;

            param[2] = new SqlParameter("SexeEntraineur", SqlDbType.VarChar, 25);
            param[2].Value = sexeE;

            param[3] = new SqlParameter("DDNEntraineur", SqlDbType.Date);
            param[3].Value = DDNE;

            param[4] = new SqlParameter("NumPhoneEntraineur", SqlDbType.VarChar, 25);
            param[4].Value = NumTelE;

            param[5] = new SqlParameter("EmailEntraineur", SqlDbType.VarChar, 50);
            param[5].Value = EmailE;

            param[6] = new SqlParameter("AdressEntraineur", SqlDbType.VarChar, 50);
            param[6].Value = AdressE;

            param[7] = new SqlParameter("IdSport", SqlDbType.Int);
            param[7].Value = IdSport;

            param[8] = new SqlParameter("ImageEntraineur", SqlDbType.Image);
            param[8].Value = image;


            DAL.ExucuteCommand("ADD_ENTRAINEUR", param);
            DAL.close();
        }

        public void Edit_Entraineur(string NomE, string PrenomE, string sexeE, DateTime DDNE, string NumTelE, string EmailE, string AdressE, int IdSport, byte[] image,int idE)
        {

            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("NomEntraineur", SqlDbType.VarChar, 25);
            param[0].Value = NomE;

            param[1] = new SqlParameter("PrenomEntraineur", SqlDbType.VarChar, 25);
            param[1].Value = PrenomE;

            param[2] = new SqlParameter("SexeEntraineur", SqlDbType.VarChar, 25);
            param[2].Value = sexeE;

            param[3] = new SqlParameter("DDNEntraineur", SqlDbType.Date);
            param[3].Value = DDNE;

            param[4] = new SqlParameter("NumPhoneEntraineur", SqlDbType.VarChar, 25);
            param[4].Value = NumTelE;

            param[5] = new SqlParameter("EmailEntraineur", SqlDbType.VarChar, 50);
            param[5].Value = EmailE;

            param[6] = new SqlParameter("AdressEntraineur", SqlDbType.VarChar, 50);
            param[6].Value = AdressE;

            param[7] = new SqlParameter("IdSport", SqlDbType.Int);
            param[7].Value = IdSport;

            param[8] = new SqlParameter("ImageEntraineur", SqlDbType.Image);
            param[8].Value = image;

            param[9] = new SqlParameter("IdEntraineur", SqlDbType.Int);
            param[9].Value = idE;


            DAL.ExucuteCommand("Edit_Entraineur", param);
            DAL.close();
        }

        public void DeleteEntraineur(int ID)
        {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdE", SqlDbType.Int);
            param[0].Value = ID;
            Dal.ExucuteCommand("DELETE_ENTRAINEUR", param);
        }


        public DataTable GetImageEntraineur(int ID)
        {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("IDE", SqlDbType.Int);
            param[0].Value = ID;
            return Dal.SelectData("GETIMAGEENTRAINEUR", param);

        }

        //Rechercher Des Member
        public DataTable RechEntraineur(string mot)
        {

            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mot", SqlDbType.VarChar, 50);
            param[0].Value = mot;
            return Dal.SelectData("RECHENTRAINEUR", param);

        }
    }
}
