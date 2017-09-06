using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class Home : System.Web.UI.MasterPage
    {
        public double _itemsPrice = 0;
        public int _numItem = 0;
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
            if (Session["Id"] != null)
            {
                int userId = Convert.ToInt32(Session["Id"]);
                string authentication = Convert.ToString(Session["authenticationLevel"]);
                if (authentication.Equals("C"))
                {
                    foreach (var card in lh.getAllProductsInCardByUserId(userId, true))
                    {
                        if (card.isRemoved == "false")
                        {
                            _numItem += 1;
                            foreach (var product in lh.getAllProducts())
                            {
                                if (card.ProductId == product.ProductId)
                                {
                                    _itemsPrice += Convert.ToDouble(Math.Round(product.Price, 2));
                                }
                            }
                        }
                    }
                    lalbol_Logout.Visible = true;
                    Login_link.Visible = false;
                    Register_link.Visible = false;
                    Logout_link.Visible = true;

                    myCard_link.Visible = true;
                }
            }
        }
    }
}