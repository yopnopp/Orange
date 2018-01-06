using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GuestBook
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(); 
            cnn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString; 
            cnn.Open();

            GuestBook book = new GuestBook();
            book.VisitorName = txtName.Text;
            SqlCommand cmd = new SqlCommand("insert into tblVisitors values('" + book.VisitorName + "')", cnn);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
                
                cnn.Close();
                string script = @"<script language=""javascript""> alert('Information have been Saved Successfully.......!!!!!.');</script>;";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "myJScript1", script);
            }
            catch (Exception ex)
            {
                string script = @"<script language=""javascript""> alert('No data saved');</script>;";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "myJScript1", script);
            }
            


        }
    }
}
