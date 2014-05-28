using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParentGuardWebApp
{
    public partial class DrivingData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(HttpContext.Current.Request.InputStream);
            string requestFromPost = reader.ReadToEnd();
            
            //loop through
            string formValue;
            if (!string.IsNullOrEmpty(Request.Form["txtFormValue"]))
            {
                formValue = Request.Form["txtFormValue"];
                formValue = Request.Form["txtImei"];

            }
        }
    }
}