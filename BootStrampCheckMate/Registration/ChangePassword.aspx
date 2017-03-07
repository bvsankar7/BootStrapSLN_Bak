<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="BootStrampCheckMate.Registration.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="login">
            <div id="header">
                <h3>Change your Password here..!</h3>
            </div>
            <div class="formclass">
                <table>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNewPassword" TextMode="Password" placeholder="New Password"
                                runat="server" CssClass="input"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPassword"
                                runat="server" ErrorMessage="New Password required"
                                Text="*" ControlToValidate="txtNewPassword" ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:TextBox ID="txtConfirmNewPassword" TextMode="Password" placeholder="Confirm New Password" CssClass="input" runat="server">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmNewPassword"
                                runat="server" ErrorMessage="Confirm New Password required" Text="*"
                                ControlToValidate="txtConfirmNewPassword"
                                ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                                ErrorMessage="New Password and Confirm New Password must match"
                                ControlToValidate="txtConfirmNewPassword" ForeColor="Red"
                                ControlToCompare="txtNewPassword"
                                Display="Dynamic" Type="String" Operator="Equal" Text="*">
                            </asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>

                        <td style="text-align: right; padding-right: 15px;">
                            <asp:Button ID="btnSave" runat="server" CssClass="input"
                                Text="Save" OnClick="btnSave_Click" Width="70px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMessage" runat="server">
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ValidationSummary ID="ValidationSummary1"
                                ForeColor="Red" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
