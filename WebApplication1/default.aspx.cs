using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            MySqlConnection con = new MySqlConnection("server = 119.59.122.157; user id = dev; persistsecurityinfo = True; database = tms;password=LHITs12345678");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select * from destination_mas", con);
        }
    }
}