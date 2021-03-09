<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="find.aspx.cs" Inherits="indawo.find" %>
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
                                <li class="breadcrumb-item"><a href="#"></a></li> 
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
                            <h2>Find apartment</h2>
                            <p>Browse latest items</p>
                        </div>
                    </div>
                </div>
                <div class="row" id="posts" runat="server">
                    <!--? Left content -->
                    <div class="col-xl-3 col-lg-3 col-md-4 ">
                        <!-- Job Category Listing start -->
                        <div class="category-listing mb-50">
                            <!-- single one -->
                            <div class="single-listing">
                                <!-- Select City items start -->
                                <!--
                                <div class="select-job-items2">
                                    <select name="select2">
                                        <option value="">Category</option>
                                        <option value="">Shat</option>
                                        <option value="">T-shart</option>
                                        <option value="">Pent</option>
                                        <option value="">Dress</option>
                                    </select>
                                </div>
                                <!--  Select City items End-->
                                <!-- Select State items start -->
                                <!--
                                <div class="select-job-items2">
                                    <select name="select3">
                                        <option value="">Type</option>
                                        <option value="">SM</option>
                                        <option value="">LG</option>
                                        <option value="">XL</option>
                                        <option value="">XXL</option>
                                    </select>
                                </div>
                                <!--  Select State items End-->
                                <!-- Select km items start -->
                                <!--
                                <div class="select-job-items2">
                                    <select name="select4">
                                        <option value="">Size</option>
                                        <option value="">1.2ft</option>
                                        <option value="">2.5ft</option>
                                        <option value="">5.2ft</option>
                                        <option value="">3.2ft</option>
                                    </select>
                                </div>
                                <!--  Select km items End-->
                                <!-- Select km items start -->
                                <!--
                                <div class="select-job-items2">
                                    <select name="select5">
                                        <option value="">Color</option>
                                        <option value="">Whit</option>
                                        <option value="">Green</option>
                                        <option value="">Blue</option>
                                        <option value="">Sky Blue</option>
                                        <option value="">Gray</option>
                                    </select>
                                </div>
                                -->
                                <!--  Select km items End-->
                                <!-- Select km items start -->
                                <div class="select-job-items2">
                                    <select name="select6">
                                        <option value="">Price range</option>
                                        <option value="">R10 to R20</option>
                                        <option value="">R20 to R30</option>
                                        <option value="">R50 to R80</option>
                                        <option value="">R100 to R120</option>
                                        <option value="">R200 to R300</option>
                                        <option value="">R500 to R600</option>
                                    </select>
                                </div>
                                <!--  Select km items End-->
                            </div>
                        </div>
                        <!-- Job Category Listing End -->
                    </div>
                    <!--?  Right content -->
                    <div class="col-xl-9 col-lg-9 col-md-8 ">
                        <!--? New Arrival Start -->
                        <div class="new-arrival new-arrival2">
                            <div class="row" id="divposts" runat="server">
                                
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
<!-- listing-area Area End -->
<!--? Popular Items Start -->

<!-- Popular Items End -->
<!--? Services Area Start -->

<!--? Services Area End -->
</main>
</asp:Content>
