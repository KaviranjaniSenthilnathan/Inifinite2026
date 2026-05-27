<%@ Page Language="C#" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <h3>Order Statistics</h3>

    Total Visitors:
    <%: Application["TotalVisitors"] %><br />

    Active Users:
    <%: Application["ActiveUsers"] %>

</asp:Content>
