Imports FTI.Internet.HTML

Public Class TournamentModel
    Public Sub New()
        GetDGLInfo()
    End Sub

    Public Teams As New List(Of String)
    Public Week(6) As List(Of String)
    Public Match As New List(Of String)

    Private WebPage As New WebPage
    Private Sub GetDGLInfo()
        Dim _html As String
        _html = WebPage.GetHTMLString("http://www.dogamingleague.co.za/stage.php?id=521")

        Dim HtmlDocument As New HtmlDocument
        HtmlDocument.LoadHtml(_html)
        Dim var = HtmlDocument.DocumentNode.SelectNodes("//table")
        Dim _HtmlNodeCollection As HtmlNodeCollection = WebPage.GetNodes(_html, "champion", "/html[1]/body[1]/div[2]/div[1]/table[1]//table[1]")

        'Team Rankings - B(11) - C(20) - H(65)
        Dim B = 0
        Dim C = 0
        Dim D = 0
        Dim H = 0
        Dim I = 0
        Dim count = 0
        For Each node As HtmlNode In _HtmlNodeCollection.Item(2).SelectNodes("tr")
            If (node.InnerHtml.Contains("Group B")) Then
                B = count
            ElseIf (node.InnerHtml.Contains("Group C")) Then
                C = count
            ElseIf (node.InnerHtml.Contains("Group D")) Then
                D = count
            ElseIf (node.InnerHtml.Contains("Group H")) Then
                H = count
            ElseIf (node.InnerHtml.Contains("Group I")) Then
                I = count
            End If
            count += 1
        Next

        count = 0
        For Each node As HtmlNode In _HtmlNodeCollection.Item(2).SelectNodes("tr")
            'For Each group As HtmlNode In table.SelectNodes("tr")
            If (count = 1) Then
                Teams.Add(node.InnerHtml)
            End If
            If (count >= B And count < C) Then
                Teams.Add(node.InnerHtml)
            End If
            If (count >= C And count < D) Then
                Teams.Add(node.InnerHtml)
            End If
            If (count >= H And count < I) Then
                Teams.Add(node.InnerHtml)
            End If
            'Next
            count += 1
        Next

        count = 0
        Do While (count < 7)
            Week(count) = New List(Of String)
            For Each node As HtmlNode In _HtmlNodeCollection.Item(3 + count).SelectNodes("tr")
                If node.InnerHtml.Contains("TmA") Then
                    Dim temp = node.SelectNodes("td")
                    Week(count).Add(temp.Item(0).InnerText + "  vs  " + temp.Item(2).InnerText)
                    Dim matchLink = DirectCast(temp.Item(2), HtmlNode).InnerHtml.Split("""")
                    Dim _matchhtml = WebPage.GetHTMLString(matchLink(1))
                    Dim matchHtmlDocument As New HtmlDocument
                    matchHtmlDocument.LoadHtml(_matchhtml)
                    Dim matchVar = matchHtmlDocument.DocumentNode.SelectNodes("//table")
                    Match.Add(DirectCast(matchVar.Item(1), HtmlNode).InnerHtml)
                End If
            Next
            count += 1
        Loop

        'Get Match
    End Sub
End Class
