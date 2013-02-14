@ModelType TempestAsylum.TournamentModel
@code
    @<table>
        @For Each var As String In ViewData("Teams")
            If (var.Contains("sub_header")) Then
                var = var.Replace("width=""25px""", "width=""35px""")
            End If
            @<tr>
                @Html.Raw(var)
            </tr> 
        Next
    </table>
        
End Code
