
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="indawo.view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <body class="full-wrapper">
    <!-- ? Preloader Start -->
    
    <!-- header end -->
    <main>
        <!-- breadcrumb Start-->
        <div class="page-notification">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb justify-content-center">
                                <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                                <li class="breadcrumb-item"><a href="#">shop</a></li> 
                                <li class="breadcrumb-item"><a href="#">Product Details</a></li> 
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <!-- breadcrumb End-->
        <!--?  Details start -->
        <div runat="server" id="display">

        </div>
        <!--  Details End -->
        <!-- listing-area Area End -->
        <!--? Popular Locations Start 01-->
        
        <!-- Popular Locations End -->

        <!--? Services Area Start -->
        <!--? Services Area End -->
    </main>
<!--? Search model Begin -->
<div class="search-model-box">
    <div class="h-100 d-flex align-items-center justify-content-center">
        <div class="search-close-btn">+</div>
        <form class="search-model-form">
            <input type="text" id="search-input" placeholder="Searching key.....">
        </form>
    </div>
</div>
<!-- Search model end -->
<!-- Scroll Up -->
<div id="back-top" >
    <a title="Go to Top" href="#"> <i class="fas fa-level-up-alt"></i></a>
</div>

<!-- JS here -->
<!-- Jquery, Popper, Bootstrap -->
<script src="./assets/js/vendor/modernizr-3.5.0.min.js"></script>
<script src="./assets/js/vendor/jquery-1.12.4.min.js"></script>
<script src="./assets/js/popper.min.js"></script>
<script src="./assets/js/bootstrap.min.js"></script>

<!-- Slick-slider , Owl-Carousel ,slick-nav -->
<script src="./assets/js/owl.carousel.min.js"></script>
<script src="./assets/js/slick.min.js"></script>
<script src="./assets/js/jquery.slicknav.min.js"></script>

<!-- One Page, Animated-HeadLin, Date Picker -->
<script src="./assets/js/wow.min.js"></script>
<script src="./assets/js/animated.headline.js"></script>
<script src="./assets/js/jquery.magnific-popup.js"></script>
<script src="./assets/js/gijgo.min.js"></script>

<!-- Nice-select, sticky,Progress -->
<script src="./assets/js/jquery.nice-select.min.js"></script>
<script src="./assets/js/jquery.sticky.js"></script>
<script src="./assets/js/jquery.barfiller.js"></script>

<!-- counter , waypoint,Hover Direction -->
<script src="./assets/js/jquery.counterup.min.js"></script>
<script src="./assets/js/waypoints.min.js"></script>
<script src="./assets/js/jquery.countdown.min.js"></script>
<script src="./assets/js/hover-direction-snake.min.js"></script>

<!-- contact js -->
<script src="./assets/js/contact.js"></script>
<script src="./assets/js/jquery.form.js"></script>
<script src="./assets/js/jquery.validate.min.js"></script>
<script src="./assets/js/mail-script.js"></script>
<script src="./assets/js/jquery.ajaxchimp.min.js"></script>

<!-- Jquery Plugins, main Jquery -->	
<script src="./assets/js/plugins.js"></script>
<script src="./assets/js/main.js"></script>

</body>
</asp:Content>
