<%@ Page Title="" Language="C#" MasterPageFile="~/MSB.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <h1>Login</h1>
<p>
    <asp:Login ID="Login1" runat="server">
    </asp:Login>
</p>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p></p>
    
    <div>
    
        <asp:Label ID="UserNameLabel" runat="server" Text="User Name:"></asp:Label>
        <br />
        <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="UserNameTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>
        <br />
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="PasswordTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Login" />
    
    </div>
  
</asp:Content>
  