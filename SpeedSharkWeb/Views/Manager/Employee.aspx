<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="SpeedSharkWeb.Views.Manager.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-7">
            <asp:Repeater ID="EmployeeRepeater" runat="server" OnItemCommand="EmployeeRepeater_ItemCommand">

                <ItemTemplate>

                    <div>

                        <b>First name:</b>
                        <asp:Label ID="fNameLabel" runat="server" Text='<%# Eval("FName") %>'></asp:Label>
                        <br />
                        <b>Last name:</b>
                        <asp:Label ID="lNameLabel" runat="server" Text='<%# Eval("LName") %>'></asp:Label>
                        <br />
                        <b>Username:</b>
                        <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
                        <br />
                        <b>Type:</b>
                        <asp:Label ID="typeLabel" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                        <br />
                        
                        <asp:Button ID="updateEmployee" Text="Update Employee" runat="server" CommandName="updateEmployee" CommandArgument='<%# Eval("Username") %>' />


                    </div>

                </ItemTemplate>

            </asp:Repeater>
        </div>

    </div>

    <br />
    <div class ="row">
        <div class="col-md-2">

            <asp:Button ID="createButton" Text="Add new employee" runat="server" OnClick="createButton_Click" />

        </div>
    </div>

</asp:Content>
