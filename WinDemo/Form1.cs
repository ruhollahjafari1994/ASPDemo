using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // string connString=  DataLayer.DB.ConnectionString; // connect To Db layer 
            DataLayer.DB.ApplicationName = "Win Demo Application";
            DataLayer.DB.ConnectionTimeout = 30;
            SqlConnection conn = DataLayer.DB.GetSqlConnection();
        }
    }
}
