<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="all.aspx.cs" Inherits="WebApplication1.all" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>all message</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="UserName">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="personnalpage.aspx?id={0}" DataTextField="UserName"  />
                
                <asp:BoundField DataField="DeptName" HeaderText="DeptName" SortExpression="DeptName" />
            </Columns>
           
        </asp:GridView>
       
    </div>
    </form>
</body>
</html>
