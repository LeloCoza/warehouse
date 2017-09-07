<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="WareHoseSchool.EditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="women_main">
        <div class="row single">
            <div class="det">
                <div class="single_left">
                    <div class="grid images_3_of_2">
                        <div class="flexslider">
                            <!-- FlexSlider -->
                            <script src="js/imagezoom.js"></script>
                            <script defer="" src="js/jquery.flexslider.js"></script>
                            <link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen">

                            <script>
                                // Can also be used with $(document).ready()
                                $(window).load(function () {
                                    $('.flexslider').flexslider({
                                        animation: "slide",
                                        controlNav: "thumbnails"
                                    });
                                });
                            </script>
                            <!-- //FlexSlider-->



                            <div class="flex-viewport" style="overflow: hidden; position: relative;">
                                <ul class="slides" style="width: 1200%; transition-duration: 0.6s; transform: translate3d(-864px, 0px, 0px);">
                                    <li data-thumb="images/d4.jpg" class="clone" aria-hidden="true" style="width: 288px; float: left; display: block;">
                                        <div class="thumb-image">
                                            <asp:Image ID="image0" runat="server" data-imagezoom="true" class="img-responsive" draggable="false" />
                                        </div>
                                    </li>
                                    <li data-thumb="images/d1.jpg" class="" style="width: 288px; float: left; display: block;">
                                        <div class="thumb-image">
                                            <asp:Image ID="image1" runat="server" data-imagezoom="true" class="img-responsive" draggable="false" />
                                        </div>
                                    </li>
                                    <li data-thumb="images/d2.jpg" style="width: 288px; float: left; display: block;" class="">
                                        <div class="thumb-image">
                                            <asp:Image ID="image2" runat="server" data-imagezoom="true" class="img-responsive" draggable="false" />
                                        </div>
                                    </li>
                                    <li data-thumb="images/d3.jpg" style="width: 288px; float: left; display: block;" class="flex-active-slide">
                                        <div class="thumb-image">
                                            <asp:Image ID="image3" runat="server" data-imagezoom="true" class="img-responsive" draggable="false" />
                                        </div>
                                    </li>

                                </ul>
                            </div>
                            <ul class="flex-direction-nav">
                                <li class="flex-nav-prev"><a class="flex-prev" href="#">Previous</a></li>
                                <li class="flex-nav-next"><a class="flex-next" href="#">Next</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="desc1 span_3_of_2">
                        <h3>store that makes dreams come true</h3>
                        <span class="brand">Category:
                            <div class="form-group">
                                <asp:DropDownList ID="ddlSort" runat="server" AutoPostBack="true" class="form-control" OnSelectedIndexChanged="sort_SelectedIndexChanged">
                                    <asp:ListItem Selected="True" Value="Book">Book</asp:ListItem>
                                    <asp:ListItem Value="Device">Device</asp:ListItem>
                                    <asp:ListItem Value="Stationary">Stationary</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </span>

                        <span class="brand">Type:
                            <div class="form-group">
                                <asp:DropDownList ID="DropDownListType" runat="server" class="form-control"></asp:DropDownList>
                            </div>

                        </span>

                        <span class="brand">Description:
                            <div class="form-group">
                                <textarea name="field-4" id="txtDesc" required="true" runat="server" class="form-control"></textarea>
                            </div>
                        </span>

                        <span class="brand">Select Image:
                            <div class="form-group">
                                <asp:FileUpload ID="FileUpload1" text="choose image" BackColor="White" BorderColor="White" runat="server" Width="50%" />
                            </div>

                        </span>

                        <div class="price">
                            <span class="text">Price:<input style="height: 22px; margin-left: 125px; width: 210px; margin-bottom: 20px" placeholder="" runat="server" type="number" min="0.01" step="0.01" tabindex="4" required="" id="txtPrice" /></span>

                        </div>

                        <div class="price">
                            <span class="text">Select a quantity:<input style="height: 22px; margin-left: 27px; width: 210px; margin-bottom: 100px" placeholder="" runat="server" type="number" min="0" tabindex="4" required="" id="txtQuantity" /></span>

                        </div>


                        <%-- <div class="price">
                            <h4>Select a quantity :
                                <input  type="number" runat="server" tabindex="4"  " min="1" required="" id="txtQuantity" /></h4>
                        </div>--%>
                        <div class="registration_form">
                            <asp:Button ID="btnEdit" runat="server" Text="Save" OnClick="btnEdit_Click" />
                        </div>
                        <div>
                            <asp:Label ID="lblErr" runat="server" Visible="false" ForeColor="Red"></asp:Label>
                        </div>

                    </div>
                    <div class="clearfix"></div>

                </div>
            </div>
        </div>
    </div>


</asp:Content>
