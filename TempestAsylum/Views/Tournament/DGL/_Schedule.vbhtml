@ModelType TempestAsylum.TournamentModel

@code
    @<h2>Week 1</h2>
    @For Each var As String In ViewData("Schedule1")
        @<div>
            @Html.Raw(var)
        </div>
        Next
    
    @<h2>Week 2</h2>
    @For Each var As String In ViewData("Schedule2")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 3</h2>
    @For Each var As String In ViewData("Schedule3")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 4</h2>
    @For Each var As String In ViewData("Schedule4")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 5</h2>
    @For Each var As String In ViewData("Schedule5")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 6</h2>
    @For Each var As String In ViewData("Schedule6")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
    @<h2>Week 7</h2>
    @For Each var As String In ViewData("Schedule7")
        @<div>
            @Html.Raw(var)
        </div>
    Next
        
        
End Code
