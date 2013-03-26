<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateDeveloper.aspx.cs" Inherits="CreateDeveloper" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Create Developer</h2>
    <br />
    <asp:Label ID="UserNameLabel" runat="server" Text="Desired User Name:"></asp:Label>
    <div>
    
        <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="UserNameTextBox" ErrorMessage="Please enter a user name." 
            ToolTip="Please enter a user name."></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Desired Password:"></asp:Label>
        <br />
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="PasswordTextBox" ErrorMessage="Please enter a password." 
            ToolTip="Please enter a password."></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password:"></asp:Label>
        <br />
        <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="ConfirmPasswordTextBox" 
            ErrorMessage="Please confirm your password." 
            ToolTip="Please confirm your password."></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="ConfirmPasswordCompareValidator" runat="server" 
            ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" 
            ErrorMessage="Passwords Must Match" ToolTip="Passwords Must Match"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" onclick="RegisterButton_Click" 
            Text="Register" />
        <br />
        <asp:Label ID="SuccessLabel" runat="server"></asp:Label>
    
    </div>
    
    </div>
    </form>
</body>
</html>
