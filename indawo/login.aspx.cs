using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indawo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnlogin_Click(object sender, EventArgs e)
        {
            String strurltest = String.Format("http://api.rentindawo.co.za/api/login");
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "POST";
            requestObject.ContentType = "application/json";

            string postdata = "'{" +txtphone_number.Value+","+ register.sha256hash(txtpassword.Value) + "}'";
            using (StreamWriter streamwriter = new StreamWriter(requestObject.GetRequestStream()))
            {
                streamwriter.Write(postdata);
                streamwriter.Flush();
                streamwriter.Close();

                var httpresponse = requestObject.GetResponse();

                using (StreamReader sr = new StreamReader(httpresponse.GetResponseStream()))
                {
                    var result1 = sr.ReadToEnd();
                    if (result1.Contains("true"))
                    {
                        string[] tempstr = result1.Split(' ');
                        Session["UserType"] = "Admin";
                        Session["User_id"] = tempstr[1].Replace("\"", "");
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {
                        lblerror.InnerText = "Please enter the correct details";
                    }
                }
            }
        }
    }
}