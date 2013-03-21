<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchSite.aspx.cs" Inherits="SearchSite" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Search Text" Width="135px"></asp:Label>
        <asp:TextBox ID="SiteNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SearchButton" runat="server"
            Text="Search" onclick="SearchButton_Click" />
        <br />
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="getSitesByName" TypeName="DAL.Site">
            <SelectParameters>
                <asp:ControlParameter ControlID="SiteNameTextBox" Name="SiteName" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" 
            Visible="False">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
