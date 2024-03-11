Public Class UserSession
    Private Shared _instance As UserSession
    Public Property UserID As Integer

    Public Shared Function GetInstance() As UserSession
        If _instance Is Nothing Then
            _instance = New UserSession()
        End If
        Return _instance
    End Function
End Class
