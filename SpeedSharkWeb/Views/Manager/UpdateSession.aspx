<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="UpdateSession.aspx.cs" Inherits="SpeedSharkWeb.Views.Manager.UpdateSession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-7">

            <asp:Panel ID="UpdatePanel" runat="server" Font-Size="Medium" Font-Name="Arial">

                <p>

                    Destination city: 
                    <br />
                    <asp:TextBox id="destCityTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="destCityValidator" runat="server" ErrorMessage="Please specify the destination city" 
                    ControlToValidate="destCityTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Destination address:
                    <br />
                    <asp:TextBox ID="destAddTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="destAddValidator" runat="server" ErrorMessage="Please specify the destination address" 
                    ControlToValidate="destAddTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Departure time: (YYYY-MM-DD HH:MM)
                    <br />
                    <asp:TextBox ID="depTimeTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="depTimeValidator" runat="server" ErrorMessage="Please specify the departure time" 
                    ControlToValidate="depTimeTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Arrival time: (YYYY-MM-DD HH:MM)
                    <br />
                    <asp:TextBox ID="arrTimeTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="arrTimeValidator" runat="server" ErrorMessage="Please specify the departure time" 
                    ControlToValidate="arrTimeTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    <asp:Button ID="updateBtn" runat="server" Text="Update Session" ValidationGroup="save" OnClick="updateBtn_Click" />
                    &nbsp;
                    <asp:Button ID="cancelSession" runat="server" Text="Cancel session" OnClick="cancelSession_Click" />
                    &nbsp;
                    <asp:Button ID="cancelAll" runat="server" Text="Cancel/Return" OnClick="cancelAll_Click" />


                </p>

            </asp:Panel>

        </div>

    </div>



</asp:Content>
