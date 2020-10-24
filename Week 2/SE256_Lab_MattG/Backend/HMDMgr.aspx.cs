using SE256_Lab_MattG.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Lab_MattG.Backend
{
    public partial class HMDMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //Do nothing, everything is fine
            }
            else
            {
                Response.Redirect("~/Backend/Default.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            VirtualRealityV2 temp = new VirtualRealityV2();

            temp.HmdName = txtHmdName.Text;
            temp.ScreenRes = txtScreenRes.Text;
            temp.RefreshRate = txtRefreshRate.Text;
            temp.DisplayType = txtDisplayType.Text;
            temp.PcOrStandalone = txtPcOrStandalone.Text;
            temp.Brand = txtBrand.Text;
            temp.DateReleased = calDateReleased.SelectedDate;

            Double dblPrice = 0;
            if (Double.TryParse(txtPrice.Text, out dblPrice))
            {
                temp.Price = dblPrice;
            }

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.AddARecord();
            }
        }
    }
}