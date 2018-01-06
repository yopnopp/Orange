<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="GuestBook._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET by Melanie Brunk!
    </h2>
    <h3>Here you will find a simple website that you can Log In to.</h3>
    <p>
        &nbsp;</p>
Enter Visitor name:
<asp:TextBox ID="txtName" runat="server" Width="290px"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Height="46px" onclick="Button1_Click" 
    Text="Submit" Width="141px" />
</asp:Content>
