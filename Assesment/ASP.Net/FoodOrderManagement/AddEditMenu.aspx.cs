using System;
using System.Data.SqlClient;
using System.Configuration;

namespace FoodOrderManagement
{
    public partial class AddEditMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack && Request.QueryString["MenuId"] != null)
                LoadData();
        }

        void LoadData()
        {
            int id = Convert.ToInt32(Request.QueryString["MenuId"]);

            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM MenuItems WHERE MenuId=@Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtItemName.Text = dr["ItemName"].ToString();
                txtPrice.Text = dr["Price"].ToString();
            }

            con.Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

            SqlCommand cmd;

            if (Request.QueryString["MenuId"] != null)
            {
                cmd = new SqlCommand(
                    "UPDATE MenuItems SET ItemName=@ItemName, Price=@Price WHERE MenuId=@Id", con);

                cmd.Parameters.AddWithValue("@Id", Request.QueryString["MenuId"]);
            }
            else
            {
                cmd = new SqlCommand(
                    "INSERT INTO MenuItems VALUES(@ItemName,@Category,'Type',@Price,@Qty,@Available,GETDATE())", con);
            }

            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Category", ddlCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Qty", txtQty.Text);
            cmd.Parameters.AddWithValue("@Available", chkAvailable.Checked);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("MenuList.aspx");
        }
    }
}