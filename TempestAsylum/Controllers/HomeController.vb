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
            Return PartialView("HomePartial")
        End Function

        Function CodeofConductPartial() As ActionResult
            Return PartialView("CodeofConductPartial")
        End Function

        Function JusticeSystemPartial() As ActionResult
            Return PartialView("JusticeSystemPartial")
        End Function
    End Class
End Namespace