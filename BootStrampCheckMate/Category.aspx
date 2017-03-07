<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="BootStrampCheckMate.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 style="font-size: 30px; font-weight: bold; text-align: center;">Create Product Category</h1>
        <table align="center">
            <tr>

                <td style="padding-bottom: 5px">Category Name:
                </td>
                <td class="text-left" style="padding-bottom: 5px">
                    <asp:TextBox ID="txt_category" Width="400" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>

                    <asp:Button ID="btn_Category" class="btn btn-success" Width="200" runat="server" Text="Create" OnClick="btn_Category_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>

                    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
