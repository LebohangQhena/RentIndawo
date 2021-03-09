using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace indawo
{
    public class validations
    {
        public static string websiteAddress = "http://rentindawo.co.za";
        public static void userSession(HttpSessionState Session)
        {
            if (Session["User_id"] != null)
            {
            }
        }
    }

}