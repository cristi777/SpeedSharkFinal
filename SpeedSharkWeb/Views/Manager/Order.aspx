<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="SpeedSharkWeb.Views.Manager.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-6">
            <b> Here you may create an order for a particular use with every particular detail.</b>
            <br />

            <asp:Panel id="createOrderPanel" runat="server" Font-Size="Medium" Font-Name="Arial">

                <p>

                    Customer CVR:
                    <br />
                    <asp:TextBox ID="cvrTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="cvrValidator" runat="server" ErrorMessage="Please specify the CVR of the customer." 
                    ControlToValidate="cvrTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Destination City:
                    <br />
                    <asp:TextBox ID="destCityTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="destCityValidator" runat="server" ErrorMessage="Please specify destination city for the order." 
                    ControlToValidate="destCityTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Destination Address:
                    <br />
                    <asp:TextBox ID="destAddressTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="destAddressValidator" runat="server" ErrorMessage="Please specify destination address for the order." 
                    ControlToValidate="destAddressTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Truck no.:
                    <br />
                    <asp:DropDownList ID="AvailableTrucksDropDown" runat="server" Width="250px" />
                    <br />

                    Departure Time: (YYYY-MM-DD HH:MM)
                    <br />
                    <asp:TextBox ID="depTimeTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="depTimeValidator" runat="server" ErrorMessage="Please specify departure time for the truck." 
                    ControlToValidate="depTimeTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Arrival Time: (YYYY-MM-DD HH:MM)
                    <br />
                    <asp:TextBox ID="arrTimeTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="arrTimeValidator" runat="server" ErrorMessage="Please specify the arrival time for the truck." 
                    ControlToValidate="arrTimeTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Cargo weight: (kg.)
                    <br />
                    <asp:TextBox ID="weightTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="weightValidator" runat="server" ErrorMessage="Please specify the weight of the cargo." 
                    ControlToValidate="weightTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                    Price: (euro)
                    <br />
                    <asp:TextBox ID="priceTxt" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="priceValidator" runat="server" ErrorMessage="Please specify the price the customer has to pay for the order." 
                    ControlToValidate="priceTxt" ValidationGroup="save" ForeColor="Red" />
                    <br />

                </p>

                <asp:Button id="btnCreate" runat="server" Text="Create order" ValidationGroup="save" OnClick="btnCreate_Click" />

            </asp:Panel>

        </div>

    </div>

</asp:Content>
