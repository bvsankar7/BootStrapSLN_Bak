<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SubCategory.aspx.cs" Inherits="BootStrampCheckMate.SubCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 style="font-size: 30px; font-weight: bold; text-align: center;">Create Product Sub Category</h1>
        <table align="center">
            <tr>

                <td style="padding-bottom: 5px">Select Category:
                </td>
                <td class="text-left" style="padding-bottom: 5px">
                    <asp:DropDownList ID="DDl_Product_Category" runat="server" CssClass="form-control"></asp:DropDownList>
                </td>
            </tr>
            <tr>

                <td style="padding-bottom: 5px">Place Category:
                </td>
                <td class="text-left" style="padding-bottom: 5px">
                    <asp:TextBox ID="txt_subcategory" Width="400" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>

                    <asp:Button ID="btn_subCategory" class="btn btn-success" Width="200" runat="server" Text="Create" OnClick="btn_subCategory_Click" />
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
