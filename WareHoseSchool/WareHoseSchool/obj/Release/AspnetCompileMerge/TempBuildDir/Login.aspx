<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WareHoseSchool.Login" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="registration" >
     <div class="registration_left">
            <h2>existing user</h2>
            <div class="registration_form">
                <!-- Form -->
                <div>
                    <div>
                        <label>
                            <input placeholder="email:" runat="server" type="email" tabindex="3" required="" id="txtEmail" />
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder="password" runat="server" type="password" tabindex="4" required="" id="txtPassword" />
                        </label>
                    </div>
                    <div>
                       <asp:Button ID="btnLogin" runat="server" Text="sign In" OnClick="btnLogin_Click" />
                    </div>
                    <div>
                         <asp:Label ID="Label2" runat="server" Visible="false" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="forget">
                        <a href="#">forgot your password</a>
                    </div>
                </div>
                <!-- /Form -->
            </div>
        </div>
        <div class="clearfix"></div>
    </div>

</asp:Content>
