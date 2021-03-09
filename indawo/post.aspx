
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="indawo.post" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
    <main>
        <!-- breadcrumb Start-->
        <div class="page-notification page-notification2">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb justify-content-center">
                                <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                                <li class="breadcrumb-item"><a href="#">Post</a></li> 
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <!-- breadcrumb End-->
        <!-- Hero Area End-->
        <!--?  Contact Area start  -->
        <section class="contact-section">
            <div class="container">
                <div class="col-12">
                        <h2 class="contact-title">Post your apartment/room to rent</h2>
                    </div>
                <div class="popular-items">
                    <div class="container-fluid">
                    <div class="row">
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        
                <div class="single-popular-items mb-50 text-center">
                    <!--
                    <div class="popular-img">
                        <img src="assets/img/gallery/popular1.png" alt="">
                        <div class="favorit-items">
                            <a href="shop.html" class="btn">Shop Now</a>
                        </div>
                    </div>
                    -->
                </div>
            </div>
                </div>
                </div>
                </div>
                <div class="row">
                    
                    <div class="col-lg-8">
                        <div class="row">
                            <div class="col-sm-6">
                                    <div class="form-group">
                                        <asp:FileUpload ID="FileUpload1" class="form-control valid" runat="server"/>
                                        
                                    </div>
                                </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                    <div class="form-group">
                                        <select name="txtlocation">
                                        <option value="">Select the location</option>
                                        <option value="">Berea, Johannesburg, Gauteng</option>
                                        <option value="">Yeoville, Johannesburg, Gauteng</option>
                                        <option value="">Hillbrow, Johannesburg, Gauteng</option>
                                    </select>
                                        <br />
                                        <br />
                                        <!--<input class="form-control valid" name="Street" id="txtLocation" type="text" onfocus="this.select()" placeholder="Enter the area" runat="server">-->
                                    </div>
                                </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                    <div class="form-group">
                                        <input class="form-control valid" name="Street" id="txtStreet" type="text" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Enter Street name'" placeholder="Enter the street name" OnChange="changeImage()" runat="server">
                                        <script>
                                            function changeImage() {
                                                //var fileu = document.getElementById("FileUpload1");
                                                //alert("Works " + document.getElementById("txtStreet") + Server.MapPath("./"));
                                            }
                                        </script>
                                    </div>
                                </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                    <div class="form-group">
                                        <input class="form-control valid" name="roomtype" id="txtroomtype" type="text" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Enter Room Type'" placeholder="Enter Room type" runat="server">
                                    </div>
                                </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                    <div class="form-group">
                                        <input class="form-control valid" name="price" id="txtprice" type="number" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Enter the price'" placeholder="Enter the price" runat="server">
                                    </div>
                                </div>
                        </div>
                            <div class="row">
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <input class="form-control" name="details" id="txtdetails" type="text" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Enter Additional Details'" placeholder="Enter Additional Details" runat="server">
                                    </div>
                                </div>
                                <div class="col-12">
                                </div>
                             
                            </div>
                        <!--
                        <div class="row">
                                    <div class="col-lg-12">
                                        <div class="form-box user-icon mb-15">
                                            <input type="text" name="name" placeholder="Your name">
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-box email-icon mb-15">
                                            <input type="text" name="email" placeholder="Email address">
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-box message-icon mb-15">
                                            <textarea name="message" id="message" placeholder="Comment"></textarea>
                                        </div>
                                        <div class="submit-info">
                                            <button class="submit-btn2" type="submit">Send Message</button>
                                        </div>
                                    </div>
                                </div>
                        -->
                            <div class="form-group mt-3">
                                <asp:Button class="button button-contactForm boxed-btn" text="Post" runat="server" OnClick="btnSubmit_Click" />
                            </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Contact Area End -->
    </main>
        </form>
</asp:Content>
