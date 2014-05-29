using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ParentGuardWebApp
{
    public partial class DrivingData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(HttpContext.Current.Request.InputStream);
            string requestFromPost = reader.ReadToEnd();

            //loop through
           // string formValue;

            string speed;
            string initialLocation;
            string finalLocation;
            string IMEI;

            if (!string.IsNullOrEmpty(Request.Form["txtSpeed"]))
            {
                //formValue = Request.Form["txtSpeed"];
                //formValue = Request.Form["txtImei"];
                speed = Request.Form["Speed"];
                initialLocation = Request.Form["initialLocation"];
                finalLocation = Request.Form["finalLocation"];
                IMEI = Request.Form["IMEI"];

                string s = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection cn = new SqlConnection(s);
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into DataHistory(Speed, initialLocation, finalLocation, IMEI)values('" + speed + "','" + initialLocation + "','" + finalLocation + "','" + IMEI + "')", cn);
                cmd.ExecuteNonQuery();
	
            }

        }
    }
}