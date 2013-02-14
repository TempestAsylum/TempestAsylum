@ModelType TempestAsylum.LoginModel

@Code
    ViewData("Title") = "Log in"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div id="main-wrap">
        
    <!-- Start Left Section -->
    <div class="leftsection">        
        <!-- Start H1 Title -->
        <div class="titles shadow">
    
    	    <h1>Tempest Asylum Log in</h1>
        
            <span></span>
    
        </div>
        <!-- End H1 Title -->

        <!-- Start Main Body Wrap -->
        <div id="main-wrap">    
            <div class="boxes-full shadow">   
                @Using Html.BeginForm(New With {.ReturnUrl = ViewBag.ReturnUrl})
                @<div class="fg-color-red">
                    @Html.ValidationSummary(True, "Log in was unsuccessful. Please correct the errors and try again.")       
                </div>


                @<fieldset>
                    <legend>Log in</legend>  
                    <div align="left">    
                        <div class="grid" >
                            <div class="row contacttextform">         
                                <input id="name" name="name" type="text" onfocus="if (this.value == 'Username') {this.value = '';}" value="Username">
                            </div>
                            <div class="row contacttextform">         
                                <input id="name" name="name" type="text" onfocus="if (this.value == 'Password') {this.value = '';}" value="Password">    
                            </div>
                            <div class="row contacttextform">                
                                @Html.LabelFor(Function(m) m.Password)
                            </div>
                            <div class="row contacttextform">                
                                @Html.PasswordFor(Function(m) m.Password)
                            </div>
                            <div class="row contacttextform">                
                                @Html.CheckBoxFor(Function(m) m.RememberMe)
                                @Html.LabelFor(Function(m) m.RememberMe, New With {.class = "checkbox" })
                            </div>
                        </div>

                        <input type="submit" value="Log in" />
                        <p>
                            @Html.ActionLink("Register", "Register") if you don't have an account.
                        </p>
                    </div>
                </fieldset>
    
            End Using
            </div>
        </div>  
    </div>
    <!-- End Left Section -->
        
    <!-- Start Right Section -->
    <div class="rightsection">
        @Html.Partial("_sponsor")

    </div>
    <!-- End Right Section -->
    
</div>


