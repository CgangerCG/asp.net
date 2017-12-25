<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>LOGIN(登录)</title>
</head>
<body><hr /><center><div>
    <h1 style="font-size:25px">登录</h1>
    <hr style="border-color:#808080; border-width:11px" />
    <form id="Form1" name="frmLogin" method="post" runat="server" >  
 <table  >  
 <tr>  
 <td>用户名</td>  
 <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>  
 <td > </td>  
 <td> 
 <asp:RequiredFieldValidator ID="ifvalid" runat="server" ControlToValidate="username" ErrorMessage="valid" Display="Dynamic" ></asp:RequiredFieldValidator></td>  
 </tr>  
 <tr>  
 <td>密码</td>  
 <td><asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>  
 <td> </td>  
 <td> 
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="password" runat="server" ErrorMessage="Valid" Display="Dynamic"></asp:RequiredFieldValidator></td>  
 </tr>   
 <tr>  
 <td><input type="checkbox"  name="zlogin" value="1"/>自动登录</> </td> 
 </tr>  
 </table>  
 <table >  
   <tr>  
  <td><asp:Button id="submit" runat="server"  text="登录"  OnClick="Log"/></td>  
  <td><asp:Button id="reset" runat="server"  text="重置"  OnClick="Reset"/></td>  
  <td><asp:Button ID="button1" runat="server" Text="present" OnClick="button1_Click" />
  <asp:Button ID="button" runat="server" OnClick="button_Click" /></td>
  <td><asp:Label ID="labe11" runat="server" ></asp:Label></td>
  <td><input type="button" name="button" value="注册" onclick="location.href = 'register.aspx'"/></td>  
  </tr>  
 </table> 
       
        
    </form></div>
    </center>

</body>
</html>
