# LandingPage
Welcome to NativoPlus Website Blazor Project. 

## Resources:

1. Architecture Model Based On:
https://github.com/jasontaylordev/CleanArchitecture

2. Following Content Format From:
https://skylight.digital

## Basic View Layout with Components:
<PageTitle>NativoPlus - Current Page</PageTitle>
<!-- start of main page wrapper -->
<div id="wrapper">
    <!-- start of preloader -->
    <Preloader />
    <!-- end of preloader -->
    <div class="w1">
        <!-- start of page header -->
        <NavigationBar />
        <!-- end of page header -->
      
        <!-- start of page main section -->
        ...
        <!-- end of page main section -->
      
        <!-- start of promo-box -->
        <CallToAction />
        <!-- end of promo-box -->
      
        <!-- start of page footer -->
        <Footer />
        <!-- end of page footer -->
    </div>
    <!-- Back Top of the page -->
    <BackToTop />
</div>
