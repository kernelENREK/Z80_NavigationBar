Imports ExampleSettings.ParamModels

Public Class UC_ApplicationBehaviour

    Public Event OnApplicationTypeChanged(type As ApplicationTypePrm.ApplicationType)

    Private _validationOK As Boolean
    Public ReadOnly Property ValidationOK As Boolean
        Get
            Return _validationOK
        End Get
    End Property

    Private _param As ApplicationTypePrm
    Public Property Param As ApplicationTypePrm
        Get
            Return _param
        End Get
        Set(value As ApplicationTypePrm)
            _param = value
            If (value.Type = ApplicationTypePrm.ApplicationType.UserRole) Then
                RbtnUser.Checked = True
            Else
                RbtnAdmin.Checked = True
            End If
            TxtWCFHost.Text = value.WCFHost
        End Set
    End Property

    Private Sub OnValidation()
        _validationOK = True
        If (_param.Type = ApplicationTypePrm.ApplicationType.AdminRole) Then
            If (Helpers.IPExtensions.IsValidIP(TxtWCFHost.Text)) Then
                TxtWCFHost.BackColor = SystemColors.Window
                _param.WCFHost = TxtWCFHost.Text
            Else
                TxtWCFHost.BackColor = TxtWCFHost.Z80_BackColorEmptyText
                _validationOK = False
            End If
        End If
    End Sub

    Private Sub RbtnUser_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnUser.CheckedChanged
        If (RbtnUser.Checked) Then
            _param.Type = ApplicationTypePrm.ApplicationType.UserRole
        Else
            _param.Type = ApplicationTypePrm.ApplicationType.AdminRole
        End If

        Label1.Visible = Not RbtnUser.Checked
        TxtWCFHost.Visible = Label1.Visible

        RaiseEvent OnApplicationTypeChanged(_param.Type)

        OnValidation()
    End Sub

    Private Sub RbtnAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnAdmin.CheckedChanged
        OnValidation()
    End Sub

    Public Sub New()

        InitializeComponent()

        _param = New ApplicationTypePrm()

        AddHandler TxtWCFHost.TextChanged, AddressOf OnValidation

    End Sub

End Class
