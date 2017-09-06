using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WareHoseSchool
{
    public partial class AddProduct : System.Web.UI.Page
    {
        localhost.Service1 lh;
        protected void Page_Load(object sender, EventArgs e)
        {
            lh = new localhost.Service1();
            if (!Page.IsPostBack)
            {
                typeDropDownlist("Book");
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

        private string getBase64ImageString(Stream fs)
        {
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            string base64ImageString = Convert.ToBase64String(bytes);
            return base64ImageString;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string imageString1 = getBase64ImageString(FileUpload1.PostedFile.InputStream);
            if (imageString1 == "")
            {
                errorMessage("Please choose an image");
            }
            else if(txtPrice.Value== "")
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
                int SelectType = 0;


                int.TryParse(DropDownListType.SelectedValue, out SelectType);
                lh.addProduct(SelectType, true, txtDesc.Value,Convert.ToDouble(txtPrice.Value), true, Convert.ToInt32(txtQuantity.Value), true, imageString1);
                Response.Redirect("Catalog.aspx");
            }
        }

        public void errorMessage(string errorMessage)
        {
            lblErr.Text = errorMessage;
            lblErr.Visible = true;
            return;
        }
    }
}