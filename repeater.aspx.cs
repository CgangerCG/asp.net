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
using System.Data.Sql;
using System.Data.SqlClient;

public partial class show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("user id=sa;data source=localhost;database=admin;pwd=sqlserverSa");
        conn.Open();
        SqlDataAdapter show = new SqlDataAdapter("select username,deptname from View_1;", conn);
        DataSet user = new DataSet();
        show.Fill(user);
        r1.DataSource = user;
        r1.DataBind();
        conn.Close();
    }
}
