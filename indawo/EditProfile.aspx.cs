using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indawo
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            user userdetails = getuser(Session["user_id"].ToString().Replace("\"", ""));

            lbln.InnerText = userdetails.getname();
            lbls.InnerText = userdetails.getsurname();
            lblnum.InnerText = userdetails.getnumbers();
            lblmail.InnerText = userdetails.getemail();
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            validateinput();
            using (var client = new HttpClient())
            {
                user userdetails = new user(txtname.Value, txtsurname.Value,txtemail.Value,txtnumber.Value,"");
                var stringcontent = new StringContent(JsonConvert.SerializeObject(userdetails), Encoding.UTF8, "application/json");
                client.BaseAddress = new Uri("http://api.rentindawo.co.za/");
                var response = client.PutAsync("api/Values/" + Session["user_id"].ToString().Replace("\"", ""), stringcontent).Result;

                if (response.IsSuccessStatusCode)
                {
                    txtemail.Value = "success";
                }
            }
        }

        public user getuser(String id)
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

        public void validateinput()
        {
            if (txtname.Value.Equals(""))
            {
                txtname.Value = lbln.InnerText;
            }

            if (txtsurname.Value.Equals(""))
            {
                txtsurname.Value = lbls.InnerText;
            }
            if (txtnumber.Value.Equals(""))
            {
                txtnumber.Value = lblnum.InnerText;
            }
            if (txtemail.Value.Equals(""))
            {
                txtemail.Value = lblmail.InnerText;
            }
        }
    }
}