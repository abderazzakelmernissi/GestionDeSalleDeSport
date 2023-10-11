using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication17.DAL
{
        class DataAccesLayer
    {
        SqlConnection cn;

        //Inistialisation connection
        public DataAccesLayer() 
        {
            cn = new SqlConnection("Data Source=USER6EB4;Initial Catalog=GGYM;Integrated Security=True");
            //cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=.\Data\Database1.mdf;Integrated Security=True");

        }

        public void open()
        {
            if (cn.State != ConnectionState.Open) cn.Open();
           
        }

        public void close() {
            if (cn.State == ConnectionState.Open) cn.Close();
        }
            

        //Read From DataBase
        public DataTable SelectData(string stored_Procedure, SqlParameter[] Param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_Procedure;
            cmd.Connection = cn;
            if (Param != null) { cmd.Parameters.AddRange(Param); }

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            return Dt;
        }


        //Methode insert update Delete
        public void ExucuteCommand (string stored_Procedure, SqlParameter[] Param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_Procedure;
            cmd.Connection = cn;
            if (Param != null) { cmd.Parameters.AddRange(Param); }

            
               // for (int i = 0; i < Param.Length; i++) {
                 //   cmd.Parameters.Add(Param[i]);
                //}

            open();
            cmd.ExecuteNonQuery();
            close();
        }

    }
}


