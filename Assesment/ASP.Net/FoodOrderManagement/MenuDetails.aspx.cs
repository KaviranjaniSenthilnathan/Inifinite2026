using System;
using System.Data.SqlClient;
using System.Configuration;

namespace FoodOrderManagement
{
    public partial class MenuDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            int id = Convert.ToInt32(Request.QueryString["MenuId"]);

            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM MenuItems WHERE MenuId=@Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblName.Text = dr["ItemName"].ToString();
                lblPrice.Text = dr["Price"].ToString();
            }

            con.Close();
        }
    }
}
