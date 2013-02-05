<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ViewData("Title")</title>
        <meta name="viewport" content="width=device-width" />        
        @System.Web.Optimization.Styles.Render("~/css/main.css")
        <meta content="Tempest Asylum" name="description"></meta>
        <meta content="Tempest, Asylum, Tempest Asylum" name="keywords"></meta>
        @*<link href="http://www.derby-web-design-agency.co.uk/themes/response/images/favicon.png" rel="shortcut icon"></link>
        <link href="http://www.derby-web-design-agency.co.uk/themes/response/images/favicon.png" rel="bookmark icon"></link>*@   
    </head>
    <body>
        <header>
            <div id="header">
    	            <!-- Start navigation area -->
                    <div id="navigation">

        	            <div id="navigation_wrap">

                            <!-- Start contact info area -->
                            <div id="conteactinfo">
                                <section id="login">
                                    @Html.Partial("_LoginPartial")
                                </section>
                            </div>
                            <!-- End contact info area -->
                            <!-- Start navigation -->
                            <div id="navi">                
                                <ul>                    
                                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                                    <li>@Html.ActionLink("Code of Conduct", "CodeofConduct", "Home")</li>
                                    <li>@Html.ActionLink("Justice System", "JusticeSystem", "Home")</li>   
                                    <li>@Html.ActionLink("Tournament", "Index", "Tournament")</li>                             
                                </ul>                
                            </div>
                            <!-- End navigation -->                
			            </div>        
                    </div>
                    <!-- End navigation area -->
                    <div class="clear"></div>
                    <!-- Start Social & Logo area -->
                    <div id="header_small">
        	            <!-- Start Social area -->
        	            <div class="social">
            	
                            <ul>
                            @*<li><a href="#" class="social-google"></a></li>*@
                            <li><a href="http://www.facebook.com/groups/463020340418020/" target="_blank" class="social-facebook"></a></li>
                            <li><a href="https://twitter.com/TempestAsylum" target="_blank" class="social-twitter"></a></li>
                            <li><a href="http://www.youtube.com/user/TempestAsylum?feature=mhee" target="_blank" class="social-youtube"></a></li>
                            @*<li><a href="#" class="social-linkedin"></a></li>
                            <li><a href="#" class="social-forrst"></a></li>
                            <li><a href="#" class="social-dribbble"></a></li>*@
                            </ul>
                
                        </div>
                        <!-- End Socialarea -->
            
                        <!-- Start Logo area -->
                        <div id="logo">
                          <a href="/" title="Tempest Asylum">@*<img width="100" src="~/images/TmA.jpg"/>*@ Tempest Asylum</a>
                        </div>
                        <!-- End Logo area -->
        
                    </div>
                    <!-- End Social & Logo area -->

            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            @RenderBody()
        </div>

        <footer>
            <div id="footer">
	            <!-- Start Footer Top -->
	            <div id="footertop">    
    	            <div class="footerwrap">
                        <iframe width="100%" height="166" scrolling="no" frameborder="no" src="https://w.soundcloud.com/player/?url=http%3A%2F%2Fapi.soundcloud.com%2Ftracks%2F76299713"></iframe>
                    </div>
                </div>
	            <!-- End Footer Top -->
                <div class="clear"></div>
                <!-- Start Footer Bottom -->
                <div id="footerbottom">
    
    	            <div class="footerwrap">
        
        	            <!-- Start Copyright Div -->
                        <div id="copyright">@DateTime.Now.Year - FTI - All rights reserved</div>
                        <!-- End Copyright Div -->

                        <!-- Start Social area -->
                        <div class="socialfooter">                
                            <ul>
                            @*<li><a href="#" class="social-google"></a></li>*@
                            <li><a href="http://www.facebook.com/groups/463020340418020/" target="_blank" class="social-facebook"></a></li>
                            <li><a href="https://twitter.com/TempestAsylum" target="_blank" class="social-twitter"></a></li>
                            <li><a href="http://www.youtube.com/user/TempestAsylum?feature=mhee" target="_blank" class="social-youtube"></a></li>
                            @*<li><a href="#" class="social-linkedin"></a></li>
                            <li><a href="#" class="social-forrst"></a></li>
                            <li><a href="#" class="social-dribbble"></a></li>*@
                            </ul>                
                        </div>
                        <!-- End Socialarea -->
        
                    </div>
    
                </div>
                <!-- End Footer Bottom -->
            </div>
        </footer>        
    </body>
</html>
