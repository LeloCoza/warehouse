using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class OrderedProducts : System.Web.UI.Page
    {
        localhost.Service1 lh;
        public int _numItems = 0, _totalCharges = 0;
        public decimal _priceOfItems = 0;
        public decimal _TotalPrice = 0;

        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();

            if (!Page.IsPostBack)
            {
                if (Session["Id"] != null)
                {
                    userId = Convert.ToInt32(Session["Id"]);
                    foreach (var productsIncard in lh.getAllOrdersByUserId(userId, true))
                    {
                        _numItems += 1;
                    }
                    _totalCharges = 40 * _numItems;
                    string htmlText = "<h2 style='align-content:center'>My Orderd items (" + _numItems + ")</h1>";
                    foreach (var cardProduct in lh.getAllOrdersByUserId(userId, true))
                    {
                        htmlText += "<div class='cart-header'><div class='close1'></div>";
                        htmlText += "<div class='cart-sec simpleCart_shelfItem'>";
                        htmlText += "<div class='cart-item cyc'>";
                        string imageString = "", category = "", typeName = "";
                        decimal price = 0;

                        int quantity = 0;
                        string status="";
                        foreach (var productsIncard in lh.getAllProducts())
                        {

                            if (cardProduct.ProductID == productsIncard.ProductId)
                            {
                                _priceOfItems += Math.Round(productsIncard.Price, 2);
                                imageString = productsIncard.Image64String;
                                price = Math.Round(productsIncard.Price, 2);
                                quantity = productsIncard.Quantity;
                            }
                        }
                        foreach (var productTypeIncard in lh.getAllProductTypes())
                        {
                            if (cardProduct.ProductTypeId == productTypeIncard.productTypeId)
                            {
                                category = productTypeIncard.productCategory;
                                typeName = productTypeIncard.productTypeName;
                            }
                        }
                       
                        foreach (var clientStatus in lh.getAllClientStatus())
                        {
                            if(clientStatus.ClientStatusId == cardProduct.ClientStatusId)
                            {
                                status = clientStatus.ClientStatusName;
                            }
                        }
                            htmlText += "<img src='data:image/jpeg;base64," + imageString + "' class='img-responsive' alt=''></div>";
                        htmlText += "<div class='cart-item-info'>";
                        int modelNumber = 3578 + cardProduct.ProductID;
                        htmlText += "<h3><a href='#'>" + category + ": " + typeName + "</a><span>Model No: " + modelNumber + "</span></h3>";
                        htmlText += "<ul class='qty'><li><p>Price: R" + price + "</p></li>";
                        htmlText += "<li><p>Qty : " + quantity + "</p></li></ul>";
                        htmlText += "<div class='delivery'><p>Oder Date : " + cardProduct.OrderDate + "</p>";

                        htmlText += "<span>Status: "+ status +"</span>";
                        htmlText += "<div class='clearfix'></div>";
                        htmlText += "</div></div><div class='clearfix'></div></div>";


                        oders.InnerHtml = htmlText;
                    }
                }
            }

            _TotalPrice = _totalCharges + _priceOfItems;
        }
    }
}