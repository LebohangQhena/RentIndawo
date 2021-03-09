
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="indawo.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <!-- breadcrumb Start-->
        <div class="page-notification">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb justify-content-center">
                                <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                                <li class="breadcrumb-item"><a href="#">Admin</a></li> 
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <!-- listing Area Start -->
        <div class="category-area">
            <div class="container">
                <div class="row">
                    <div class="col-xl-7 col-lg-8 col-md-10">
                        <div class="section-tittle mb-50">
                            <h2>Adminstration</h2>
                            <p></p>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <!--? Left content -->
                    <div class="col-xl-3 col-lg-3 col-md-4 ">
                        <!-- Job Category Listing start -->
                        <div class="category-listing mb-50">
                            <!-- single one -->
                            <div class="single-listing">
                                <div class="select-job-items2">
                                    <!--<button class="button rounded-0 primary-bg text-white w-100 btn_1 boxed-btn" type="submit">View your posts</button>-->
                                    <asp:Button class="button rounded-0 primary-bg text-white w-100 btn_1 boxed-btn" text="View your posts" runat="server" OnClick="btnView_Click" />
                                </div>
                                <br />
                                <div class="select-job-items2">
                                    <!--<button class="button rounded-0 primary-bg text-white w-100 btn_1 boxed-btn" type="submit" OnClick="btnPost_Click" runat="server">add apartment</button>-->
                                    <asp:Button class="button rounded-0 primary-bg text-white w-100 btn_1 boxed-btn" text="add apartment" runat="server" OnClick="btnPost_Click" />
                                </div>
                                
                            </div>
                        </div>
                        <!-- Job Category Listing End -->
                        <div class="col-lg-4">
                            <div class="blog_right_sidebar">
                                
                            </div>
                        </div>
                        
                        </div>
                    <!--?  Right content -->
                    <div class="col-xl-9 col-lg-9 col-md-8 ">
                        <!--? New Arrival Start -->
                        <div class="new-arrival new-arrival2">
                            <div class="row" id="posts" runat="server">

                            </div>
<!-- Button -->
<div class="row justify-content-center">
    <div class="room-btn mt-20">
        <a href="catagori.html" class="border-btn">Browse More</a>
    </div>
</div>
</div>
<!--? New Arrival End -->
</div>
</div>
</div>
</div>

</main>
</asp:Content>
