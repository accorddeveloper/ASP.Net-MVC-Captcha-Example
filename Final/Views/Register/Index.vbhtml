@Imports CaptchaMvc
@Imports CaptchaMvc.HtmlHelpers
@ModelType Final.feedback


@Using (Html.BeginForm())

    @Html.ValidationSummary(True)
    @<br />
    @<br />

    @<fieldset style = "width: 50%; margin: 0 auto;" >
        <legend>Register</legend>
        <div>
        <div Class="editor-label">
        @Html.LabelFor(Function(m) m.Title)
            </div>
            <div Class="editor-field">
                @Html.EditorFor(Function(m) m.Title)
                @Html.ValidationMessageFor(Function(m) m.Title)
            </div>
        </div>
        <div>
        <div Class="editor-label">
        @Html.LabelFor(Function(m) Model.Comment)
            </div>
            <div Class="editor-field">
                @Html.TextAreaFor(Function(m) m.Comment, 5, 40, vbNull)
                @Html.ValidationMessageFor(Function(m) m.Comment)
            </div>

        </div>

        @Html.MathCaptcha()

        <br />
        <p Class="Error">@ViewBag.ErrMessage </p>
        <p style = "text-align: right; padding-right: 20px;" >
            <input type="submit" value="Send"/>
        </p>
    </fieldset>
    End Using