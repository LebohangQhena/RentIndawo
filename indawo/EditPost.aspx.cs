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
    public partial class EditPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            userposts up = getpost(Request.QueryString["id"]);
            
            txtavalia.Value = up.apartment_availiability;
            lblprice.InnerText = up.apartment_price;
            lblroomtype.InnerText = up.apartment_type;
            lbldetails.InnerText = up.apartment_details;
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            validateInput();
            using (var client = new HttpClient())
            {
                userposts up = new userposts(Request.QueryString["id"], "", "", txtprice.Value, txtavalia.Value, "", txtroomtype.Value, txtdetails.Value, "", "");
                var stringcontent = new StringContent(JsonConvert.SerializeObject(up), Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("http://api.rentindawo.co.za/");
                var response = client.PutAsync("api/apartments/"+Request.QueryString["id"], stringcontent).Result;

                if (response.IsSuccessStatusCode)
                {
                    txtavalia.Value = "success";
                }
            }
        }

        public userposts getpost(String id)
        {
            WebRequest request = WebRequest.Create("http://api.rentindawo.co.za/api/apartments/" + id);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            String posts = reader.ReadToEnd();
            string p = posts.Replace("[\"", "");
            p = p.Replace("\"]", "");
            p = p.Replace("\\", "");
            p = p.Remove(0, 1);
            p = p.Remove(p.Length - 1, 1);
            userposts aryposts = JsonConvert.DeserializeObject<userposts>(p);

            reader.Close();
            response.Close();

            return aryposts;
        }

        public void validateInput()
        {
            if (txtprice.Value.Equals(""))
            {
                txtprice.Value = lblprice.InnerText;
            }
            if (txtroomtype.Value.Equals(""))
            {
                txtroomtype.Value = lblroomtype.InnerText;
            }
            if (txtdetails.Value.Equals(""))
            {
                txtdetails.Value = lbldetails.InnerText;
            }
        }
    }
}