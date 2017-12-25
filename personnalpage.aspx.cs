using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class personnalpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("User ID=sa; pwd=nuist; data source=localhost;database=admin");
            conn.Open();
            SqlDataAdapter person= new SqlDataAdapter("select * from userdept",conn);
            DataSet userin = new DataSet();
            person.Fill(userin);
            GridView1.DataSource= userin;
             GridView1.DataBind();
             conn.Close();
        }
    }
}