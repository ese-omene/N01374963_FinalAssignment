using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01374963_FinalAssignment
{
    public partial class ShowBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BLOGDB db = new BLOGDB();
            ShowBlogPostInfo(db);
        }

        protected void ShowBlogPostInfo(BLOGDB db)
        {


            

            bool valid = true;
            string blogid = Request.QueryString["blogid"];
            if (String.IsNullOrEmpty(blogid)) valid = false;

            if (valid)
            {
                BLOGPOST blogpost_record = db.FindBlogPost(Int32.Parse(blogid));

                blogpost_title_head.InnerHtml = blogpost_record.GetBPTitle();
                blogpost_title.InnerHtml = blogpost_record.GetBPTitle();
                blogpost_body.InnerHtml = blogpost_record.GetBPBody();
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                blog.InnerHtml = "There was an error finding that blog post";
            }
        }

        
    }
}