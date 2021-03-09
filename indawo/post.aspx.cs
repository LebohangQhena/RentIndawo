using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

namespace indawo
{
    public partial class post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["User_id"] == null)
            {
                //Session["User_id"] = 1;
                Response.Redirect("Login.aspx");
            }
            
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            string i = txtLocation.ID;
            //Uploading Image to the server
            String strFolder = Server.MapPath("./");
            strFolder += "\\assets\\img\\gallery\\";
            string strfilename = FileUpload1.FileName;

            
            //FileUpload1.FileContent.

            if (FileUpload1.PostedFile != null)
            {
                if (!Directory.Exists(strFolder))
                {
                    Directory.CreateDirectory(strFolder);
                }

                
                //Image imgtoSave = resizeimage(Image.FromFile(strFolder + strfilename), new Size(264, 330));
                //imgtoSave.Save();
                
                String ext = Path.GetExtension(FileUpload1.FileName);
                if(ext.ToLower().Equals(".png") || ext.ToLower().Equals(".jpg"))
                {
                    Stream imgstrm = FileUpload1.PostedFile.InputStream;
                    using (var image = System.Drawing.Image.FromStream(imgstrm))
                    {
                        int newwidth = 264;
                        int newheight = 330;

                        var thumbimg = new Bitmap(newwidth,newheight);
                        var thumbgraph = Graphics.FromImage(thumbimg);
                        thumbgraph.CompositingQuality = CompositingQuality.HighQuality;
                        thumbgraph.SmoothingMode = SmoothingMode.HighQuality;
                        thumbgraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        var imgrectangle = new Rectangle(0,0,newwidth,newheight);
                        thumbgraph.DrawImage(image, imgrectangle);

                        String strfilepath = strFolder + strfilename;


                        thumbimg.Save(strfilepath, image.RawFormat);
                        //FileUpload1.PostedFile.SaveAs(strfilepath);
                        
                        //using (var client = new WebClient())
                        //{
                            //client.Credentials = new NetworkCredential("rentipav", "mh-y5wl(IUQ6");
                            //client.UploadFile("ftp://169.1.20.95/rentipav/rentindawo.co.za/wwwroot/assets/img/gallery", WebRequestMethods.Ftp.UploadFile, FileUpload1.FileName);
                        //}
                    }
                }
            }
            
            
            //Updating database
            String strurltest = String.Format("http://api.rentindawo.co.za/api/apartments");
            WebRequest requestObject = WebRequest.Create(strurltest);
            requestObject.Method = "POST";
            requestObject.ContentType = "application/json";

            string postdata = "'{" + Session["User_id"] + "," + "1" + "," + txtprice.Value + "," + "t" + "," + DateTime.Now.ToString("yyyy-MM-dd") + "," + txtroomtype.Value + "," + txtdetails.Value + "," + strfilename + "," + "0" + "}'";
            using (StreamWriter streamwriter = new StreamWriter(requestObject.GetRequestStream()))
            {
                streamwriter.Write(postdata);
                streamwriter.Flush();
                streamwriter.Close();

                var httpresponse = requestObject.GetResponse();

                using (StreamReader sr = new StreamReader(httpresponse.GetResponseStream()))
                {
                    var result1 = sr.ReadToEnd();
                    if (result1.Contains(""))
                    {
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {

                    }
                }
            }
           
        }
        /*
        private void FileuploadEventHandler(object sender, TextChangedEventArgs e)
        {

        }
        */

        public static Image resizeimage(Image imgtoresize, Size size)
        {
            return (Image)(new Bitmap(imgtoresize, size));
        }
    }
}