@Code
    ViewData("Title") = "TmAInternal"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div id="main-wrap">
    <div class="leftsection">
        <div class="titlesnormal">
            <h1>TmA Internal Tournament</h1>
            <span></span>
        </div>

        <div id="main-wrap">
            <div class="boxes-full shadow">
                @Html.Partial("~/Views/Tournament/TmAInternal/Teams.vbhtml")
            </div>
            <div class="boxes-full shadow">
                @Html.Partial("~/Views/Tournament/TmAInternal/Bracket.vbhtml")
            </div>
            <div class="boxes-full shadow">
                @Html.Partial("~/Views/Tournament/TmAInternal/MemberSponsors.vbhtml")
            </div>
        </div>
    </div>

    <div class="rightsection">
        @Html.Partial("_sponsor")
    </div>
</div>
