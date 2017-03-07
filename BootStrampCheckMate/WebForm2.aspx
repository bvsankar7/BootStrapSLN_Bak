<%@ Page Title="" Language="C#" MasterPageFile="~/BootStrapCheckMate.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BootStrampCheckMate.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="Button2" Text="Back to Gallery" runat="server" onclick="Button1_Click" />
<br />
    <hr />
<asp:Image ID="Image1" Width="800px" Height="550px" runat="server" />
<br /><br />
<asp:Button ID="Button1" Text="Back to Gallery" runat="server" onclick="Button1_Click" />
</asp:Content>
