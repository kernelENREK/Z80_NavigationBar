Imports System.Net
Imports System.Text.RegularExpressions

Namespace Helpers

    Public NotInheritable Class IPExtensions
        Public Shared Function IsValidIP(address As String) As Boolean
            If Not Regex.IsMatch(address, "\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b") Then
                Return False
            End If

            Dim ip As IPAddress = Nothing
            Return IPAddress.TryParse(address, ip)
        End Function

    End Class

End Namespace
