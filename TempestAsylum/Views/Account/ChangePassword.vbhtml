@ModelType TempestAsylum.ChangePasswordModel

@Code
    ViewData("Title") = "Change Password"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<hgroup class="title">
    <h2>Tempest Asylum Change Password</h2>
</hgroup>

<p class="message-info">
    Passwords must be at least @Membership.MinRequiredPasswordLength characters long.
</p>

@Using Html.BeginForm()
    @<div class="fg-color-red">
        @Html.ValidationSummary()
    </div>

    @<fieldset>
        <legend>Change Password</legend>
        <div align="left">    
            <div class="grid" >
                <div class="row">  
                    @Html.LabelFor(Function(m) m.OldPassword)
                </div>
                <div class="row"> 
                    @Html.PasswordFor(Function(m) m.OldPassword)
                </div>
                <div class="row"> 
                    @Html.LabelFor(Function(m) m.NewPassword)
                </div>
                <div class="row"> 
                    @Html.PasswordFor(Function(m) m.NewPassword)
                </div>
                <div class="row"> 
                    @Html.LabelFor(Function(m) m.ConfirmPassword)
                </div>
                <div class="row"> 
                    @Html.PasswordFor(Function(m) m.ConfirmPassword) 
                </div>
            </div>
        </div>
        <input type="submit" value="Change password" />
    </fieldset>
End Using