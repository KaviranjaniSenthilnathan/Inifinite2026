<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="AddEditMenu.aspx.cs"
    Inherits="FoodOrderManagement.AddEditMenu"
    MasterPageFile="~/Site.Master" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <h3>Add / Edit Menu</h3>

    Name:
    <asp:TextBox ID="txtItemName" runat="server" /><br /><br />

    Category:
    <asp:DropDownList ID="ddlCategory" runat="server">
        <asp:ListItem>Veg</asp:ListItem>
        <asp:ListItem>NonVeg</asp:ListItem>
    </asp:DropDownList><br /><br />

    Price:
    <asp:TextBox ID="txtPrice" runat="server" /><br /><br />

    Quantity:
    <asp:TextBox ID="txtQty" runat="server" /><br /><br />

    Available:
    <asp:CheckBox ID="chkAvailable" runat="server" /><br /><br />

    <asp:Button ID="btnSave" runat="server"
        Text="Save"
        OnClick="btnSave_Click" />

</asp:Content>
