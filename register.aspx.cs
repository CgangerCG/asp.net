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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Ifre()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "user id=sa;data source=localhost;database=admin;pwd=nuist";

            conn.Open();
            string sql = "select * from userinfo where UserName='" + username.Text + "'";
            //定义数据适配器da，将da的数据填充至Dataset类的对象dt中  
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt); conn.Close();
            //如果记录为TextBox1.Text的行已经存在  
            if (dt.Rows.Count > 0)
            {
                username.Text = " 该用户名已存在";
                Response.Write("<script language=javascript>alert('该用户名已存在')</script>");
                return false;
            }
            else
            {
                return true;
            }

        }
        //注册按钮  
        protected void Button_reg(object sender, EventArgs e)
        {
            //检查用户名是否已经存在  
            if (Ifre() == false)
            {
                return;
            }
            //用户名未注册  
            SqlConnection conn = new SqlConnection("user id=sa;data source=localhost;database=admin;pwd=nuist");
            conn.Open();

            //在数据表中插入用户输入的注册信息 
            if (username.Text == "" || password.Text == "") { Response.Write("<script language=javascript>alert('请填写用户名和密码')</script>"); }
            else
            {
                if (password.Text == password0.Text)
                {
                    string sex = "";
                    if (man.Checked) { sex = man.Text; }
                    else { sex = woman.Text; }
                    string sql = "insert  into userinfo (UserName,Password,DeptID,Gender) values('" + username.Text + "','" + password.Text + "','" + DeptID.Text + "','" + sex + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int i = 0;
                    using (cmd)
                    {
                        i = cmd.ExecuteNonQuery();
                    }
                    Response.Write("<script language=javascript>alert('注册成功，返回登陆！')</script>");
                    //Response.Redirect("login.aspx");
                    Response.Redirect("register.aspx?id='" + username.Text + "'");

                }
                else { Response.Write("<script language=javascript>alert('两次密码不匹配！')</script>"); }
            }
            //MessageBox.Show("注册成功，请点击“确定”返回登录界面！", "温馨提示", MessageBoxButtons.YesNo);  

        }
        //重置按钮  
        protected void Reset(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            DeptID.Text = "";
        }
        //返回按钮  
        protected void Button36_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}