using System;
using System.Web;

namespace FoodOrderManagement
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["TotalVisitors"] = 0;
            Application["ActiveUsers"] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application["TotalVisitors"] = (int)Application["TotalVisitors"] + 1;
            Application["ActiveUsers"] = (int)Application["ActiveUsers"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["ActiveUsers"] = (int)Application["ActiveUsers"] - 1;
        }
    }
}
