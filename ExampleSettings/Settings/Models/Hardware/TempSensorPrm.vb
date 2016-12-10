Namespace ParamModels

    Public Class TempSensorPrm
        Public Property MinTemperature As Integer
        Public Property MaxTemperature As Integer

        Public Sub New()
            Me.MinTemperature = 2
            Me.MaxTemperature = 50
        End Sub
    End Class

End Namespace
