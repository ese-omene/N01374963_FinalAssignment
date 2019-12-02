using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace N01374963_FinalAssignment
{
    public partial class UpdateBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!Page.IsPostBack)
            {
                BLOGDB db = new BLOGDB(); 
                ShowBlogInfo(db) ;
            }

        }

        protected void Update_Blog(object sender, EventArgs e)
        {
            BLOGDB db = new BLOGDB();

            bool valid = true;
            string blogid = Request.QueryString["blogid"];
            if (String.IsNullOrEmpty(blogid)) valid = false;

            if (valid)
            {
                BLOGPOST new_blog = new BLOGPOST();

                new_blog.SetBPTitle(blog_title.Text);
                new_blog.SetBPBody(blog_post.Text);

                try
                {
                    db.UpdateBlogPost(Int32.Parse(blogid), new_blog);
                    Response.Redirect("ShowBlogPost.aspx?blogid=" + blogid);
                }
                catch
                {
                    valid = false;
                }
            }
            if (!valid)
            {
                blog.InnerHtml = "There was an error updating your blog";
            }
        }

        protected void ShowBlogInfo(BLOGDB db)
        {
            bool valid = true;
            string blogid = Request.QueryString["blogid"];
            if (String.IsNullOrEmpty(blogid)) valid = false;

            if (valid)
            {
                BLOGPOST blog_record = db.FindBlogPost(Int32.Parse(blogid));
                update_title.InnerHtml = blog_record.GetBPTitle();
                blog_title.Text = blog_record.GetBPTitle();
                blog_post.Text = blog_record.GetBPBody();
            }

            if (!valid)
            {
                blog.InnerHtml = "There was an error updating your blog";
            }
        }
    }
}