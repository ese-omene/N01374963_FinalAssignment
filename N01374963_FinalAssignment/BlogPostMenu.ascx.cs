using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01374963_FinalAssignment
{
    public partial class BlogPostMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLOGDB db = new BLOGDB();
            ListBlogPostMenu(db);
        }
        protected void ListBlogPostMenu(BLOGDB db)
        {
            string query = "select * from blog_post";
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String,String> row in rs)
            {
                string blogid = row["blogid"];
                
                string blogtitle = row["blogtitle"];
                bloglist_result.InnerHtml += "<a href=\"ShowBlogPost.aspx?blogid=" + blogid + "\">" + blogtitle + "</a>";

            }
        }
    }
}