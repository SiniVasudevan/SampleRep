<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    THIS IS FIRST PAGE
    <div class="jumbotron">
      
        <asp:Label ID="Label1" runat="server" Text="User"></asp:Label> &nbsp; &nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="183px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label> &nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="171px"></asp:TextBox>
         <br />
        <asp:Button ID="Button1" runat="server" Text="Go To Page2" Width="146px" OnClick="Button1_Click" />

         <br />


    </div>

   
  

</asp:Content>
