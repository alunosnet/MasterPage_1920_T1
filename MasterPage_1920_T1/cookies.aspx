<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cookies.aspx.cs" Inherits="MasterPage_1920_T1.cookies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div runat="server" id="divAviso">
    Este site utiliza cookies.
    <asp:Button ID="Button1" runat="server" Text="Aceitar" OnClick="Button1_Click" />
</div>
</asp:Content>
