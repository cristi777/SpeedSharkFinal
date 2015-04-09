<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Login/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SpeedSharkWeb.Views.Login.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-6">

            <asp:Panel ID="LoginPanel" runat="server" Font-Size="Medium" Font-Name="Arial">

                <p>

                    Username:
                    <br />
                    <asp:TextBox ID="usernameTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="usernameFieldValidator" runat="server" ErrorMessage="Please specify your username" 
                    ControlToValidate="usernameTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Password:
                    <br />
                    <asp:TextBox ID="passwordTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="passwordFieldValidator" runat="server" ErrorMessage="Please specify your password"
                    ControlToValidate="passwordTxt" ValidationGroup="save" ForeColor="Red" />

                </p>

                <asp:Button ID="btnLogin" runat="server" Text="Login" ValidationGroup="save" OnClick="btnLogin_Click" />                

            </asp:Panel>

        </div>

    </div>



    
</asp:Content>
