using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N01374963_FinalAssignment
{
    public class BLOGPOST
    {

        private string BPTitle;
        private string BPBody;
        //private DateTime PDate;


        public string GetBPTitle()
        {
            return BPTitle;
        }
        public string GetBPBody()
        {
            return BPBody;
        }
        // public DateTime GetPDate()
        // {
        //     return PDate;
        //  }

        public void SetBPTitle(string value)
        {
            BPTitle = value;
        }
        public void SetBPBody(string value)
        {
            BPBody = value;
        }

        // public void SetPDate (DateTime value)
        // {
        //      PDate = value;
        // }

    }
}
