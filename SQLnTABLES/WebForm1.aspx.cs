using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLnTABLES
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection
            {
                ConnectionString = WebConfigurationManager.ConnectionStrings["SQLnTABLES"].ConnectionString
            };

            var cmd = new SqlCommand
            {
                Connection = Con,
                CommandText = "SELECt * FROM Person"
            };

            Con.Open();

            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();

            adapter.Fill(table);

            GridView.DataSource = table;
            GridView.DataBind();

            Con.Close();
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Age = AgeTextBox.Text,
                Gender = GenderDropDownList.SelectedValue
            };
            person.ExecuteSql(Con);    
            Response.Redirect(Request.RawUrl);
        }
    }
}