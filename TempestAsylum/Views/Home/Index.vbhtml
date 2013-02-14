@Code
    ViewData("Title") = "Tempest Asylum"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


@If (Request.Url.AbsoluteUri.Contains("CodeofConduct")) Then
    @Html.Partial("CodeofConductPartial")
Else
    @Html.Partial("HomePartial")    
End If
