<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CSSPractice.aspx.cs" Inherits="BootStrampCheckMate.CSSPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSSPractice.css" rel="stylesheet" />
</head>
<body>
    <nav class='navClass'>
        <ul>
            <li>Car
                <ul class="sub-menu">
                    <li><a href="Login.aspx"> Toyota</a></li>
                    <li><a href="Registration/RegistrationPage.aspx">Honda</a></li>
                    <li><a href="#">Ford</a></li>
                </ul>
                <span class="arrow">&#9660;</span>
            </li>
            <li>Computer
                <ul class="sub-menu">
                    <li>Mac</li>
                    <li>PC</li>

                </ul>
                <span class="arrow">&#9660;</span>
            </li>
            <li>Drink</li>
        </ul>

    </nav>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" /><br />
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </form>
</body>
</html>
