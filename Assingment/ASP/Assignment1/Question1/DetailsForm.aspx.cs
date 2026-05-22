using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question1
{
    public partial class DetailsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckButton_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Write("<script>alert('Submitted!!!...');</script>");
            }
        }

        protected void NameValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value != FamilyName.Text)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}