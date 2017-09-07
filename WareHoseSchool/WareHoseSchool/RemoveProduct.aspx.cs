using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class RemoveProduct : System.Web.UI.Page
    {
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
            int productId;
            int.TryParse(Request.QueryString["producttypeId"], out productId);

            lh.deleteProduct(productId, true);
            Response.Redirect("Catalog.aspx");
        }
    }
}