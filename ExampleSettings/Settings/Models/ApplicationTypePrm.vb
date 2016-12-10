Namespace ParamModels

    Public Class ApplicationTypePrm
        Public Enum ApplicationType
            UserRole = 0
            AdminRole = 1
        End Enum

        Public Type As ApplicationType
        Public Property WCFHost As String
        Public Property WCFPort As Integer

        Public Sub New()
            Me.Type = ApplicationType.UserRole
            Me.WCFHost = "192.168.1.34"
            Me.WCFPort = 23124
        End Sub

    End Class

End Namespace