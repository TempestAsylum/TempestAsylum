<div id="main-wrap">

    <!-- Start Left Section -->
    <div class="leftsection">
        <!-- Start Slider Wrapping -->
        <div id="sliderwrap">
            <div id="slider" class="nivoSlider shadow">
                <img width="400" height="400" src="~/images/TmA.jpg">
            </div>
        </div>
        <!-- End Slider Wrapping -->

        <!-- Start H1 Title -->
        <div class="titles shadow">

            <h1>Latest News</h1>

            <span></span>

        </div>
        <!-- End H1 Title -->

        <!-- Start Main Body Wrap -->
        <div id="main-wrap">

            <!-- Start Featured Boxes -->
            <div class="boxes-half boxes-first shadow">
                <div class="boxes-padding">
                    <h3 align="center">Lady Fury</h3>
                    <div class="featured-text">TMA's Denae “LadyFury” Horn Talks the LoL Season</div>
                    <p>With the Telkom Do Gaming League (DGL) 2013 set to kick off, records have already been broken, opponents have been drawn and teams now take to the battlefield for what looks to be the most competitive year yet in the local gaming community.</p>
                    <a href="http://gaming.do.co.za/articles/competitive/lol_dgl_dogamingleague_tempestasyum_interview.htm">
                        <h5>&nbsp;Read More...</h5>
                    </a>
                </div>
            </div>

            <div class="boxes-half boxes-last shadow">
                <div class="boxes-padding">
                    <h3 align="center">Darklord</h3>
                    <div class="featured-text">New Champion Just Before LoL Summer Leg</div>
                    <p>Just in time for the launch of the Telkom Do Gaming League (DGL) 2013 Summer Leg for League of Legends, a new support Champion has been revealed - Thresh.</p>
                    <p>&nbsp;We spoke to Reinier 'Darklord' Schoeman, Captain and support for -TmA-Delta Squadron in the DGL, about this newest addition to the “Champions family”, to get some opinion. </p>
                    <a href="http://gaming.do.co.za/articles/competitive/new_champion_just_before_lol_leg_one.htm">
                        <h5>&nbsp;Read More...</h5>
                    </a>
                </div>
            </div>
            <!-- End Featured Boxes -->
        </div>
    </div>
    <!-- End Left Section -->

    <!-- Start Right Section -->
    <div class="rightsection">
        @Html.Partial("_sponsor")

        <!-- Start Blog Widget -->
        <div class="blogwidget shadow">
            <!-- Start Categories Widget -->
            <div class="widgettitle">
                <h4>Tempest Asylum</h4>
            </div>

            <div class="widgetbody">

                <div class="blogcategories">
                    <ul>
                        <li>@Html.ActionLink("Code of Conduct", "CodeofConduct", "Home")</li>
                        <li>@Html.ActionLink("Justice System", "JusticeSystem", "Home")</li>
                    </ul>
                </div>

            </div>
            <!-- End Categories Widget -->
            <span class="box-arrow"></span>

        </div>
        <!-- End Blog Widget -->

        @Html.Partial("~/Views/Tournament/TournamentPartial.vbhtml")

    </div>
    <!-- End Right Section -->

</div>
