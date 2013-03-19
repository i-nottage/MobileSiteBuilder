<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Query.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Administrator</h3>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="getAllAdministrators" TypeName="DAL.Administrator">
        </asp:ObjectDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>
        <br />
        <br />
        <h3>Developer</h3>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="getAllDevelopers" TypeName="DAL.Developer">
            </asp:ObjectDataSource>
        </p>
        <asp:GridView ID="GridView3" runat="server" DataSourceID="ObjectDataSource2">
        </asp:GridView>
        <br />
        <br />
        <h3>Site</h3>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
                SelectMethod="getAllSites" TypeName="DAL.Site"></asp:ObjectDataSource>
        </p>
        <asp:GridView ID="GridView4" runat="server" DataSourceID="ObjectDataSource3">
        </asp:GridView>
        <br />
        <br />
        <h3>Page</h3>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" 
                SelectMethod="getAllPages" TypeName="DAL.Page"></asp:ObjectDataSource>
        </p>
        <p>
            <asp:GridView ID="GridView5" runat="server" DataSourceID="ObjectDataSource4">
            </asp:GridView>
        </p>
        <br />
        <br />
        <h3>Text</h3>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" 
                SelectMethod="getAllText" TypeName="DAL.Text"></asp:ObjectDataSource>
        </p>
        <p>
            <asp:GridView ID="GridView6" runat="server" DataSourceID="ObjectDataSource5">
            </asp:GridView>
        </p>
        <br />
        <br />
        <h3>Link</h3>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" 
                SelectMethod="getAllLinks" TypeName="DAL.Link"></asp:ObjectDataSource>
        </p>
        <p>
            <asp:GridView ID="GridView7" runat="server" DataSourceID="ObjectDataSource6">
            </asp:GridView>
        </p>
        <br />
        <br />
        <h3>Image</h3>
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" 
                SelectMethod="getAllImages" TypeName="DAL.Image"></asp:ObjectDataSource>
        </p>
        <p>
            <asp:GridView ID="GridView8" runat="server" DataSourceID="ObjectDataSource7">
            </asp:GridView>
        </p>
        <asp:Repeater ID="AdminRepeater" runat="server">
        <HeaderTemplate>
        <tr bgcolor=green>
            <th>Adminstrator_ID</th>
            <th>Administrator_UserName</th>
            <th>Administrator_Password</th>
        </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <td> <%#DataBinder.Eval(Container.DataItem, "Administrator_ID")%></td>
            <td> <%#DataBinder.Eval(Container.DataItem, "Administrator_UserName")%></td>
            <td> <%#DataBinder.Eval(Container.DataItem, "Administrator_Password")%></td>

        </ItemTemplate>
        </asp:Repeater>
        <asp:Label ID="DataLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LblError" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
