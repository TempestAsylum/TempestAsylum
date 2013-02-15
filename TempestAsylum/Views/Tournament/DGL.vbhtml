@Code
    ViewData("Title") = "Tempest Asylum - DGL"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div id="main-wrap">
    <div class="leftsection">
        <div class="titlesnormal">
            <h1>DGL - Stats</h1>
            <span></span>
        </div>

        <div id="main-wrap">
            <div class="boxes-full shadow">
                @Html.Partial("~/Views/Tournament/DGL/_Teams.vbhtml")
            </div>
            <div class="boxes-full shadow">
                @Html.Partial("~/Views/Tournament/DGL/_Schedule.vbhtml")
            </div>
            @*<div class="boxes-full">
                    @Html.Partial("~/Views/Tournament/DGL/_Match.vbhtml")
        	    </div>     *@
        </div>
    </div>

    <div class="rightsection">
        @Html.Partial("_sponsor")
    </div>
</div>
