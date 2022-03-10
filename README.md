# LandingPage
Welcome to NativoPlus Website Blazor Project. 

## Resources:

1. Architecture Model Based On:
https://github.com/jasontaylordev/CleanArchitecture

2. Following Content Format From:
https://skylight.digital

3. Template:
http://htmlbeans.com/html/be/index.html

4. Live Website: 
https://nativoplus-website-dev.azurewebsites.net/

5. Template Code URL:
https://drive.google.com/file/d/1Otv5EyE0xEtPeSoXJZu6X4hYn7NpDJXJ/view?usp=sharing

## Basic View Layout with Components:

```HTML
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
        PAGE HTML CODE GOES HERE
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
```
To Get SASS Dependencies Run the Following Command on the Terminal:
```CMD
npm install sass --save-dev
```
