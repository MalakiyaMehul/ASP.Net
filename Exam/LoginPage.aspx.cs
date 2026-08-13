using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mehul_92500584004
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlDataSource dataSource;
        SqlDataAdapter adapter;

        string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student\\source\\repos\\Mehul_92500584004\\Mehul_92500584004\\App_Data\\Registration.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Mehul" && password == "Mehul123")
            {
                Response.Redirect("RegistrationPage.aspx");

            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
            }
            
        }
    }
}