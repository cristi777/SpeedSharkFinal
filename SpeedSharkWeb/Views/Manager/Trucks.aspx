<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="Trucks.aspx.cs" Inherits="SpeedSharkWeb.Views.Manager.Trucks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-7">
            <asp:Repeater ID="TruckRepeater" runat="server" OnItemCommand="TruckRepeater_ItemCommand">

                <ItemTemplate>

                    <div id="truckTemplate">

                        <b>Truck number:</b>
                        <asp:Label ID="TruckNumberLabel" runat="server" Text='<%# Eval("TruckId") %>'></asp:Label>
                        <br />
                        <b>Truck status:</b>
                        <asp:Label ID="TruckStatusLabel" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                        <br />
                        <asp:Button ID="updateTruck" Text="Update Truck" runat="server" CommandName="truckUpdate" CommandArgument='<%# Eval("TruckId") %>' />


                    </div>

                </ItemTemplate>

            </asp:Repeater>
        </div>

    </div>
    <br />
    <div class="col-md-2 col-md-offset-1">

        <asp:Button ID="createButton" Text="Add new truck" runat="server" OnClick="createButton_Click" />

    </div>


</asp:Content>
