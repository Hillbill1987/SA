using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussLayer;

namespace SoftwareA
{
    public partial class CustomersPage : System.Web.UI.Page
    {
        Business b = new Business();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridbind();
            }
        }

        public void gridbind()
        {
            GridView2.DataSource = b.CL_BIND();
            GridView2.DataBind();
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            b.cName = txt_name.Text;
            b.Adress = txt_name.Text;
            b.LoyaltyMember = chk_loyalty.Checked;
            b.Insert_recordC();
            gridbind();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            b.Cid = Convert.ToInt32(txt_id.Text);
            b.cName = txt_name.Text;
            b.Adress = txt_address.Text;
            b.LoyaltyMember = chk_loyalty.Checked;
            b.Update_dataC(b.Cid);
            gridbind();

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            b.Cid = Convert.ToInt32(txt_id.Text);
            b.cName = txt_name.Text;
            b.Adress = txt_address.Text;
            b.LoyaltyMember = chk_loyalty.Checked;
            b.Delele_dataC(b.Cid);
            gridbind();

        }
    }
}