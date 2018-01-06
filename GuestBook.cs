using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBook
{
    public class GuestBook
    {
        private string p_visitorname;
        public string VisitorName
        {
            get { return p_visitorname; }
            set { p_visitorname = value; }
        }
        public GuestBook()
        {
            p_visitorname = "";
        }
        public GuestBook(string name)
        {
            p_visitorname = name;
        }
    }
}