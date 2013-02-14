@ModelType TempestAsylum.PartialModel

@If (Home) Then
    @Html.Partial("~Views/Home/Index")
ElseIf (CodeofConduct) Then
    @Html.Partial("~Views/Home/CodeofConduct")
ElseIf (JusticeSystem) Then
    @Html.Partial("~Views/Home/JusticeSystem")
End If