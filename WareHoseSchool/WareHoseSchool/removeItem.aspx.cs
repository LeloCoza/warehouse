using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class removeItem : System.Web.UI.Page
    {
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
            int productCard;
            int.TryParse(Request.QueryString["producttypeId"], out productCard);

            lh.removeProductFromCard(productCard, true);
            Response.Redirect("ProductCardDetails.aspx");

        }
    }
}