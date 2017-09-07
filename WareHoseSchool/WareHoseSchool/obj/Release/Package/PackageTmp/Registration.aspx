<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WareHoseSchool.Registration" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="registration">
        <form class="registration_left">
            <h2 >new user? <span>create an account </span></h2>
            <!-- [if IE] 
		    < link rel='stylesheet' type='text/css' href='ie.css'/>  
		 [endif] -->

            <!-- [if lt IE 7]>  
		    < link rel='stylesheet' type='text/css' href='ie6.css'/>  
		<! [endif] -->
           <%-- <script>
                (function () {

                    // Create input element for testing
                    var inputs = document.createElement('input');

                    // Create the supports object
                    var supports = {};

                    supports.autofocus = 'autofocus' in inputs;
                    supports.required = 'required' in inputs;
                    supports.placeholder = 'placeholder' in inputs;

                    // Fallback for autofocus attribute
                    if (!supports.autofocus) {

                    }

                    // Fallback for required attribute
                    if (!supports.required) {

                    }

                    // Fallback for placeholder attribute
                    if (!supports.placeholder) {

                    }

                    // Change text inside send button on submit
                    var send = document.getElementById('register-submit');
                    if (send) {
                        send.onclick = function () {
                            this.innerHTML = '...Sending';
                        }
                    }

                })();
            </script>--%>
            <div class="registration_form" >
                <!-- Form -->
                <div>
                    <div>
                        <label>
                            <input placeholder="first name:" runat="server" type="text" tabindex="1" required="" autofocus="" id="rtxtFirstName" />
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder="last name:" runat="server" type="text" tabindex="2" required="" autofocus="" id="rtxtLastName" />
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder="email address:" runat="server" type="email" tabindex="3" required="" id="rtxtEmailAdress" />
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder="contact Number:" runat="server" type="text" tabindex="3" required="" id="rtxtcontact" />
                        </label>
                    </div>
                  
                    <div>
                        <label>
                            <input placeholder="password" runat="server" type="password" tabindex="4" required="" id="rtxtPassword" />
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder="retype password" runat="server" type="password" tabindex="4" required="" id="rtxtRePassword" />
                        </label>
                    </div>
                    <div>
                        <asp:Button ID="btnRegister" runat="server" Text="creat accout" OnClick="btnRegister_Click" />
                      </div>
                    <div>
                         <asp:Label ID="lblErr" runat="server" Visible="false" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="sky-form">
                        <label class="checkbox">
                            <input type="checkbox" name="checkbox"/><i></i>i agree to shoppe.com &nbsp;<a class="terms" href="#"> terms of service</a> </label>
                    </div>
                </div>
                <!-- /Form -->
            </div>
        </form>
       <%-- <div class="registration_left">
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
        </div>--%>
        <div class="clearfix"></div>
    </div>
</asp:Content>
