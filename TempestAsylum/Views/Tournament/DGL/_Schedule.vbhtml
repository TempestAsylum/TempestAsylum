@ModelType TempestAsylum.TournamentModel

@code
    @<h2>Week 1 - 29Jan - 4Feb</h2>
    @For Each var As String In ViewData("Schedule1")
        @<div>
            @Html.Raw(var)
        </div>
        Next
    
    @<h2>Week 2 - 5Feb - 14Feb</h2>
    @For Each var As String In ViewData("Schedule2")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 3 - 12Feb - 18Feb</h2>
    @For Each var As String In ViewData("Schedule3")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 4 - 19Feb - 25Feb</h2>
    @For Each var As String In ViewData("Schedule4")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 5 - 26Feb - 4Mar</h2>
    @For Each var As String In ViewData("Schedule5")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 6 - 5Mar - 11Mar</h2>
    @For Each var As String In ViewData("Schedule6")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 7 - 12Mar - 18Mar</h2>
    @For Each var As String In ViewData("Schedule7")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
        
End Code
