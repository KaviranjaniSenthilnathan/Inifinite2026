<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="FoodOrderManagement.Login" %>

<form runat="server">
    <h3>Login</h3>

    Username:
    <asp:TextBox ID="txtUsername" runat="server" /><br />

    Password:
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br />

    <asp:Button ID="btnLogin" runat="server"
        Text="Login"
        OnClick="btnLogin_Click" />

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
</form>