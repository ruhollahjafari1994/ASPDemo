using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string connString=  DataLayer.DB.ConnectionString; // connect To Db layer 
            DataLayer.DB.ApplicationName = "ASP Demo Application";
            DataLayer.DB.ConnectionTimeout = 30;
            SqlConnection conn = DataLayer.DB.GetSqlConnection();
        }
    }
}