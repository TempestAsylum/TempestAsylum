Namespace TempestAsylum
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Home
        Function Index() As ActionResult
            Return View()
        End Function

        'Function Index(VSession As String) As ActionResult
        '    ViewData("Partial") = VSession
        '    Return View()
        'End Function

        Function HomePartial() As ActionResult
            Return PartialView("Home")
        End Function

        Function CodeofConduct() As ActionResult
            Return PartialView("CodeofConduct")
        End Function

        Function JusticeSystem() As ActionResult
            Return PartialView("JusticeSystem")
        End Function
    End Class
End Namespace