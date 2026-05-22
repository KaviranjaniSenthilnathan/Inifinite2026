<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Question2.ProductDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Product App</title>
        <style>
            .container {
            text-align: center;
            margin-top: 50px;
            }
            img {
            margin-top: 20px;
            width: 200px;
            height: 200px;
            }
    </style>

    </head>
    <body>
        <form id="form2" runat="server">
            <div class="container">
                <h2>Select a Product</h2>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Image ID="imgProduct" runat="server" Width="200px" Height="200px" />
                <br />
                <br />
                <asp:Button ID="Pricebtn" runat="server" OnClick="Pricebtn_Click" Text="Price" />
                <br />
                <br />
                <asp:Label ID="price" runat="server" ForeColor="#993333" Text="[Price]"></asp:Label>
                <br />

            </div>

        </form>

    </body>

</html>
 