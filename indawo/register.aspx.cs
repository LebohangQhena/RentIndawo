using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indawo
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Hello.");
        }

        public void btnregister_Click(object sender, EventArgs e)
        {
            //Response.Write("Button Works.");
            //Response.Redirect("WebForm1.aspx");
            String strurltest = String.Format("http://api.rentindawo.co.za/api/values");
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "POST";
            requestObject.ContentType = "application/json";

            user newuser = new user(txtname.Value, txtSurname.Value, txtemail.Value, txtphone_number.Value, sha256hash(txtpassword.Value));
            string postdata = "'{" + newuser.getname() + "," + newuser.getsurname() + "," +newuser.getemail()+ "," + newuser.getnumbers() + ","+newuser.getpassword()+"}'";
            using(StreamWriter streamwriter = new StreamWriter(requestObject.GetRequestStream()))
            {
                streamwriter.Write(postdata);
                streamwriter.Flush();
                streamwriter.Close();

                var httpresponse = requestObject.GetResponse();

                using(StreamReader sr = new StreamReader(httpresponse.GetResponseStream()))
                {
                    var result1 = sr.ReadToEnd();
                }
            }
            Response.Redirect("login.aspx");
            Response.Write("Hello");
        }

        public static string sha256hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}