<header>
    <div id="header">
        <div id="headertop">
    	    <!-- Start navigation area -->
            <div id="navigation">

        	    <div id="navigation_wrap">

                    <!-- Start contact info area -->
                    <div id="conteactinfo">
                        <section id="login">
                            @*@Html.Partial("_LoginPartial")*@
                        </section>
                    </div>
                    <!-- End contact info area -->
                    <!-- Start navigation -->
                    <div id="navi">                
                        <ul>                    
                            <li>@Html.ActionLink("Home", "Index", "Home")</li>
                            <li>@Html.ActionLink("Code of Conduct", "CodeofConductPartial", "Home")</li>
                            <li>@Html.ActionLink("Justice System", "JusticeSystemPartial", "Home")</li>   
                            <li>@Html.ActionLink("Tournament", "Index", "Tournament")
                                <ul>
                                    <li>@Html.ActionLink("DGL", "DGL", "Tournament")</li>
                                    <li>@Html.ActionLink("TmA Internal Tournament", "TmAInternal", "Tournament")</li>
                                </ul>
                            </li>                             
                            @*<li>@Html.ActionLink("Forum", "Index", "Forum")</li>*@
                            @*<li>@Html.ActionLink("Blog", "Index", "Blogger")</li>*@
                        </ul>                
                    </div>
                    <!-- End navigation -->                
			    </div>        
            </div>
            <!-- End navigation area -->
        </div>
            <div class="clear"></div>
            <!-- Start Social & Logo area -->
            <div id="header_small">
        	    <!-- Start Social area -->
        	    <div class="social shadow">
            	
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
                <div id="logo" class="shadow">
                    <a href="/" title="Tempest Asylum">Tempest Asylum</a>
                </div>
                <!-- End Logo area -->
        
            </div>
            <!-- End Social & Logo area -->

        </div>
</header>
