﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParentGuardWebApp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            string script = "<script type=\"text/javascript\">alert('abc');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
        }
    }
}