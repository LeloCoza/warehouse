using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class Catalog : System.Web.UI.Page
    {
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
            if (!Page.IsPostBack)
            {
                bool firstDisplay = false;
                int numItems = 0, count = 0, itr = 0;
                foreach (var product in lh.getAllProducts())
                {
                    numItems += 1;
                }
                string htmlText = "<div class='w_content'><div class='women'>";
                htmlText += "<a href='#'><h4>Store-<span>" + numItems + ": items</span></h4></a>";
                htmlText += "<ul class='w_nav'>";
                htmlText += "<li>Sort : </li>";
                htmlText += "<li><a class='active' href='#'>popular</a></li> |";
                htmlText += "<li><a href ='#'>new</a></li> |";
                htmlText += "<li><a href='#'>discount</a></li> |";
                htmlText += "<li><a href ='#'>price: Low High</a></li>";
                htmlText += "<div class='clear'></div></ul><div class='clearfix'></div></div>";
                // htmlText +="< div class='clearfix'></div>";




                foreach (var product in lh.getAllProducts())
                {
                    if (count == 0)
                    {
                        //<!-- grids_of_4 -->
                        htmlText += "<div class='grids_of_4'>";
                    }

                    if (count == 4)
                    {
                        htmlText += "<div class='clearfix'></div><div class='grids_of_4' style='margin-bottom:5px'>";
                        count = 0;
                    }
                    htmlText += "<div class='grid1_of_4'>";
                    htmlText += "<div class='content_box'><a href ='ProductDetails.aspx?producttypeId=" + product.ProductId + "'>";
                    htmlText += "<img src='data:image/jpeg;base64," + product.Image64String + "' class='img-responsive' alt=''></a>";
                    string category = "", typeName = "";
                    foreach (var type in lh.getAllProductTypes())
                    {
                        if (type.productTypeId == product.ProductTypeId)
                        {
                            category = type.productCategory;
                            typeName = type.productTypeName;
                        }

                    }
                    htmlText += "<h4><a href ='details.html'>" + category + ": " + typeName + "</a></h4>";
                    htmlText += "<p>" + product.Description + "</p>";
                    htmlText += "<div class='grid_1 simpleCart_shelfItem'>";
                    htmlText += "<div class='item_add'><span class='item_price'><h6>ONLY R" + Math.Round(product.Price, 2) + "</h6></span></div>";
                    if (Session["Id"] != null)
                    {
                        htmlText += "<div class='item_add'><span class='item_price'><a href ='ProductDetails.aspx?producttypeId=" + product.ProductId + "'>Add to cart</a></span></div>";
                    }
                    htmlText += "</div></div></div>";
                    if (count == 4)
                    {
                        htmlText += "<div class='clearfix'></div></div>";
                        // count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
                htmlText += "<div class='clearfix'></div></div>";
                mycatlog.InnerHtml = htmlText;
            }
        }
    }
}