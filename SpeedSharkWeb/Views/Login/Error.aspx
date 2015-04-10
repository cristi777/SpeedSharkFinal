<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Login/Login.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="SpeedSharkWeb.Views.Login.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-md-6">

            <asp:Panel ID="errorMessagePanel" runat="server" Font-Size="Medium" Font-Name="Arial">

                <p> Your username/password might be incorrect. Please type in again your correct username/password.</p>
                <asp:Button ID="returnButton" runat="server" Text="Return" OnClick="returnButton_Click" />

            </asp:Panel>

        </div>

    </div>

        



    
</asp:Content>
