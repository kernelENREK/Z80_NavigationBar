Imports ExampleSettings.ParamModels

Public Class Settings
    Public Hardware As HardwarePrm
    Public DB As SQLServerPrm
    Public ApplicationBehaviour As ApplicationTypePrm

    Public Sub New()
        Me.Hardware = New HardwarePrm()

        Me.Hardware.Scales = New List(Of ScalePrm)()
        For i As Integer = 1 To 4
            Dim scale As ScalePrm = New ScalePrm() With {.ID = i, .Protocol = "Something here"}
            Me.Hardware.Scales.Add(scale)
        Next

        Me.Hardware.TemperatureSensor = New TempSensorPrm()

        Me.DB = New SQLServerPrm()
        Me.ApplicationBehaviour = New ApplicationTypePrm()
    End Sub
End Class
