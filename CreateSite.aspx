<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateSite.aspx.cs" Inherits="CreateSite" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="SiteNameLabel" runat="server" Text="Site Name:"></asp:Label>
        <br />
        <asp:TextBox ID="SiteNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="SiteNameTextBox" 
            ErrorMessage="You have to give your site a name" 
            ToolTip="You have to give your site a name"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="SiteNameTextBox" ErrorMessage="Not a valid Site Name" 
            ToolTip="Not a Valid Site Name" ValidationExpression=".*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="CreateSiteButton" runat="server" 
            onclick="CreateSiteButton_Click" Text="Create Site" />
        <br />
        <asp:Label ID="SuccessLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
