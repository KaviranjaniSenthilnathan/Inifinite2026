<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsForm.aspx.cs" Inherits="Question1.DetailsForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style type="text/css">.auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 503px;
            text-align: center;
            height: 58px;
        }
        .auto-style3 {
            width: 503px;
            height: 31px;
            text-align: center;
        }
        .auto-style4 {
            height: 31px;
        }
        .auto-style5 {
            width: 249px;
            height: 58px;
        }
        .auto-style6 {
            height: 31px;
            width: 249px;
        }
        .auto-style7 {
            width: 85px;
            height: 58px;
        }
        .auto-style8 {
            height: 31px;
            width: 85px;
        }
        .auto-style9 {
            height: 58px;
        }
        .auto-style10 {
            height: 58px;
            width: 625px;
        }
        .auto-style11 {
            height: 31px;
            width: 625px;
        }
    </style>

    </head>
    <body>
        <form id="form1" runat="server">
            <p style="text-align: center">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="ENTER YOUR DETAILS"></asp:Label>

            </p><p style="text-align: center">&nbsp;</p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                    </td>
                    <td class="auto-style5">
                        <br />                    
                        NAME<br />
                        <br />

                    </td>
                    <td class="auto-style7">:</td>
                    <td class="auto-style10"><asp:TextBox ID="Name" runat="server" Height="35px" Width="215px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" ErrorMessage="*Name is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="NameValidator" runat="server" ControlToValidate="Name" ErrorMessage="Enter your name" ForeColor="White" OnServerValidate="NameValidator_ServerValidate"></asp:CustomValidator>

                    </td>
                    <td class="auto-style9">

                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">
                        <br />                   
                        FAMILY NAME<br />
                        <br />

                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="FamilyName" runat="server" Height="35px" Width="215px"></asp:TextBox>
                        <asp:CompareValidator ID="NameCompare" runat="server" ControlToCompare="Name" ControlToValidate="FamilyName" ErrorMessage="*Name and Family name should be different" ForeColor="#CC0000" Operator="NotEqual"></asp:CompareValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FamilyName" ErrorMessage="*Family name is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                    </td><td class="auto-style4">&nbsp;</td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">
                        <br />                    
                        ADDRESS<br />
                        <br />

                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="Address" runat="server" Height="35px" Width="215px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="AddressValidate" runat="server" ControlToValidate="Address" ErrorMessage="*Enter valid  address" ForeColor="#CC0000" ValidationExpression="[a-zA-Z0-9\s,./-]{2,}"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Address" ErrorMessage="*Address is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                    </td>
                    <td class="auto-style4">&nbsp;</td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6"><br />                    
                        CITY<br /><br />

                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="City" runat="server" Height="35px" Width="215px"></asp:TextBox><asp:RegularExpressionValidator ID="CityValidate" runat="server" ControlToValidate="City" ErrorMessage="*Enter valid city" ForeColor="#CC0000" ValidationExpression="[a-zA-Z]{2,}"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="City" ErrorMessage="*City is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                    </td>
                    <td class="auto-style4">&nbsp;</td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6"><br />
                        ZIP CODE<br />
                        <br />

                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="Zip" runat="server" Height="35px" Width="215px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="ZipValidate" runat="server" ControlToValidate="Zip" ErrorMessage="*Enter valid zip code" ForeColor="#CC0000" ValidationExpression="[0-9]{6}"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Zip" ErrorMessage="*ZIpcode is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                    </td>
                    <td class="auto-style4">&nbsp;</td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">
                        <br />                    
                        PHONE NUMBER<br />
                        <br />

                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="Number" runat="server" Height="35px" Width="215px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="NumberValidate" runat="server" ControlToValidate="Number" ErrorMessage="*Enter valid phone number" ForeColor="#CC0000" ValidationExpression="[6-9][0-9]{9}"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Number" ErrorMessage="*Phone number is required" ForeColor="#CC0000"></asp:RequiredFieldValidator></td><td class="auto-style4">&nbsp;</td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">
                        <br />                    
                        EMAIL<br />
                        <br />

                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="Email" runat="server" Height="35px" Width="215px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="EmailValidate" runat="server" ControlToValidate="Email" ErrorMessage="*Enter valid email address" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Email" ErrorMessage="*Email is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="CheckButton" runat="server" OnClick="CheckButton_Click" Text="Check" Height="35px" Width="120px" />

                    </td>

                </tr>

            </table>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Validation summary" Height="126px" ShowMessageBox="True" ShowSummary= "true" Width="470px" />

        </form>
    </body>
 </html>
 