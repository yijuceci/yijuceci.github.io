Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Product() As ActionResult
        Return View()
    End Function
    '<HttpPost>
    'Public Function GetTest(id As Integer) As String

    '    Return "5"
    'End Function
End Class
