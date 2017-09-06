using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class Login : System.Web.UI.Page
    {
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string password = txtPassword.Value;
            bool canLogin, idS, loginS;
            int Id;
            string authenticationLevel;
            btnLogin.Text = txtEmail.Value;
            lh.login(email, password, out canLogin, out loginS, out Id, out idS, out authenticationLevel);

            if (canLogin)
            {
                Session.Add("Id", Id);
                Session.Add("email", email);
                Session.Add("authenticationLevel", authenticationLevel);
                Response.Redirect("Catalog.aspx");
            }
            else if (!canLogin)
            {
                Label2.Text = "incorrect password/email";
                Label2.Visible = true;
            }
            else
            {
                Label2.Text = "Connection error!";
                Label2.Visible = true;
            }
        }
    }
}