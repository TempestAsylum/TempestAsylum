@ModelType TempestAsylum.RegisterModel

@Code
    ViewData("Title") = "Register"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<hgroup class="title">
    <h2>Tempest Asylum Registration</h2>
</hgroup>

@Using Html.BeginForm()
    @<div class="fg-color-red">
        @Html.ValidationSummary()
    </div>

    @<fieldset>
        <div align="left">    
            <div class="grid" >
                <div class="row">
                    @Html.LabelFor(Function(m) m.UserName)
                </div>
                <div class="row">
                    @Html.TextBoxFor(Function(m) m.UserName)
                </div>

                <div class="row">
                    @Html.LabelFor(Function(m) m.Email)
                </div>
                <div class="row">
                    @Html.TextBoxFor(Function(m) m.Email)
                </div>

                <div class="row">
                    @Html.LabelFor(Function(m) m.Password)
                </div>
                <div class="row">
                    @Html.PasswordFor(Function(m) m.Password)
                </div>

                <div class="row">
                    @Html.LabelFor(Function(m) m.ConfirmPassword)
                </div>
                <div class="row">
                    @Html.PasswordFor(Function(m) m.ConfirmPassword)
                </div>

                <span class="padding30"></span>

                <div class="row">
                    <fieldset>
                        <legend>Personal Info</legend>
                        <div class="row">
                            @Html.LabelFor(Function(m) m.FirstName)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.FirstName)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.Surname)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.Surname)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.DateOfBirth)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.DateOfBirth)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.Gender)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.Gender)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.City)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.City)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.Address)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.Address)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.CellNumber)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.CellNumber)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.HomeNumber)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.HomeNumber)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.WorkNumber)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.WorkNumber)
                        </div>

                        <div class="row">
                            @Html.LabelFor(Function(m) m.WorkAddress)
                        </div>
                        <div class="row">
                            @Html.TextBoxFor(Function(m) m.WorkAddress)
                        </div>
                    </fieldset>
                </div>
            </div>
            <input class="largesmoothrectange blackbutton" type="submit" value="Register" />
         </div>
    </fieldset>
End Using

