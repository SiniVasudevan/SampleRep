<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" MasterPageFile="~/Site.Master" Inherits="MyApp.Test" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    THIS IS SECOND PAGE
  <div class="row">
        UserName : <asp:Label ID="Label1" runat="server" Text="lblName"></asp:Label>  <br />
    
        EMail    : <asp:Label ID="Label2" runat="server" Text="IblEmail"></asp:Label> 

        <br />

        <asp:Label ID="Message" runat="server" ForeColor="Red" font-bold ="true"></asp:Label> 


 </div>
</asp:Content>