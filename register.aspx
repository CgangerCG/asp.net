<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication1.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<font size='5'><center>请填写注册信息</center></font><br/><hr size='15' color='gray'/>

<body>
<form id="formregister" runat="server">
<center><table>  
 <tr>  
 <td>USERNAME</td>  
 <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>  
 <td > </td>  
 <td> </td>  
 </tr>  
 <tr>  
 <td>PASSWORD</td>  
 <td><asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>  
 <td> </td>  
 <td> </td> 
 </tr>
 <tr>
<td>SURE</td>  
 <td><asp:TextBox ID="password0" runat="server" TextMode="Password"></asp:TextBox></td>  
 <td> </td>  
 <td> </td>  
 </tr> 
 <tr>      
 <td>GENDER</td>  
 <td><br />
<asp:RadioButton id="man" Text="male" Checked="True" GroupName="sex" runat="server"/>
<asp:RadioButton id="woman"  GroupName="sex" Text="female" runat="server"/>
<%--<asp:RadioButton id="none"  GroupName="sex" Text="无" runat="server"/>--%>
</td>  
 <td > </td>  
 <td> </td>  
 </tr> 
 <tr>
 <td>DeptID</td>  
 <td><asp:TextBox ID="DeptID" runat="server"></asp:TextBox></td>  
 <td > </td>  
 <td> </td>  
 </tr>
 </table>  
 <table >  
   <tr>  
  <td><asp:Button ID="submit" runat="server"  text="点击注册"  OnClick="Button_reg"/></td>
         <td><asp:Button id="reset" runat="server"  text="重置"  OnClick="Reset"/></td>  
         <td><input type="button" name="button" value="返回登录" onclick="location.href = 'login.aspx'"/>
   </td>  </tr>
 </table>
 <asp:Label ID="label1" runat="server" ></asp:Label>
</center>
    <hr />
    <p style="font-size:22px">CGSZ.com</p>

    </form>
</body>
</html>
