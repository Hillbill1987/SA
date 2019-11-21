using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BussLayer;

namespace SoftwareA
{
    public partial class Frontend : System.Web.UI.Page
    {
        Business b = new Business();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridBind();
            }
        }


        public void GridBind()
        {
            GridView1.DataSource = b.BL_bind();
            GridView1.DataBind();

        }
        protected void btn_insert_Click(object sender, EventArgs e)
        {
            b.name = txt_name.Text;
            b.price = txt_price.Text;
            b.stock = txt_stock.Text;
            b.category = txt_category.Text;
            b.offer = txt_offer.Text;
            b.delivery = txt_delivery.Text;
            b.Insert_record();
            GridBind();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            b.Pid = Convert.ToInt32(txt_id.Text);
            b.name = txt_name.Text;
            b.price = txt_price.Text;
            b.stock = txt_stock.Text;
            b.category = txt_category.Text;
            b.offer = txt_offer.Text;
            b.delivery = txt_delivery.Text;
            b.Update_data(b.Pid);
            GridBind();

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            b.Pid = Convert.ToInt32(txt_id.Text);
            b.Delete_record(b.Pid);
            GridBind();

        }
    }
}