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
    public partial class ListBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            blogpost_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = blogpost_search.Text;
            }

            string query = "select * from blog_post";
            if (searchkey != "")
            {
                query += "where blogtitle like '%" + searchkey + "%'";
                query += "where blogbody like '%" + searchkey + "%'";
            }
            

            var db = new BLOGDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach(Dictionary<String,String> row in rs)
            {
                blogpost_result.InnerHtml += "<div class=\"listitem\">";

                string blogid = row["blogid"];

                string blogtitle = row["blogtitle"];
                blogpost_result.InnerHtml += "<div class=\"col2\"><a href=\"ShowBlogPost.aspx?blogid=" + blogid + "\">" + blogtitle + "</a></div>";

                string blogbody = row["blogbody"];
                blogpost_result.InnerHtml += "<div class=\"col2last\">" + blogbody + "</div>";

                blogpost_result.InnerHtml += "</div>";
            }
        }
    }
}