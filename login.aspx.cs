using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("user id=sa;data source=localhost;database=admin;pwd=nuist");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void Log(object sender, EventArgs e)
    {
        string name = username.Text.Trim();
        string pwd = password.Text.Trim();
        conn.Open();
        //链接数据库
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "select* from userinfo";
        SqlDataReader myreader = cmd.ExecuteReader();
        Session["username"] = name;
        Session["password"] = pwd;
            while (myreader.Read())
            {
                if (myreader["UserName"].ToString() == (string)Session["username"] && myreader["Password"].ToString() == (string)Session["password"])
                {
                    Response.Write("<script language=javascript>alert('登录成功！')</script>");
                 
                    Response.Redirect("all.aspx");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('用户名不存在或密码不正确!')</script>");
                 
                }
            }
        conn.Close();//关闭链接
    }
    protected void Reset(object sender, EventArgs e)
    {
        username.Text = "";
        password.Text = "";
    }
    protected void button1_Click(object sender, EventArgs e)
    {
        labe11.Text = username.Text.ToString() + password.Text.ToString();
    }

    protected void button_Click(object sender, EventArgs e)
    {
        Response.Redirect("all.aspx");
        //conn.Open();
        //SqlDataAdapter ui = new SqlDataAdapter("select * from userdept where UserName='"+Request.Params["username"].ToString()+"'",conn);
       // DataSet userin = new DataSet();
       // ui.Fill(userin);
        //GridView1.DataSource= userin;
       // GridView1.DataBind();
       // conn.Close();
        //Response.Redirect("login.aspx?id=" + username.Text + "");
    }
}

    }
