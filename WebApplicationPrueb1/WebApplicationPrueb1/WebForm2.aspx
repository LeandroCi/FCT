<%@ Page Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplicationPrueb1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">

    <asp:Label ID="Label1" runat="server" Text="DNI"></asp:Label>
    <asp:DropDownList ID="DropDownList1" DataSourceID="SqlDataSource1" runat="server" DataValueField="dni" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" Height="21px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    SelectCommand="SELECT * FROM personas" 
    ConnectionString="Server=localhost\SQLEXPRESS01;Database=Prueba;Trusted_Connection=True;" />
    <div><br /></div>
    
    <asp:GridView ID="GridView1" runat="server"/>

</asp:Content>
