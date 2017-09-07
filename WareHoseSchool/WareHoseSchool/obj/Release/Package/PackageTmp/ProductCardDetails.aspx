<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ProductCardDetails.aspx.cs" Inherits="WareHoseSchool.ProductCardDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="check">
        <div class="col-md-3 cart-total">
            <a class="continue" href="Catalog.aspx">Continue to basket</a>
            <div class="price-details">
                <h3>Price Details</h3>
                <span>Total</span>
                <span class="total1"><%=_priceOfItems %></span>
                <span>Discount</span>
                <span class="total1">---</span>
                <span>Delivery Charges</span>
                <span class="total1">(40.00*<%=_numItems %>)</span>
                <span class="total1">.</span>
                 <span class="total1">(<%=_totalCharges %>)</span>
                <div class="clearfix"></div>
            </div>
            <ul class="total_price">
                <li class="last_price">
                    <h4>TOTAL</h4>
                </li>
                <li class="last_price"><span><%=_TotalPrice %></span></li>
                <div class="clearfix"></div>
            </ul>


            <div class="clearfix"></div>
            <div class="registration_form">
             <asp:Button ID="btnOrder" runat="server" Text="Place Order" Font-Size="1em" Font-Bold="true" Width="100%" OnClick="btnOrder_Click"/>
                </div>
            <div class="total-item">
                <h3 >OPTIONS</h3>
                <h4>COUPONS</h4>
                <a class="cpns" href="#">Apply Coupons</a>
                <p><a href="Registration.aspx">Log In</a> to use accounts - linked coupons</p>
            </div>
        </div>

        <%--<script>$(document).ready(function (c) {
    $('.close1').on('click', function (c) {
        $('.cart-header').fadeOut('slow', function (c) {
            $('.cart-header').remove();
        });
    });
});
        </script>--%>
        <div id="CardList" runat="server" class="col-md-9 cart-items">
            <%--<h1>My Shopping Bag (2)</h1>--%>

            <%-- <div class="cart-header">
                <div class="close1"></div>
                <div class="cart-sec simpleCart_shelfItem">
                    <div class="cart-item cyc">
                        <img src="images/8.jpg" class="img-responsive" alt="">
                    </div>
                    <div class="cart-item-info">
                        <h3><a href="#">Mountain Hopper(XS R034)</a><span>Model No: 3578</span></h3>
                        <ul class="qty">
                            <li>
                                <p>Size : 5</p>
                            </li>
                            <li>
                                <p>Qty : 1</p>
                            </li>
                        </ul>

                        <div class="delivery">
                            <p>Service Charges : Rs.100.00</p>
                            <span>Delivered in 2-3 bussiness days</span>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                    <div class="clearfix"></div>

                </div>
            </div>
            <script>$(document).ready(function (c) {
    $('.close2').on('click', function (c) {
        $('.cart-header2').fadeOut('slow', function (c) {
            $('.cart-header2').remove();
        });
    });
});
            </script>
            <div class="cart-header2">
                <div class="close2"></div>
                <div class="cart-sec simpleCart_shelfItem">
                    <div class="cart-item cyc">
                        <img src="images/11.jpg" class="img-responsive" alt="">
                    </div>
                    <div class="cart-item-info">
                        <h3><a href="#">Mountain Hopper(XS R034)</a><span>Model No: 3578</span></h3>
                        <ul class="qty">
                            <li>
                                <p>Size : 5</p>
                            </li>
                            <li>
                                <p>Qty : 1</p>
                            </li>
                        </ul>
                        <div class="delivery">
                            <p>Service Charges : Rs.100.00</p>
                            <span>Delivered in 2-3 bussiness days</span>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                    <div class="clearfix"></div>

                </div>
            </div>--%>
        </div>


        <div class="clearfix"></div>
    </div>
</asp:Content>
