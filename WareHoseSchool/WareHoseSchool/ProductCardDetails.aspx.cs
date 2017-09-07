using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class ProductCardDetails : System.Web.UI.Page
    {
        localhost.Service1 lh;
        public int _numItems = 0, _totalCharges = 0;
        public decimal _priceOfItems = 0;
        public decimal _TotalPrice = 0;

        int userId;

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            userId = Convert.ToInt32(Session["Id"]);
            foreach (var productsIncard in lh.getAllProductsInCardByUserId(userId, true))
            {
                if (productsIncard.isRemoved.Equals("false"))
                {
                    totalPrice += Convert.ToDecimal(productsIncard.productPrice + 40);
                    lh.addOrder(productsIncard.ProductId, true, productsIncard.CardId, true, totalPrice, true, userId, true, productsIncard.ProductTypeId, true);
                }
            }
            Response.Redirect("OrderedProducts.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            lh = new localhost.Service1();

            if (!Page.IsPostBack)
            {
                if (Session["Id"] != null)
                {
                    userId = Convert.ToInt32(Session["Id"]);
                    foreach (var productsIncard in lh.getAllProductsInCardByUserId(userId, true))
                    {
                        if (productsIncard.isRemoved.Equals("false"))
                        {
                            _numItems += 1;
                        }
                    }
                    _totalCharges = 40 * _numItems;
                    string htmlText = "<h1>My Shopping items (" + _numItems + ")</h1>";
                    foreach (var cardProduct in lh.getAllProductsInCard())
                    {
                        if (Convert.ToInt32(Session["Id"]) == cardProduct.UserId && cardProduct.isRemoved.Equals("false"))
                        {

                            //numItems += 1;
                            htmlText += "<div class='cart-header'><a  href ='removeItem.aspx?producttypeId=" + cardProduct.CardId + "'><div class='close1'></div></a>";
                            htmlText += "<div class='cart-sec simpleCart_shelfItem'>";
                            htmlText += "<div class='cart-item cyc'>";
                            string imageString = "", category = "", typeName = "";
                            decimal price = 0;


                            foreach (var productsIncard in lh.getAllProducts())
                            {

                                if (cardProduct.ProductId == productsIncard.ProductId)
                                {
                                    _priceOfItems += Math.Round(productsIncard.Price, 2);
                                    imageString = productsIncard.Image64String;
                                    price = Math.Round(productsIncard.Price, 2);
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
                            htmlText += "<img src='data:image/jpeg;base64," + imageString + "' class='img-responsive' alt=''></div>";
                            htmlText += "<div class='cart-item-info'>";
                            int modelNumber = 3578 + cardProduct.ProductId;
                            htmlText += "<h3><a href='#'>" + category + ": " + typeName + "</a><span>Model No: " + modelNumber + "</span></h3>";
                            htmlText += "<ul class='qty'><li><p>Price: R" + price + "</p></li>";
                            htmlText += "<li><p>Qty : " + cardProduct.Quantity + "</p></li></ul>";
                            htmlText += "<div class='delivery'><p>Added on : " + cardProduct.DateTime + "</p>";
                            htmlText += "<span>Delivered in 2-3 bussiness days</span>";
                            htmlText += "<div class='clearfix'></div>";
                            htmlText += "</div></div><div class='clearfix'></div></div>";


                            CardList.InnerHtml = htmlText;
                        }
                    }
                }
            }
            _TotalPrice = _totalCharges + _priceOfItems;

        }
    }
}