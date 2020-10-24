using SE256_Activity_MattG.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Activity_MattG.Backend
{
    public partial class EBookMgr : System.Web.UI.Page
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
            EBook temp = new EBook();

            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtAuthorEmail.Text;
            temp.DatePublished = calDatePublished.SelectedDate;
            temp.DateRentalExpires = calRentalExpires.SelectedDate;

            Int32 intPages = 0;
            if (Int32.TryParse(txtPages.Text, out intPages))
            {
                temp.Pages = intPages;
            }

            Double dblPrice = 0;
            if (Double.TryParse(txtPrice.Text, out dblPrice))
            {
                temp.Price = dblPrice;
            }

            Int32 intBookmarkPage = 0;
            if (Int32.TryParse(txtBookmarkPage.Text, out intBookmarkPage))
            {
                temp.BookmarkPage = intBookmarkPage;
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