<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Map" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="QueryLink" runat="server" 
            NavigateUrl="http://simplegroupfamu.azurewebsites.net/Query.aspx">Query</asp:HyperLink>
        <br />
        <asp:HyperLink ID="phpMyAdminLink" runat="server" 
            NavigateUrl="http://simplegroupfamu.azurewebsites.net/phpMyAdmin/">phpMyAdmin</asp:HyperLink>
        <br />
        <asp:HyperLink ID="FTPhostLink" runat="server" 
            NavigateUrl="ftp://waws-prod-blu-001.ftp.azurewebsites.windows.net/">root</asp:HyperLink>
    </div>
    </form>
</body>
</html>
