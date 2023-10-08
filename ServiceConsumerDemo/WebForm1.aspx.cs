using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceConsumerDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeServiceReference.WebService1SoapClient client = new EmployeeServiceReference.WebService1SoapClient();
            var result = client.SearchByEmployee(TextBox1.Text);
            GridView1.DataSource = result.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

    }
}