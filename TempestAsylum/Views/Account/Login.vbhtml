@ModelType TempestAsylum.LoginModel

@Code
    ViewData("Title") = "Log in"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<hgroup class="title">
    <h2>Tempest Asylum Log in</h2>
</hgroup>

@Using Html.BeginForm(New With {.ReturnUrl = ViewBag.ReturnUrl})
    @<div class="fg-color-red">
        @Html.ValidationSummary(True, "Log in was unsuccessful. Please correct the errors and try again.")       
    </div>
    
    @<fieldset>
        <legend>Log in</legend>  
        <div align="left">    
            <div class="grid" >
                <div class="row">                
                    @Html.LabelFor(Function(m) m.Username)
                </div>
                <div class="row">                
                    @Html.PasswordFor(Function(m) m.UserName)
                </div>
                <div class="row">                
                    @Html.LabelFor(Function(m) m.Password)
                </div>
                <div class="row">                
                    @Html.PasswordFor(Function(m) m.Password)
                </div>
                <div class="row">                
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
