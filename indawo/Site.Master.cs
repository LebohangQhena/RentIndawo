using Newtonsoft.Json;
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
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["UserType"] == null))
            {
                adminControl.Visible = true;
                profileControl.Visible = true;
                namecontrol.InnerText = "Welcome " + getuserdetails(Session["user_id"].ToString().Replace("\"", "")).getname();
            }


            /*
            String strurltest = String.Format("https://localhost:44360/api/values/5");
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "GET";
            HttpWebResponse responseAPI = null;
            responseAPI = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = "";

            using (Stream stream = responseAPI.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            txtemail.InnerText = strresulttest;
            */
        }

        public user getuserdetails(string id)
        {
            WebRequest request = WebRequest.Create("http://api.rentindawo.co.za/api/Values/" + id);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            String posts = reader.ReadToEnd();
            string p = posts.Replace("[\"", "");
            p = p.Replace("\"]", "");
            p = p.Replace("\\", "");
            p = p.Remove(0, 1);
            p = p.Remove(p.Length - 1, 1);
            user aryuser = JsonConvert.DeserializeObject<user>(p);

            reader.Close();
            response.Close();

            return aryuser;
        }
    }
}