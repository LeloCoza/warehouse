<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WareHoseSchool.ProductDetails" %>

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
                                            <asp:Image id="image0" runat="server" data-imagezoom="true" class="img-responsive" draggable="false"/>
                                        </div>
                                    </li>
                                    <li data-thumb="images/d1.jpg" class="" style="width: 288px; float: left; display: block;">
                                        <div class="thumb-image">
                                            <asp:Image id="image1" runat="server"  data-imagezoom="true" class="img-responsive" draggable="false"/>
                                        </div>
                                    </li>
                                    <li data-thumb="images/d2.jpg" style="width: 288px; float: left; display: block;" class="">
                                        <div class="thumb-image">
                                            <asp:Image id="image2" runat="server"  data-imagezoom="true" class="img-responsive" draggable="false"/>
                                        </div>
                                    </li>
                                    <li data-thumb="images/d3.jpg" style="width: 288px; float: left; display: block;" class="flex-active-slide">
                                        <div class="thumb-image">
                                            <asp:Image id="image3" runat="server"  data-imagezoom="true" class="img-responsive" draggable="false"/>
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
                        <span class="brand">Category: <a href="#"><%=_category %></a></span>
                        <br>
                        <span class="code">Product Code: <%=_productCode%></span>
                        <p><%=_shortDescription %>. </p>
                        <div class="price">
                            <span class="text">Price:</span>
                            <span class="price-new">R<%=_Price %></span><span class="price-old">$100.00</span>
                            <span class="price-tax">Ex Tax: <%=_taxAmount %></span><br>
                            <span class="points"><small>Price in reward points: <%=_productPoints %></small></span><br>
                        </div>
                        <div class="det_nav1">
                            <h4>Select a quantity(<%=_maxQuantity %>) : <input placeholder="0" runat="server" visible="false" type="number" tabindex="4" width="5px" max="<%=_maxQuantity %>" min="1" required="" id="txtQuantity" /></h4>
                            <div class=" sky-form col col-4">
                               <%-- <ul>
                                    <li>
                                        <label class="checkbox">FBrand
                                            <input type="checkbox" name="checkbox"/><i></i>L</label></li>
                                    <li>
                                        <label class="checkbox">
                                            <input type="checkbox" name="checkbox"/><i></i>S</label></li>
                                    <li>
                                        <label class="checkbox">
                                            <input type="checkbox" name="checkbox"/><i></i>M</label></li>
                                    <li>
                                        <label class="checkbox">
                                            <input type="checkbox" name="checkbox"/><i></i>XL</label></li>
                                </ul>--%>
                            </div>
                        </div>
                        <div class="registration_form">
                                 <asp:Button ID="btnAddOrder" runat="server" Visible="false" Text="Add to card" OnClick="btnAddOrder_Click" />
                                    <asp:Button ID="btnEdit" runat="server" Visible="false" Text="editProduct" />
                             </div>
                        
                             <a id="loginLink" runat="server" href="Login.aspx"><span>login to save in wishlist </span></a>
                         
            </div>
            <div class="clearfix"></div>
               
                <div class="single-bottom1">
                    <h6>Details</h6>
                    <p class="prod-desc"> <%=_fullDescription %>. </p>
                </div>
                <div class="single-bottom2">
                    <h6>Related Products</h6>
                    <div class="product">
                        <div class="product-desc">
                            <div class="product-img">
                                <asp:Image id="altImage1" runat="server" class="img-responsive " alt=""/>
                            </div>
                            <div class="prod1-desc">
                                <h5><a class="product_link" href="ProductDetails.aspx?producttypeId=" + <%=_productId1 %> + "> <%=_category2 %></a></h5>
                                <p class="product_descr"><%=_fullDescription2 %>. </p>
                            </div>
                            <div class="clearfix"></div>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                    <div class="product">
                        <div class="product-desc">
                            <div class="product-img">
                                <asp:Image id="altImage2" runat="server" class="img-responsive " alt=""/>
                            </div>
                            <div class="prod1-desc">
                                <h5><a class="product_link" href="ProductDetails.aspx?producttypeId=" + <%=_productId2 %> + "> <%=_category3 %></a></h5>
                                <p class="product_descr"><%=_fullDescription3 %>. </p>
                            </div>
                            <div class="clearfix"></div>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
