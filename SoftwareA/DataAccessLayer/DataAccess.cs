using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);

        public DataSet Al_bind()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Getproducts", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataSet CL_bind()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Getcustomers", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
           
        public void Insert_data(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spinsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
        public void updatte_data(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spupdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void Delete_data(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spDelete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            // test this
        }

        public void Insert_datac(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spinsertc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void update_datac(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spUpdateC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void Delete_datac(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spdeleteC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}