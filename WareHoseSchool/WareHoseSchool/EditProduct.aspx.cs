using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class EditProduct : System.Web.UI.Page
    {
        string authentication;
        int userId, productId;
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
            if (Session["Id"] != null)
            {
                userId = Convert.ToInt32(Session["Id"]);
                authentication = Convert.ToString(Session["authenticationLevel"]);
                int.TryParse(Request.QueryString["producttypeId"], out productId);
                if (authentication.Equals("M"))
                {
                    if (!Page.IsPostBack)
                    {
                        foreach (var product in lh.getAllProducts())
                        {
                            if (productId == product.ProductId)
                            {
                                txtDesc.Value = product.Description;
                                txtQuantity.Value = Convert.ToString(product.Quantity);
                                txtPrice.Value = Convert.ToString(product.Price);

                                image0.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                                image1.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                                image2.ImageUrl = "data:image/pgn;base64," + product.Image64String;
                                image3.ImageUrl = "data:image/pgn;base64," + product.Image64String;

                                foreach (var productType in lh.getAllProductTypes())
                                {
                                    if(productType.productTypeId== product.ProductTypeId)
                                    {
                                        typeDropDownlist(productType.productCategory);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Response.Redirect("Catalog.aspx");
                }
            }
            else
            {
                Response.Redirect("Catalog.aspx");
            }
        }

        protected void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = ddlSort.SelectedItem.Value;
            if (selected.Equals("Book"))
            {
                typeDropDownlist("Book");
            }
            else if (selected.Equals("Device"))
            {
                typeDropDownlist("Device");
            }
            else if (selected.Equals("Stationary"))
            {
                typeDropDownlist("Stationary");
            }
        }


        private void typeDropDownlist(string category)
        {
            DropDownListType.Items.Clear(); //clear the dropdown 
            string typename = "";
            foreach (var productTypes in lh.getAllProductTypes())
            {
                if (category.Equals(productTypes.productCategory))
                {
                    typename = productTypes.productTypeName;
                    DropDownListType.Items.Add(new ListItem(typename, productTypes.productTypeId.ToString()));
                }

            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string imageString1 = getBase64ImageString(FileUpload1.PostedFile.InputStream);
            
            if (txtPrice.Value == "")
            {
                errorMessage("Please enter the price");
            }
            else if (txtQuantity.Value == "")
            {
                errorMessage("Please enter the Quantity");
            }
            else if (txtDesc.Value == "")
            {
                errorMessage("Please enter the description");
            }
            else
            {
                if (imageString1 == "")
                {
                    foreach (var product in lh.getAllProducts())
                    {
                        if (productId == product.ProductId)
                        {
                            imageString1 = product.Image64String;
                        }
                    }
                }
                int SelectType = 0;

                int.TryParse(Request.QueryString["producttypeId"], out productId);
                int.TryParse(DropDownListType.SelectedValue, out SelectType);
                lh.updateProduct(productId,true,SelectType, true, txtDesc.Value, Convert.ToDouble(txtPrice.Value), true, Convert.ToInt32(txtQuantity.Value), true, imageString1);
                Response.Redirect("Catalog.aspx");
            }
        }

        private string getBase64ImageString(Stream fs)
        {
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            string base64ImageString = Convert.ToBase64String(bytes);
            return base64ImageString;
        }

        public void errorMessage(string errorMessage)
        {
            lblErr.Text = errorMessage;
            lblErr.Visible = true;
            return;
        }
    }
}