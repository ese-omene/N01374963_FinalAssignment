﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01374963_FinalAssignment
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         /*   bloglist_result.InnerHtml = "";


            string query = "select * from blog_post";
            var db = new BLOGDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
               // bloglist_result.InnerHtml += "<div class=\"listitem\">";


                string blogid = row["blogid"];

                string blogtitle = row["blogtitle"];
                bloglist_result.InnerHtml += "<a href=\"ShowBlogPost.aspx?blogid=" + blogid + "\">" + blogtitle + "</a>";

                string blogbody = row["blogbody"];
                // bloglist_result.InnerHtml += "<div class=\"col2last\">" + blogbody + "</div>";

              //  bloglist_result.InnerHtml += "</div> ";*/
            }
        }
    }
