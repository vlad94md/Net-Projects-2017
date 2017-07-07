<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsLearning.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
    </p>
</asp:Content>
