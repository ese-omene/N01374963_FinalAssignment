using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace N01374963_FinalAssignment
{
    public class BLOGPOST
    {

        private string BPTitle;
        private string BPBody;
        


        public string GetBPTitle()
        {
            return BPTitle;
        }
        public string GetBPBody()
        {
            return BPBody;
        }
        

        public void SetBPTitle(string value)
        {
            BPTitle = value;
        }
        public void SetBPBody(string value)
        {
            BPBody = value;
        }

        

    }
}
