@ModelType TempestAsylum.TournamentModel
@code
    @<table>
        @For Each var As String In ViewData("Match")
            @<tr>
                @Html.Raw(var)
            </tr> 
        Next
    </table>
        
End Code