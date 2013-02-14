@Html.Partial("_Head")
@Html.Partial("~/Views/Shared/body/_Header.vbhtml")
<div id="content">
    @RenderBody()
</div>
@Html.Partial("~/Views/Shared/body/_Footer.vbhtml")
