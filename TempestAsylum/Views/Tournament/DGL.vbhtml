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
                <div class="boxes-full">
                    @Html.Partial("~/Views/Tournament/DGL/_Teams.vbhtml")
        	    </div>         
                <div class="boxes-full">
                    @Html.Partial("~/Views/Tournament/DGL/_Schedule.vbhtml")
        	    </div>             
        	</div>
        </div>

         <div class="rightsection">

            <div class="blogwidgetstart">

                <div class="widgettitle"><h4>Advertising</h4></div>
                
                <div class="widgetbody">
                
                    <div class="blogadvertising">
                    
                    <a href="#"><img src="~/images/advertising/add.jpg" alt="Add"></a>
                    
                    </div>
                
                </div>

                <span class="box-arrow"></span>
            
            </div>     
        </div>    
    </div>