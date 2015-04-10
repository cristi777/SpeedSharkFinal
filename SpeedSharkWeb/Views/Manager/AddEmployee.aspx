<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="SpeedSharkWeb.Views.Manager.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        
        <div class="col-md-7">
            
            <asp:Panel runat="server" ID="AddEmployeePanel" DefaultButton="btnAddEmployee" Font-Size="Medium" Font-Name="Arial">
                
                <b>First Name:</b>
                <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="firstNameFieldValidator" ErrorMessage="Please specify the employee First Name" ControlToValidate="txtFirstName" ValidationGroup="save" ForeColor="Red"/>
                <br/>
                
                <b>Last Name:</b>
                <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="lastNameFieldValidator" ErrorMessage="Please specify the employee Last Name" ControlToValidate="txtLastName" ValidationGroup="save" ForeColor="Red"/>
                <br/>
                
                <b>Username:</b>
                <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Please specify the employee username" ControlToValidate="txtUsername" ValidationGroup="save" ForeColor="Red"/>
                <br/>
                
                <b>Password:</b>
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="passwordFieldValidator" ErrorMessage="Please specify the employee password" ControlToValidate="txtPassword" ValidationGroup="save" ForeColor="Red"/>
                <br/>
                
                <b>Type:</b>
                <asp:TextBox runat="server" ID="txtType"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="typeFieldValidator" ErrorMessage="Please specify the employee type" ControlToValidate="txtType" ValidationGroup="save" ForeColor="Red"/>
                <br/>
                
                <asp:Button runat="server" ID="btnAddEmployee" Text="Create" OnClick="btnAddEmployee_OnClick" ValidationGroup="save"/>

            </asp:Panel>

        </div>

    </div>

    
        
        
        
        
        
        
        
        
        
   
</asp:Content>
