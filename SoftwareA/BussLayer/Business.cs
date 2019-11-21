using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussLayer
{
    public class Business
    {
        DataAccess da = new DataAccess();

        //product info
        public int Pid { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string stock { get; set; }
        public string category { get; set; }
        public string offer { get; set; }
        public string delivery { get; set; }

        //customer info
        public int Cid { get; set; }
        public string cName { get; set; }
        public string Adress { get; set; }
        public bool LoyaltyMember { get; set; }


        SqlCommand cmd = new SqlCommand();

        public DataSet BL_bind()
        {
            return da.Al_bind();

        }

        public DataSet CL_BIND()
        {
            return da.CL_bind();
        }
        

        //products insert update delete

        public void Insert_record()
        {
            cmd.Parameters.AddWithValue("@pid", Pid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("offer", offer);
            cmd.Parameters.AddWithValue("delivery", delivery);
            da.Insert_data(cmd);
        }

        public void Update_data(int ptid)
        {
            cmd.Parameters.AddWithValue("@pid", Pid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("offer", offer);
            cmd.Parameters.AddWithValue("delivery", delivery);
            da.updatte_data(cmd);

        }

        public void Delete_record(int ptid)
        {
            cmd.Parameters.AddWithValue("@pid", Pid);
            da.Delete_data(cmd);
        }


        //customers create update delete
       public void Insert_recordC()
        {
            cmd.Parameters.AddWithValue("@Cid", Cid);
            cmd.Parameters.AddWithValue("@name", cName);
            cmd.Parameters.AddWithValue("@Adress", Adress);
            cmd.Parameters.AddWithValue("@LoyaltyMember", LoyaltyMember);
            da.Insert_datac(cmd);
        }

        public void Update_dataC(int ctid)
        {
            cmd.Parameters.AddWithValue("@Cid", Cid);
            cmd.Parameters.AddWithValue("@name", cName);
            cmd.Parameters.AddWithValue("@Adress", Adress);
            cmd.Parameters.AddWithValue("@LoyaltyMember", LoyaltyMember);
            da.update_datac(cmd);
        }

        public void Delele_dataC(int ctid)
        {
            cmd.Parameters.AddWithValue("@Cid", Cid);
            da.Delete_datac(cmd);
        }
    }
}
