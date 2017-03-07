<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BootStrampCheckMate.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>CheckMate2017</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .navbar-custom {
            color: #FFFFFF;
            background-color: #ff6a00;
        }
    </style>
</head>
<body>
    <div class="navbar navbar-custom navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header" style="padding-left: 450px;">
                <asp:Image ID="imgsupicon" runat="server" class="img-circle" ImageUrl="~/Images/Icons/adminicon.jpg" Width="50" /><span class="horz-space" style="font-size: x-large;">Login As Admin  !!</span>
            </div>
        </div>
    </div>
    <hr />
    <form id="form1" runat="server" style="padding-top: 60px">
        <div class="center-page">
            <table align="center">
                <tr>
                    <td>
                        <label class="col-xs-11">User Name</label>
                        <div class="col-xs-11">
                            <asp:TextBox ID="tbUname" runat="server" class="form-control" placeholder="User Name"></asp:TextBox>
                        </div>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label class="col-xs-11">Password</label>
                        <div class="col-xs-11">
                            <asp:TextBox ID="tbPass" runat="server" class="form-control" placeholder="Password"></asp:TextBox>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <div class="col-xs-11 space-vertical">
                            <asp:CheckBox ID="rbRem" runat="server" Text="Remember Me" />
                            <asp:Button ID="btnLogin" runat="server" class="btn btn-success" Width="250" Text="Login" OnClick="btnLogin_Click" />
                            <asp:Button ID="btnCancel" runat="server" class="btn btn-warning" Width="80" Text="Cancel" />
                        </div>

                    </td>

                </tr>
                <tr>
                    <td>
                        <div class="col-xs-11">
                        </div>
                        <div class="col-xs-9" style="width: 500px">
                            <p>
                                <asp:LinkButton ID="LnkRegbtn" runat="server" OnClick="LnkRegbtn_Click">Click Here To Register</asp:LinkButton>&nbsp If you do not have UserName and Password Or<asp:LinkButton ID="ResetPasswd" runat="server" OnClick="ResetPasswd_Click">Change</asp:LinkButton>&nbsp Password.
                            </p>
                            <br />
                            <asp:Label runat="server" ID="lblmsg"></asp:Label>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>

</body>
</html>
