using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class Registration : System.Web.UI.Page
    {
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string password = rtxtPassword.Value;
            string rPassword = rtxtRePassword.Value;
            if (password == rPassword)
            {
                lh.Register(rtxtFirstName.Value, rtxtLastName.Value, rtxtEmailAdress.Value, rtxtcontact.Value, rtxtPassword.Value, "C");
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblErr.Text = "Passwords do not match";
                lblErr.Visible = true;
            }

        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string email = txtEmail.Value;
        //    string password = txtPassword.Value;
        //    bool canLogin, idS, loginS;
        //    int Id;
        //    string authenticationLevel;
        //    btnLogin.Text = txtEmail.Value;
        //    lh.login(email, password, out canLogin, out loginS, out Id, out idS, out authenticationLevel);

        //    if (canLogin)
        //    {
        //        Session.Add("Id", Id);
        //        Session.Add("email", email);
        //        Session.Add("authenticationLevel", authenticationLevel);
        //        Response.Redirect("Catalog.aspx");
        //    }
        //    else if(!canLogin)
        //    {
        //        Label2.Text = "incorrect password/email";
        //        Label2.Visible = true;
        //    }
        //    else
        //    {
        //        Label2.Text = "Connection error!";
        //        Label2.Visible = true;
        //    }
        //}
    }
}