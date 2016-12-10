Imports ExampleSettings.ParamModels

Public Class UC_Scale

    Private _testCommDone As Boolean
    Public Event OnTestCommScale(sender As Object)

    Public Scale_OriginalID As Integer

    Private _validationOK As Boolean
    Public ReadOnly Property ValidationOK As Boolean
        Get
            Return _validationOK
        End Get
    End Property

    Private _param As ScalePrm
    Public Property Param As ScalePrm
        Get
            Return _param
        End Get
        Set(value As ScalePrm)
            _param = value
            TxtID.Text = value.ID
            Scale_OriginalID = value.ID
            TxtProtocol.Text = value.Protocol
        End Set
    End Property

    Private Sub OnValidation()
        _validationOK = True
        If (Not String.IsNullOrEmpty(TxtID.Text)) Then
            _param.ID = Convert.ToInt32(TxtID.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TxtProtocol.Text)) Then
            _param.Protocol = TxtProtocol.Text.Trim()
        Else
            _validationOK = False
        End If

        BtnTestComm.Enabled = _validationOK
    End Sub

    Private Sub BtnTestComm_Click(sender As Object, e As EventArgs) Handles BtnTestComm.Click
        If (Not _testCommDone) Then
            If (MessageBox.Show("some message here. ¿continue?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                Exit Sub
            End If
        End If
        _testCommDone = True
        RaiseEvent OnTestCommScale(Me)

        'TODO: implement Comm test

        MessageBox.Show("TODO communication test: Test done", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub New()

        InitializeComponent()

        _param = New ScalePrm()

        AddHandler TxtID.TextChanged, AddressOf OnValidation
        AddHandler TxtProtocol.TextChanged, AddressOf OnValidation

    End Sub

End Class
