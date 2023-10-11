using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication17.BL
{
    class Class_Member
    {

        //Recuppere Tous les Sport
        public DataTable GetAllSports() {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();

            Dt = DAL.SelectData("GetAllSports", null);
            return Dt;
        }


        //Recupere Tous les sport par Entraineur
        public DataTable GetEntraineur(int IdSport) {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            SqlParameter [] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdSport", SqlDbType.Int);
            param[0].Value = IdSport;

            DT = DAL.SelectData("GetEntraineur",param);
            return DT;
        }

        //Recupper tous les groupes
        public DataTable GetGroup(int IdEntraineur)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IdEntraineur", SqlDbType.Int);
            param[0].Value = IdEntraineur;

            DT = DAL.SelectData("GetGroup", param);
            return DT;
        }

        //Ajouter Un Member
        public void Add_Member(string NomM, string PrenomM, string sex, DateTime DDNM, string NumPhone, string EmailM, string AdressM, int PoisM, float HauteurM, int idEntrineur, int idGroupe, byte[] image, int IdSport, string assurance, string ceinture)
        {

            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@nomMember", SqlDbType.VarChar, 25);
            param[0].Value = NomM;

            param[1] = new SqlParameter("@PrenomMember", SqlDbType.VarChar, 25);
            param[1].Value = PrenomM;

            param[2] = new SqlParameter("@SexeMember", SqlDbType.VarChar, 25);
            param[2].Value = sex;

            param[3] = new SqlParameter("@DDNMember", SqlDbType.Date);
            param[3].Value = DDNM;

            param[4] = new SqlParameter("@NumPhoneMember", SqlDbType.VarChar, 25);
            param[4].Value = NumPhone;

            param[5] = new SqlParameter("@EmailMember", SqlDbType.VarChar, 50);
            param[5].Value = EmailM;

            param[6] = new SqlParameter("@AdresseMember", SqlDbType.VarChar, 50);
            param[6].Value = AdressM;

            param[7] = new SqlParameter("@PoisMember", SqlDbType.Int);
            param[7].Value = PoisM;

            param[8] = new SqlParameter("@HauteurMember", SqlDbType.Int);
            param[8].Value = HauteurM;

            param[9] = new SqlParameter("@IdEntraineur", SqlDbType.Int);
            param[9].Value = idEntrineur;

            param[10] = new SqlParameter("@IdGroupe", SqlDbType.Int);
            param[10].Value = idGroupe;

            param[11] = new SqlParameter("@image", SqlDbType.Image);
            param[11].Value = image;

            param[12] = new SqlParameter("@IdSport", SqlDbType.Int);
            param[12].Value = IdSport;

            param[13] = new SqlParameter("@assurance", SqlDbType.VarChar, 3);
            param[13].Value = assurance;

            param[14] = new SqlParameter("@ceinture", SqlDbType.VarChar, 30);
            param[14].Value = ceinture;

            DAL.ExucuteCommand("ADD_MEMBER", param);
            DAL.close();
        }


        //Modifier Un Member
        public void Edit_Member(string NomM, string PrenomM, string sex, DateTime DDNM, string NumPhone, string EmailM, string AdressM, int PoisM, float HauteurM, int idEntrineur, int idGroupe, byte[] image, int IdSport, int ID, string assurance, string ceinture)
        {

            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@nomMember", SqlDbType.VarChar, 25);
            param[0].Value = NomM;

            param[1] = new SqlParameter("@PrenomMember", SqlDbType.VarChar, 25);
            param[1].Value = PrenomM;

            param[2] = new SqlParameter("@SexeMember", SqlDbType.VarChar, 25);
            param[2].Value = sex;

            param[3] = new SqlParameter("@DDNMember", SqlDbType.Date);
            param[3].Value = DDNM;

            param[4] = new SqlParameter("@NumPhoneMember", SqlDbType.VarChar, 25);
            param[4].Value = NumPhone;

            param[5] = new SqlParameter("@EmailMember", SqlDbType.VarChar, 50);
            param[5].Value = EmailM;

            param[6] = new SqlParameter("@AdresseMember", SqlDbType.VarChar, 50);
            param[6].Value = AdressM;

            param[7] = new SqlParameter("@PoisMember", SqlDbType.Int);
            param[7].Value = PoisM;

            param[8] = new SqlParameter("@HauteurMember", SqlDbType.Int);
            param[8].Value = HauteurM;

            param[9] = new SqlParameter("@IdEntraineur", SqlDbType.Int);
            param[9].Value = idEntrineur;

            param[10] = new SqlParameter("@IdGroupe", SqlDbType.Int);
            param[10].Value = idGroupe;

            param[11] = new SqlParameter("@image", SqlDbType.Image);
            param[11].Value = image;

            param[12] = new SqlParameter("@IdSport", SqlDbType.Int);
            param[12].Value = IdSport;

            param[13] = new SqlParameter("@ID", SqlDbType.Int);
            param[13].Value = ID;

            param[14] = new SqlParameter("@assurance", SqlDbType.VarChar, 3);
            param[14].Value = assurance;

            param[15] = new SqlParameter("@ceinture", SqlDbType.VarChar, 30);
            param[15].Value = ceinture;

            DAL.ExucuteCommand("Edit_Member", param);
            DAL.close();
        }


        //Recuppere Tous Les Member
        public DataTable GetAllMember() {

            DataTable Dt = new DataTable();
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            Dt = Dal.SelectData("GetAllMember", null);
            return Dt;
        }

        //Rechercher Des Member
        public DataTable RechMember(string mot) {

            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mot", SqlDbType.VarChar, 50);
            param[0].Value = mot;
            return Dal.SelectData("RechMember", param);

        }

        //Supprimer Un Member
        public void DeleteMember(int ID)
        {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID",SqlDbType.Int);
            param[0].Value=ID;
            Dal.ExucuteCommand("DeleteMember", param);
        }

        //Recupere La photo
        public DataTable GetImageMember(int ID) {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            return Dal.SelectData("GetImageMember", param);
        
        }


        public DataTable GetAllMemberArchiver()
        {

            DataTable Dt = new DataTable();
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();
            Dt = Dal.SelectData("GetAllMemberArchiver", null);
            return Dt;
        }

        public void ArchiverMember(int id)
        {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("id", SqlDbType.Int);
            param[0].Value = id;
            Dal.ExucuteCommand("archiverMember", param);
        }

        public void ReArchiverMember(int id)
        {
            DAL.DataAccesLayer Dal = new DAL.DataAccesLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("id", SqlDbType.Int);
            param[0].Value = id;
            Dal.ExucuteCommand("ReArchiverMember", param);
        }
    }
}
