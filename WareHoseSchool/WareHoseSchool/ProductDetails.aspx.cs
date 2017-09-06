using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        public string _category = "0";
        public string _productCode = "0";
        public decimal _Price = 0;
        public decimal _taxAmount = 0;
        public int _productPoints = 0;
        public string _shortDescription = "short description";
        public string _fullDescription = "full description";
        public string _category2 = "";
        public string _category3 = "";
        public string _fullDescription2 = "";
        public string _fullDescription3 = "";

        public int _maxQuantity = 5, _productId1, _productId2;
        localhost.Service1 lh;

        int productId, productTypeId, userId;
        int productId2 = 0, productId3 = 0, productTypeId2 = 0, productTypeId3 = 0;
        string authentication;

        protected void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (authentication.Equals("C"))
            {
                foreach (var product in lh.getAllProducts())
                {
                    if (productId == product.ProductId)
                    {
                        productTypeId = product.ProductTypeId;
                    }
                }
                lh.addProductToCard(productId, true, productTypeId, true, Convert.ToInt32(Session["Id"]), true, Convert.ToInt32(txtQuantity.Value), true);
                Response.Redirect("ProductCardDetails.aspx");
            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                loginLink.Visible = false;


                userId = Convert.ToInt32(Session["Id"]);
                 authentication = Convert.ToString(Session["authenticationLevel"]);
                if (authentication.Equals("C"))
                {
                    txtQuantity.Visible = true;
                    btnAddOrder.Visible = true;
                }else if (authentication.Equals("M"))
                {
                    btnAddOrder.Text = "Edit product";
                }
            }
            else
            {
                btnAddOrder.Visible = false;
            }
            int.TryParse(Request.QueryString["producttypeId"], out productId);
            lh = new localhost.Service1();
            if (!Page.IsPostBack)
            {
                foreach (var product in lh.getAllProducts())
                {
                    if (productId == product.ProductId)
                    {
                        productTypeId = product.ProductTypeId;
                        _maxQuantity = product.Quantity;
                        // txtQuantity.Disabled;
                        _category = getCategory(product.ProductTypeId);
                        _productCode = _category + product.ProductId;
                        _Price = Math.Round(product.Price, 2);
                        _taxAmount = Math.Round(product.Price * Convert.ToDecimal(0.15), 2);
                        _productPoints = Convert.ToInt32(product.Price) * 100;

                        _shortDescription = product.Description;
                        _fullDescription = "full description";
                        image0.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                        image1.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                        image2.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                        image3.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                    }
                }


                foreach (var product in lh.getAllProducts())//get 1st category
                {
                    foreach (var productTypes in lh.getAllProductTypes())//get other alternative 
                    {
                        if (product.ProductTypeId == productTypes.productTypeId)
                        {
                            if (productId != product.ProductId)
                            {
                                _productId1 = product.ProductId;
                                productId2 = product.ProductId;
                                _fullDescription2 = product.Description;
                                altImage1.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                                _category2 = getCategory(product.ProductTypeId);
                            }
                        }
                    }
                }

                foreach (var product in lh.getAllProducts())//get 2nd category
                {
                    foreach (var productTypes in lh.getAllProductTypes())//get other alternative 
                    {
                        if (product.ProductTypeId == productTypes.productTypeId)
                        {
                            if (productId != product.ProductId && productId2 != product.ProductId)
                            {
                                productId3 = product.ProductId;
                                _productId2 = product.ProductId;
                                _fullDescription3 = product.Description;
                                altImage2.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                                _category3 = getCategory(product.ProductTypeId);
                            }
                        }
                    }
                }
            }

        }

        //protected void btnBuy_Click(object sender, EventArgs e)
        //{
        //    lh.addProductToCard(productId, true, productTypeId, true, Convert.ToInt32(Session["Id"]),true, Convert.ToInt32(txtQuantity.Value),true);
        //    Response.Redirect("ProductCardDetails.aspx");
        //}

        public string getCategory(int productTypeId)
        {
            string category = "";
            foreach (var productTypes in lh.getAllProductTypes())
            {
                if (productTypeId == productTypes.productTypeId)
                {
                    category = productTypes.productCategory;
                }
            }
            return category;
        }
    }
}