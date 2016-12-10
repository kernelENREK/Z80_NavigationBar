Namespace ParamModels

    Public Class SQLServerPrm
        Public Property DataSource As String
        Public Property Catalog As String
        Public Credentials As SQLServerCredentials

        Public Function ConnectionString(Optional catalog As String = "") As String
            Dim cat = Me.Catalog
            If (Not String.IsNullOrWhiteSpace(catalog)) Then
                cat = catalog
            End If

            Dim connStr As String = String.Format("Data Source={0};Initial Catalog={1};Pooling=false", Me.DataSource, cat)

            If (Me.Credentials.Authentication = SQLServerCredentials.AuthenticationType.Windows) Then
                connStr &= ";Integrated Security=true;"
            Else
                connStr &= String.Format(";Integrated Security=false;User ID={0};Password={1};", Me.Credentials.UserId, Me.Credentials.GetPassword(Me.Credentials.Password))
            End If

            Return connStr
        End Function

        Public Sub New()
            Me.DataSource = ".\SQLEXPRESS"
            Me.Catalog = "Northwind"
            Me.Credentials = New SQLServerCredentials() With {
                .Authentication = SQLServerCredentials.AuthenticationType.SQLServer,
                .UserId = "sa", .Password = "%root%"
                            }
        End Sub
    End Class

    Public Class SQLServerCredentials

        Public Enum AuthenticationType
            Windows = 0
            SQLServer = 1
        End Enum

        Public Property Authentication As AuthenticationType
        Public Property UserId As String
        Public Property Password As String

        Public Function GetPassword(password As String) As String
            'TODO: Decrypt password
            Return "12345"
        End Function

        Public Function SetPassword(password As String) As String
            'TODO: Encrypt password
            Return "12345"
        End Function

    End Class

End Namespace
