using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FoodOrderManagement
{
    public partial class MenuList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
                LoadData();
        }

        void LoadData()
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MenuItems", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

            SqlCommand cmd = new SqlCommand("DELETE FROM MenuItems WHERE MenuId=@Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadData();
        }
    }
}
