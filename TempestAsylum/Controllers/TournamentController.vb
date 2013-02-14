Namespace TempestAsylum
    Public Class TournamentController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Tournament

        Function Index() As ActionResult
            Return View()
        End Function

        Function DGL() As ActionResult
            Dim Tournament = New TournamentModel

            ViewData("Teams") = Tournament.Teams
            ViewData("Schedule1") = Tournament.Week(0)
            ViewData("Schedule2") = Tournament.Week(1)
            ViewData("Schedule3") = Tournament.Week(2)
            ViewData("Schedule4") = Tournament.Week(3)
            ViewData("Schedule5") = Tournament.Week(4)
            ViewData("Schedule6") = Tournament.Week(5)
            ViewData("Schedule7") = Tournament.Week(6)
            ViewData("Match") = Tournament.Match
            Return View()
        End Function

        Function TmAInternal() As ActionResult
            Return View()
        End Function


        Function Rules() As ActionResult
            Return View()
        End Function

        Function Teams() As ActionResult
            Return View()
        End Function
    End Class
End Namespace