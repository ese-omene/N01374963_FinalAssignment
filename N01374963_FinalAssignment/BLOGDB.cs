using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace N01374963_FinalAssignment
{
    public class BLOGDB
    {
        private static string User { get { return "root"; } }

        private static string Password { get { return "root"; } }

        private static string Database { get { return "blog"; } }

        private static string Server { get { return "localhost"; } }

        private static string Port { get { return "3306"; } }

        //this is how we connect to the database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database =" + Database
                    + "; port =" + Port
                    + "; password =" + Password;

            }
        }

        public List<Dictionary<String, String>> List_Query(string query)  //result set of complete list of blog pages
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<string, string>>();

            //try and catch string to prevent whole site crash

            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query" + query);

                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();


                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<string, string>();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                    }

                    ResultSet.Add(Row);
                }
                resultset.Close();



            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong with the List_Query method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;


        }


        public BLOGPOST FindBlogPost(int id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            BLOGPOST result_blogpost = new BLOGPOST();

            try
            {
                string query = "select * from blog_post where blogid = " + id;
                Debug.WriteLine("connection initialized...");
                
                Connect.Open();

                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<BLOGPOST> BlogPosts = new List<BLOGPOST>();

                while (resultset.Read())
                {
                    BLOGPOST currentblogpost = new BLOGPOST();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);

                        Debug.WriteLine("Attempting to transfer" + key + "data of" + value);


                        switch (key)
                        {
                            case "blogtitle":
                                currentblogpost.SetBPTitle(value);
                                break;
                            case "blogbody":
                                currentblogpost.SetBPBody(value);
                                break;
                        }
                    }
                    BlogPosts.Add(currentblogpost);
                }
                result_blogpost = BlogPosts[0];
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Something went wrong in the find blog method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated");

            return result_blogpost;
        
        }



        public void AddBlogPost(BLOGPOST new_post)
        {
            string query = "insert into blog_post (blogtitle, blogbody) values ('{0}','{1}')";
            query = String.Format(query, new_post.GetBPTitle(), new_post.GetBPBody());

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);

            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrrong in the AddPost Method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
        }

        public void UpdateBlogPost(int blogid, BLOGPOST new_post)
        {

            //am i getting here?
            Debug.WriteLine("is this where the problem is?");

            string query = "update blog_post set blogtitle='{0}', blogbody='{1}' where blogid={2} ";
            query = String.Format(query, new_post.GetBPTitle(), new_post.GetBPBody(), blogid);

            Debug.WriteLine("am i getting the information i need?");

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);

            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Execute query" + query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the UpdateBlog Method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
        }

        public void DeleteBlogPost(int blogid)
        {
            string removeblogpost = "delete from blog_post where blogid = {0}";
            removeblogpost = String.Format(removeblogpost, blogid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd_removeblogpost = new MySqlCommand(removeblogpost, Connect);

            try
            {
                Connect.Open();
                cmd_removeblogpost.ExecuteNonQuery();
                Debug.WriteLine("Execute query" + cmd_removeblogpost);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the delete Blog Method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();  
        }
    }
}
