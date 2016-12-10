Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public NotInheritable Class XMLserialization

    Public Shared Sub Serialize(Of T)(ByVal filename As String, ByVal data As T)
        Try
            Using fs As FileStream = New FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
                Using ms As MemoryStream = New MemoryStream
                    Dim serializer As New XmlSerializer(GetType(T))
                    serializer.Serialize(ms, data)
                    Dim xml As String = System.Text.Encoding.UTF8.GetString(ms.ToArray())

                    Using writer As StreamWriter = New StreamWriter(fs)
                        writer.WriteLine(xml)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Function Deserialize(Of T)(ByVal filename As String) As T
        Dim data As T = Nothing
        Try
            Using fs As FileStream = New FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read)
                Using reader As StreamReader = New StreamReader(fs)
                    Dim serializer As New XmlSerializer(GetType(T))
                    data = DirectCast(serializer.Deserialize(reader), T)
                End Using
            End Using
        Catch ex As InvalidOperationException
            Throw New InvalidOperationException(ex.Message)
        Catch ex As FileNotFoundException
            Throw New FileNotFoundException(ex.Message)
        Catch ex As IOException
            Debug.Print("+++> XMLSerialization.Deserialize IOException")
            Try
                Dim hr As Integer = System.Runtime.InteropServices.Marshal.GetHRForException(ex)
                If (hr <> -2147024864) Then
                    Throw New System.IO.IOException(ex.Message)
                End If
            Catch exio As Exception
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return data
    End Function

End Class
