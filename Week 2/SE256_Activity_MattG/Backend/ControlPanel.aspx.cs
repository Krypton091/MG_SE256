﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Lab_MattG.Backend
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //Do nothing because they're logged in
            }
            else
            {
                //Send them back to login
                Response.Redirect("~/Backend/Default.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Backend/Default.aspx");
        }
    }
}