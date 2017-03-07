<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="BootStrampCheckMate.Registration.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>CheckMate Master Page</title>
    <style>
        .navbar-custom {
            color: #FFFFFF;
            background-color: #ff6a00;
        }
    </style>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <div>
        <div class="navbar navbar-custom navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header" style="padding-left: 500px;">
                    <asp:Image ID="imgsupicon" runat="server" class="img-circle" ImageUrl="~/Images/Icons/images.png" Width="50" /><span class="horz-space" style="font-size: x-large;">Sign Up Here</span>
                </div>
            </div>
        </div>
        <hr />
        <form id="form1" runat="server" style="padding-top: 60px">
            <div class="center-page">
                <table align="center">
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">
                            <br />
                            <label class="col-ms-10">First Name</label>
                        </td>
                        <td style="text-align: right; padding-right: 7px;">
                            <asp:TextBox ID="tbFname" runat="server" class="form-control" placeholder="FirstName"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">
                            <br />
                            <label class="col-ms-10">Last Name</label>
                        </td>
                        <td style="text-align: right">
                            <asp:TextBox ID="tbLname" runat="server" class="form-control" placeholder="LastName"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">
                            <br />
                            <label class="col-ms-10">Password</label>
                        </td>
                        <td style="text-align: right">

                            <asp:TextBox ID="tbPass" runat="server" class="form-control" placeholder="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">
                            <br />
                            <label class="col-ms-10">Confirm Password</label>
                        </td>
                        <td style="text-align: right">

                            <asp:TextBox ID="tbCpass" runat="server" class="form-control" placeholder="Confirm Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">
                            <br />
                            <label class="col-ms-10">Phone Number</label></td>
                        <td style="text-align: right">

                            <asp:TextBox ID="tbPhone" runat="server" class="form-control" placeholder="Phone Number"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">
                            <br />
                            <label class="col-ms-10">Email</label></td>
                        <td style="text-align: right">

                            <asp:TextBox ID="tbEmail" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; padding-right: 7px;">

                            <label class="col-ms-10">Gender</label></td>
                        <td style="text-align: left">

                            <asp:RadioButton ID="rbMale" runat="server" Text="Male" /><asp:RadioButton ID="rbFmale" runat="server" Text="Female" /></td>

                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSignup" runat="server" Width="300" class="btn btn-success" Text="Sign Up" OnClick="btnSignup_Click" />
                            <br />
                            <asp:Label runat="server" ID="lblmsg"></asp:Label>
                        </td>
                    </tr>

                </table>
            </div>
        </form>
    </div>
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>--%>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="../js/bootstrap.min.js"></script>

</body>
</html>
