<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="Sessions.aspx.cs" Inherits="SpeedSharkWeb.Views.Manager.Sessions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <p><b>Currently ongoing sessions:</b></p>
        <div class="col-md-7">
            <asp:Repeater ID="SessionRepeater" runat="server" OnItemCommand="SessionRepeater_ItemCommand" >

                <ItemTemplate>

                    <b> Session no.:</b>
                    <asp:Label ID="SessionIdLabel" runat="server" Text='<%# Eval("SessionId") %>'></asp:Label>
                    <br />
                    <b> Truck no.:</b>
                    <asp:Label ID="TruckIdLabel" runat="server" Text='<%#Eval("TruckId") %>'></asp:Label>
                    &nbsp;
                    <b> Cargo no.:</b>
                    <asp:Label ID="CargoIdLabel" runat="server" Text='<%#Eval("CargoId") %>'></asp:Label>
                    <br />
                    <b> Departure time:</b>
                    <asp:Label ID="DepartureTimeLabel" runat="server" Text='<%#Eval("DepartureTime") %>'></asp:Label>
                    &nbsp;
                    <b> Arrival time:</b>
                    <asp:Label ID="ArrivalTimeLabel" runat="server" Text='<%#Eval("ArrivalTime") %>'></asp:Label>
                    <br />
                    <b> Destination city:</b>
                    <asp:Label ID="DestinationCityLabel" runat="server" Text='<%#Eval("DestCity") %>'></asp:Label>
                    &nbsp;
                    <b> Destination address:</b>
                    <asp:Label ID="DestinationAddressLabel" runat="server" Text='<%#Eval("DestAddress") %>'></asp:Label>
                    <br />
                    <asp:Button ID="updateSession" Text="Update Session" runat="server" CommandName="sessionUpdate" CommandArgument='<%#Eval("SessionId") %>' />

                    

                </ItemTemplate>

            </asp:Repeater>



        </div>

    </div>

</asp:Content>
