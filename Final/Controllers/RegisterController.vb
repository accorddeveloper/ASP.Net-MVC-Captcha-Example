Imports System.Web.Mvc
Imports CaptchaMvc.HtmlHelpers

Namespace Controllers
    Public Class RegisterController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function
        <HttpPost>
        Public Function Index(empty As String) As ActionResult
            ' Codefor validating the CAPTCHA
            If Me.IsCaptchaValid("Captchais not valid") Then

                Return RedirectToAction("ThankYouPage")
            End If

            ViewBag.ErrMessage = "Error: captcha is not valid."
            Return View()
        End Function

        Public Function ThankYouPage() As ActionResult
            Return View()
        End Function
    End Class
End Namespace