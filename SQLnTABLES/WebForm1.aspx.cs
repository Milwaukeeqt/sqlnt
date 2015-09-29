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
        private SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //GenderDropDownList
            }
            con = new SqlConnection
            {
                ConnectionString = WebConfigurationManager.ConnectionStrings["SQLnTABLES"].ConnectionString
            };
            con.Open();

            var cmd = new SqlCommand
            {
                Connection = con,
                CommandText = "SELECt * FROM Person"
            };

            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();

            adapter.Fill(table);

            GridView.DataSource = table;
            GridView.DataBind();
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            var p = new Person
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Age = AgeTextBox.Text,
                Gender = GenderDropDownList.SelectedValue
            };

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = p.SqlToString();
                cmd.ExecuteNonQuery();
            }
        }
    }
}