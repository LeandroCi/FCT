<%@ Page Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationPrueb1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
        <asp:Label ID="Label2" runat="server" Text=" "></asp:Label>
</asp:Content>
