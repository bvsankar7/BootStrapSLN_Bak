<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ItemCreation.aspx.cs" Inherits="BootStrampCheckMate.ItemCreation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Custom.css" rel="stylesheet" />
    <style>
        .pad {
            margin: 0 auto;
            padding-right: 30px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <%--<div id="nav-admin" style="width: 100%; margin-top: 20px; margin-left: -100px; position: relative;">--%>
        <div id="nav-admin-content" style="text-align: left; position: relative; padding-top: 0px;">
            <div style="text-align: center;">
                <h1 style=" font-size: 30px; font-weight: bold;text-align: center">CheckMate Item Creation Form..</h1>
                <table align="center">
                    <tr>
                        <td style="padding-bottom: 5px">Product Number:
                        </td>
                        <td class="text-left" style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox1" Width="400" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td style="padding-bottom: 5px">Product Name:
                        </td>
                        <td style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox2" Width="400" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="padding-bottom: 5px">Quantity:
                        </td>
                        <td class="text-left" style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox3" Width="400" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                        <td style="padding-bottom: 5px">Rate:
                        </td>
                        <td style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox4" Width="400" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="padding-bottom: 5px">Color:
                        </td>
                        <td class="text-left" style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox5" Width="400" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                        <td style="padding-bottom: 5px">Safty Stock:
                        </td>

                        <td style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox6" Width="400" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="padding-bottom: 5px">Re-Order Point:
                        </td>
                        <td class="text-left" style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox7" Width="400" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>

                        </td>
                        <td style="padding-bottom: 5px">Standard Cost:
                        </td>
                        <td style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox8" Width="400" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="padding-bottom: 5px">Size:
                        </td>
                        <td class="text-left" style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox9" Width="400" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>

                        <td style="padding-bottom: 5px">Weight:
                        </td>
                        <td style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox10" Width="400" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td style="padding-bottom: 5px">Class:
                        </td>
                        <td class="text-left" style="padding-bottom: 5px">
                            <asp:TextBox ID="TextBox11" Width="400" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                        <td style="padding-bottom: 5px">
                            Category Type:
                        </td>
                        <td style="padding-bottom: 5px">
                            <asp:DropDownList ID="DDL_Category" Width="400" runat="server" CssClass="form-control"></asp:DropDownList>
                        </td>

                    </tr>

                    <tr>
                        <td>Description:
                        </td>
                        <td class="auto-style1" colspan="3">
                            <asp:TextBox ID="TextBox12" Width="900" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>

                        </td>
                    </tr>
                </table>
                <br />
                <div style="text-align: center">
                    <asp:Button ID="btn_Ord_create" class="btn btn-success" Width="200" runat="server" Text="Create Order" OnClick="btn_Ord_create_Click" />
                    <asp:Button ID="btn_Ord_Update" class="btn btn-success" Width="200" runat="server" Text="Update Order" OnClick="btn_Ord_Update_Click" />
                    <asp:Button ID="btn_Ord_Delete" class="btn btn-success" Width="200" runat="server" Text="Delete Order" OnClick="btn_Ord_Delete_Click" />
                </div>
                <div style="text-align: center">
                    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                </div>
                <br />
            </div>
            <hr />
            <div>
                <asp:GridView align="center" ID="grd_orders" AutoGenerateColumns="false" runat="server" OnSelectedIndexChanged="OnSelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="ProductNum" HeaderText="Product Number" />
                        <asp:BoundField DataField="Name" HeaderText="Product Name" />
                        <asp:BoundField DataField="Color" HeaderText="Color" />
                        <asp:BoundField DataField="Class" HeaderText="Class" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="Rate" HeaderText="Rate" />
                        <asp:BoundField DataField="Description" HeaderText="Product Description" />
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton Text="Select" ID="lnkSelect" runat="server" CommandName="Select" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
            </div>
        </div>


    </div>
    <%--</div>--%>
</asp:Content>
