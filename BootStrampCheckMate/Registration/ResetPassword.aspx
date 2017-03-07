<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="BootStrampCheckMate.Registration.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="lowin">
                <div id="header">
                    <h3>Reset Password</h3>
                </div>
                <div class="formclass">
                    <table>

                        <tr>
                            <td>
                                <asp:TextBox ID="txtUserName" runat="server" CssClass="input" placeholder="User Name">
                                </asp:TextBox>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="input" placeholder="Please Enter Registered Email">
                                </asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                <asp:Button ID="btnResetPassword" runat="server"
                                    Text="Reset Password" CssClass="input" OnClick="btnResetPassword_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>

                </div>
            </div>
            <hr />
            <br />
            <div id="slidimg">
            </div>
        </div>
    </form>
</body>
</html>
