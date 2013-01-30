<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ViewData("Title")</title>
        <meta name="viewport" content="width=device-width" />        
        </script>@System.Web.Optimization.Styles.Render("~/css/modern.css")
    </head>
    <body>
        <header>
            <div class="content-wrapper">
                <div align="center">
                    <div class="span12">
                        @*<div class="grid"> *@                   
                            @*<div class="colum" align="left">
                                <div class="span12">
                                    <a href="/">
                                        <img width="200" src="~/Images/TmA.jpg" alt/>
                                    </a>
                                </div>                        
                            </div>*@
                            @*<div class="colum" align="right">*@
                                <div align="right">
                                    <section id="login">
                                        @Html.Partial("_LoginPartial")
                                    </section>
                                </div>                        
                            @*</div>*@
                        @*</div>   *@         
                    </div>                       
                </div>

                <div align="center">
                    <div class="span12">
                        <div class="nav-bar bg-color-pink padding10">
                            <div class="nav-bar-inner" > 
                                <a href="/">
                                    <span class="element brand">                                        
                                        Tempest Asylum
                                    </span>
                                </a>
                                
                                <div class="divider"></div>
                                <ul class="menu">            
                                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                                    <li>@Html.ActionLink("Code of Conduct", "CodeofConduct", "Home")</li>
                                    <li>@Html.ActionLink("Justice System", "JusticeSystem", "Home")</li>
                                    @*<li>@Html.ActionLink("Champion", "Index", "Champion")</li>*@
                                </ul>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            <section class="content-wrapper main-content clear-fix">
                <div align="center">
                    <div class="span12">        
                       <div class="page-region-content">
                           @RenderBody()
                       </div>
                    </div>
                </div>                
            </section>
        </div>
        <footer>
            <div class="content-wrapper" align="center">   
                <div class="span10">
                    <iframe width="100%" height="175" scrolling="no" frameborder="no" src="https://w.soundcloud.com/player/?url=http%3A%2F%2Fapi.soundcloud.com%2Ftracks%2F76203416"></iframe>
                </div>
                <div class="float-left">
                    <p>&copy; @DateTime.Now.Year - FTI</p>
                </div>
            </div>
                @*<div class="float-right">
                    <ul id="social">
                        <li><a href="http://facebook.com" class="facebook">Facebook</a></li>
                        <li><a href="http://twitter.com" class="twitter">Twitter</a></li>
                    </ul>
                </div>*@
        </footer>        
    </body>
</html>
