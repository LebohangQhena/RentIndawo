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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            List<userposts> aryuserposts = getposts(int.Parse(Session["user_id"].ToString().Replace("\"", "")));
            for (int i = 0; i<aryuserposts.Count; i++)
            {
                posts.InnerHtml += viewpost(aryuserposts[i]);
            }
        }
        public void btnView_Click(Object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        public void btnPost_Click(Object sender, EventArgs e)
        {
            Response.Redirect("post.aspx");
        }

        public string viewpost(userposts posts)
        {
            string item = "<div class='col-xl-4 col-lg-4 col-md-6 col-sm-6'>";
            item +="<div class='single-new-arrival mb-50 text-center'>";
            item += "<div class='popular-img'>";
            item += "<img src = 'assets/img/gallery/" + posts.apartment_picture+"' alt=''>";
            item += "<div class='favorit-items'>";
            item += "<img src = 'assets/img/gallery/favorit-card.png' alt=''>";
            item += "</div>";
            item += "</div>";
            item += "<div class='popular-caption'>";
            item += "<h3><a href = '"+ validations.websiteAddress + "/view.aspx?id=" + posts.apartment_id+"' >" + posts.apartment_type+"</a></h3>";
            item += "<div class='rating mb-10'>";
            item += "<i class='fas fa-star'></i>";
            item += "<i class='fas fa-star'></i>";
            item += "<i class='fas fa-star'></i>";
            item += "<i class='fas fa-star'></i>";
            item += "<i class='fas fa-star'></i>";
            item += "</div>";
            item += "<span>R"+ posts.apartment_price + "</span>";
            item += "</div>";
            item += "</div>";
            item += "</div>";
            return item;
        }

        public List<userposts> getposts(int id)
        {
            WebRequest request = WebRequest.Create("http://api.rentindawo.co.za/api/userposts/" + id); //apartmentid
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            String posts = reader.ReadToEnd();
            string p = posts.Replace("[\"","");
            p = p.Replace("\"]","");
            p = p.Replace("\\", "");
            List<userposts> aryposts = JsonConvert.DeserializeObject<List<userposts>>(p);

            reader.Close();
            response.Close();

            return aryposts;
        }
    }
}