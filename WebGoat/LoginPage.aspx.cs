using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using TechInfoSystems.Data.SQLite;
using System.Web.Security;
using System.Web.Configuration;

namespace OWASP.WebGoat.NET
{
    public partial class LoginPage : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
    	{
    	}
    
    	protected void ButtonAdminLogOn_Click(object sender, EventArgs e)
    	{
            if(txtUserName.Value == "admin" && txtPassword.Value == "pass123")
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Value, true);
            }
            else
            {
                labelMessage.Text = "Invalid Credentials";
            }
	    }
	}
}