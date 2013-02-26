@Code
    ViewData("Title") = "Tempest Asylum - Tournaments"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div id="main-wrap">

    <!-- Start Left Section -->
    <div class="leftsection">
        <!-- Start H1 Title -->
        <div class="titlesnormal">

            <h1>Tournaments</h1>

            <span></span>

        </div>
        <!-- End H1 Title -->
        <!-- Start Main Body Wrap -->
        <div id="main-wrap">

            <!-- Start Box -->
            <div class="boxes-full">

                <div class="boxes-padding fullpadding">

                    <!-- Start None Split Section -->
                    <div class="splitnone">

                        <div id="portfolio-container">


                            <a href="~/Tournament/DGL">
                                <div class="element2 logo">

                                    <div class="portfoliowrap">
                                        <div class="title">Tournaments - DGL<span class="titlearrow"></span></div>
                                        <div class="portfolioimage">
                                            <img src="~/images/tournaments/dgl.png" width="305" height="132" border="0"></div>
                                        <div class="text">
                                            League of Legends is the most played game in the world and just so happens to be perfectly designed for league play. The Do Gaming League is proud to host a league for such an amazing title and its respective community.
                                            <span class="textarrow"></span>
                                        </div>
                                    </div>

                                </div>
                            </a>

                            <a href="~/Tournament/TmAInternal">
                                <div class="element2 logo">

                                    <div class="portfoliowrap">
                                        <div class="title">Tournaments - TmA Internal<span class="titlearrow"></span></div>
                                        <div class="portfolioimage">
                                            <img src="~/images/tma.png" width="305" height="132" border="0"></div>
                                        <div class="text">
                                            Tempest Asylums Internal Tournament
                                            <span class="textarrow"></span>
                                        </div>
                                    </div>

                                </div>
                            </a>

                        </div>

                    </div>
                    <!-- End None Split Section -->

                </div>

                <span class="box-arrow"></span>

            </div>
            <!-- End Box -->

        </div>
        <!-- End Main Body Wrap -->
    </div>
    <!-- End Left Section -->

    <!-- Start Right Section -->
    <div class="rightsection">
        @Html.Partial("_sponsor")

    </div>
    <!-- End Right Section -->

</div>
