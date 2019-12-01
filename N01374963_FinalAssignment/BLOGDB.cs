using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Globalization;
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

        public void Add_Post(BLOGPOST new_post)
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
    }
}
