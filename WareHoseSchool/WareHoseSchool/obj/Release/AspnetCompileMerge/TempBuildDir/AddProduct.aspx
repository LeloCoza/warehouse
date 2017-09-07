<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="WareHoseSchool.AddProduct" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="registration">
        <div class="registration_left">
            <h2 >Add Product.</h2>

            <div class="registration_form">
                <label for="field-2">Category: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                <div class="form-group">
                    <asp:DropDownList ID="ddlSort" runat="server" AutoPostBack="true" class="form-control" OnSelectedIndexChanged="sort_SelectedIndexChanged">
                    <asp:ListItem  Selected ="True" Value ="Book">Book</asp:ListItem>
                    <asp:ListItem   Value ="Device">Device</asp:ListItem>
                    <asp:ListItem   Value ="Stationary">Stationary</asp:ListItem>
                </asp:DropDownList>
                </div>

                <hr />

                <label for="field-2">Product Type: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                <div class="form-group">
                     <asp:DropDownList ID="DropDownListType" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <hr />

                <label for="field-4">Description: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                <div class="form-group">
                    <textarea name="field-4" id="txtDesc" required="true" runat="server" class="form-control"></textarea>
                </div>

                <label for="field-2">Price: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                <div class="form-group">
                    <input placeholder="" runat="server" type="Double" min="0" tabindex="4" required="" id="txtPrice" />
                </div>

                <label for="field-2">Quantity: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                <div class="form-group">
                    <input placeholder="" runat="server" type="number" tabindex="4" min="1" required="" id="txtQuantity" />
                </div>
                <hr />

                <label for="field-2">Select Image: (required)&nbsp;<span class="at-required-highlight">*</span></label>

                <div class="form-group">
                    <asp:fileupload id="FileUpload1" text="choose image" backcolor="White" bordercolor="White" runat="server" width="180px" />
                </div>

                <div>
                    <asp:button id="btnAdd" runat="server" text="Add Product" OnClick="btnAdd_Click" />
                </div>
                <div>
                    <asp:label id="lblErr" runat="server" visible="false" forecolor="Red"></asp:label>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>
    </div>
</asp:Content>
