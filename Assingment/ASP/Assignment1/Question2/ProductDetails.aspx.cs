using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question2
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        string[] products = { "Smart Watch", "Dress", "Mobile" };
        string[] images =
        {
            "~/images/SmartWatch.jpg",
            "~/images/Dress.jpg",
            "~/images/Mobile.jpg"
        };
        int[] prices = {3000,1500,37500};

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = products;
                DropDownList1.DataBind();

                imgProduct.ImageUrl = images[0];
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DropDownList1.SelectedIndex;
            imgProduct.ImageUrl=images[index];
        }

        protected void Pricebtn_Click(object sender, EventArgs e)
        {
            int index=DropDownList1.SelectedIndex;
            price.Text = "Price: ₹ " + prices[index];
        }
    }
}