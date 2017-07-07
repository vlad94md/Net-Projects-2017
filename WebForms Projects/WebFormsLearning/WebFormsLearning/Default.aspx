<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsLearning._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3><%: Title %>Name:
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </h3>
    <p>
        <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Submit" Width="91px" />
        &nbsp;
        <asp:Label ID="ResultText" runat="server"></asp:Label>
    </p>

</asp:Content>
