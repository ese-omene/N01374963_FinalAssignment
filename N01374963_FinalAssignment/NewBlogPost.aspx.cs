using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Diagnostics;

namespace N01374963_FinalAssignment
{
    public partial class NewBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddPost(object sender, EventArgs e)
        {
            BLOGDB db = new BLOGDB();

            BLOGPOST new_post = new BLOGPOST();

            new_post.SetBPTitle(blog_title.Text);
            new_post.SetBPBody(blog_body.Text);

            db.AddBlogPost(new_post);

            Response.Redirect("ListBlogPost.aspx");
        }

       
    }
}