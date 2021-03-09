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
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userposts up = getpost(Request.QueryString["id"]);
            user ownerUser = getuser(up.user_id);

            

            //if(Session["user_id"].ToString().Replace("\"", "").Equals(up.user_id) && Session["UserType"].Equals("Admin"))
            if (Session["user_id"] !=null && Session["UserType"] != null)
            {
                
                if (Session["user_id"].ToString().Contains(up.user_id))
                {
                    display.InnerHtml = ownerview(up, ownerUser);
                }
                else
                {
                    Generalview(up, ownerUser);
                }
            }
            else
            {
                updateviews(up.apartment_views);
                Generalview(up, ownerUser);
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
            p = p.Remove(p.Length-1, 1);
            userposts aryposts = JsonConvert.DeserializeObject<userposts>(p);

            reader.Close();
            response.Close();

            return aryposts;
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

        public string ownerview(userposts up, user owneruser)
        {
            string display = "";
            display += "<div class='directory - details pt - padding'>";
            display += "<div class='container'>";
            display += "<div class='row'>";
            display += "<div class='col - lg - 8'>";
            display += "<div class='small - tittle mb - 20'>";
            display += "<h1>Description</h1>";
            display += "</div>";
            display += "<div class='directory-cap mb-40'>";
            display += "<p>" + up.apartment_details + "</p>";
            display += "</div>";
            display += "<div class='small-tittle mb-20'>";
            display += "<h2>Post Details</h2>";
            display += "<p>Date Posted: " + up.apartment_dateposted + "</p>";
            display += "<p>Price: R" + up.apartment_price + "</p>";
            display += "<p>Number of views: " + up.apartment_views + "</p>";
            display += "<div class='button-group-area mt-10'><a href='EditPost.aspx?id="+up.apartment_id+"' class='genric-btn success-border circle'>Edit Post</a></div>";
            display += "</div>";
            display += "<div class='gallery-img'>";
            display += "<div class='row'>";
            display += "<div class='col-lg-6'>";
            display += "<img src = 'assets/img/gallery/" + up.apartment_picture + "' class='mb-30' alt=''>";
            display += "</div>";
            display += "</div>";
            display += "</div>";
            display += "</div>";
            display += "</div>";
            display += "</div>";
            display += "</div>";

            return display;
        }

        public void Generalview(userposts up, user ownerUser)
        {
            display.InnerHtml += "<div class='directory - details pt - padding'>";
            display.InnerHtml += "<div class='container'>";
            display.InnerHtml += "<div class='row'>";
            display.InnerHtml += "<div class='col - lg - 8'>";
            display.InnerHtml += "<div class='small - tittle mb - 20'>";
            display.InnerHtml += "<h1>Description</h1>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "<div class='directory-cap mb-40'>";
            display.InnerHtml += "<p>" + up.apartment_details + "</p>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "<div class='small-tittle mb-20'>";
            display.InnerHtml += "<h2>Description</h2>";
            display.InnerHtml += "<p>Price: R" + up.apartment_price + "</p>";
            display.InnerHtml += "<p>Date Posted: " + up.apartment_dateposted + "</p>";
            display.InnerHtml += "<p>Posted by: " + ownerUser.getname() + "</p>";
            display.InnerHtml += "<p>Contact Number: 0" + ownerUser.getnumbers() + "</p>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "<div class='gallery-img'>";
            display.InnerHtml += "<div class='row'>";
            display.InnerHtml += "<div class='col-lg-6'>";
            display.InnerHtml += "<img src = 'assets/img/gallery/" + up.apartment_picture + "' class='mb-30' alt=''>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "</div>";
            display.InnerHtml += "</div>";
        }

        public void updateviews(string apartment_views)
        {
            using (var client = new HttpClient())
            {
                var stringcontent = new StringContent(apartment_views, Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("http://api.rentindawo.co.za/");
                var response = client.PutAsync("api/userposts/" + Request.QueryString["id"], stringcontent).Result;

                if (response.IsSuccessStatusCode)
                {
                    string s = "success";
                }
            }
        }
    }
}