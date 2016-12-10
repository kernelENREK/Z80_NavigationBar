Imports ExampleSettings.ParamModels

Public Class UC_TempSensor

    Private _validationOK As Boolean
    Public ReadOnly Property ValidationOK As Boolean
        Get
            Return _validationOK
        End Get
    End Property

    Private _param As TempSensorPrm
    Public Property Param As TempSensorPrm
        Get
            Return _param
        End Get
        Set(value As TempSensorPrm)
            _param = value
            TxtMin.Text = value.MinTemperature
            TxtMax.Text = value.MaxTemperature
        End Set
    End Property

    Private Sub OnValidation()
        _validationOK = True
        If (Not String.IsNullOrEmpty(TxtMin.Text)) Then
            _param.MinTemperature = Convert.ToInt32(TxtMin.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TxtMax.Text)) Then
            _param.MaxTemperature = Convert.ToInt32(TxtMax.Text)
        Else
            _validationOK = False
        End If
    End Sub

    Public Sub New()

        InitializeComponent()

        _param = New TempSensorPrm()

        AddHandler TxtMin.TextChanged, AddressOf OnValidation
        AddHandler TxtMax.TextChanged, AddressOf OnValidation
    End Sub

End Class
