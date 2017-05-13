Imports ExampleSettings.ParamModels
Imports ExampleSettings.Z80NavBar
Imports ExampleSettings.Z80NavBar.Themes

Public Class SettingsForm

    Private _lPrm As Settings
    Public Event TestCommScale(id As Integer)

    Public Sub New()

        InitializeComponent()

        Z80_Navigation1.Initialize(New CfgNavItems().myNavItems, New ThemeSelector(Theme.Dark).CurrentTheme)

        If (IO.File.Exists(System.IO.Path.Combine(IO.Path.GetTempPath(), AppGlobals.PARAM_FILE))) Then
            _lPrm = XMLserialization.Deserialize(Of Settings)(IO.Path.Combine(System.IO.Path.GetTempPath(), AppGlobals.PARAM_FILE))
        Else
            _lPrm = AppGlobals.Prm
        End If

        ShowAppType()
        ShowScales()
        ShowTempSensor()
        ShowDatabase()

        ShowSettings(eSettingsPanels.AppType)

    End Sub

#Region "Show Settings"

#Region "Zilog80 Navigation control stuff"

    Private Sub ShowSettings(typePanel As eSettingsPanels)
        Z80_Navigation1.ItemSelect(typePanel)
    End Sub

    Private Sub Z80_Navigation1_SelectedItem(item As NavBarItem) Handles Z80_Navigation1.SelectedItem
        For Each control In Panel1.Controls.OfType(Of Panel)
            If (control.Tag IsNot Nothing AndAlso Convert.ToInt32(control.Tag) = item.ID) Then
                control.Visible = True
            Else
                control.Visible = False
            End If
        Next
    End Sub

#End Region

#Region "Application type"

    Private Sub ShowAppType()
        FlowLayoutPanel_AppTypePrm.SuspendLayout()
        Dim uc As New UC_ApplicationBehaviour
        AddHandler uc.OnApplicationTypeChanged, AddressOf OnApplicationTypeChanged

        uc.Param = _lPrm.ApplicationBehaviour
        FlowLayoutPanel_AppTypePrm.Controls.Add(uc)
        OnApplicationTypeChanged(_lPrm.ApplicationBehaviour.Type)
        FlowLayoutPanel_AppTypePrm.ResumeLayout()
    End Sub

    Private Sub OnApplicationTypeChanged(type As ApplicationTypePrm.ApplicationType)
        If (type = ApplicationTypePrm.ApplicationType.UserRole) Then
            Z80_Navigation1.ItemChangeEnable(True, eSettingsPanels.Hardware)
        Else
            Z80_Navigation1.ItemChangeEnable(False, eSettingsPanels.Hardware)
        End If
    End Sub

#End Region

#Region "Hardware: Scales"

    Private Sub ShowScales()
        FlowLayoutPanel_ScalePrm.SuspendLayout()
        For Each _scale In _lPrm.Hardware.Scales
            Dim uc As New UC_Scale
            AddHandler uc.OnTestCommScale, AddressOf OnTestCommScale

            uc.Param = _scale
            FlowLayoutPanel_ScalePrm.Controls.Add(uc)
        Next
        FlowLayoutPanel_ScalePrm.ResumeLayout()
    End Sub

    Private Sub OnTestCommScale(sender As Object)
        Dim c = DirectCast(sender, UC_Scale)
        RaiseEvent TestCommScale(c.Scale_OriginalID)
    End Sub

#End Region

#Region "Hardware: Temperature sensor"

    Private Sub ShowTempSensor()
        FlowLayoutPanel_TempSensorPrm.SuspendLayout()
        Dim uc As New UC_TempSensor
        uc.Param = _lPrm.Hardware.TemperatureSensor
        FlowLayoutPanel_TempSensorPrm.Controls.Add(uc)
        FlowLayoutPanel_TempSensorPrm.ResumeLayout()
    End Sub

#End Region

#Region "Database"

    Private Sub ShowDatabase()
        FlowLayoutPanel_DatabasePrm.SuspendLayout()
        Dim uc As New UC_DataBase
        uc.Param = _lPrm.DB
        FlowLayoutPanel_DatabasePrm.Controls.Add(uc)
        FlowLayoutPanel_DatabasePrm.ResumeLayout()
    End Sub

#End Region

#End Region

#Region "Assign Settings"

#Region "Validations"

    Private Function ValidationOK() As Boolean
        Dim validateHardware As Boolean = True

        For Each control In FlowLayoutPanel_AppTypePrm.Controls.OfType(Of UC_ApplicationBehaviour)
            If (Not control.ValidationOK) Then
                MessageBox.Show("Some application settings are wrong")
                ShowSettings(eSettingsPanels.AppType)
                Return False
            Else
                If (control.Param.Type = ApplicationTypePrm.ApplicationType.AdminRole) Then
                    validateHardware = False
                End If
            End If
        Next

        If (validateHardware) Then
            Dim scalesID As List(Of Integer) = New List(Of Integer)()
            For Each control In FlowLayoutPanel_ScalePrm.Controls.OfType(Of UC_Scale)
                scalesID.Add(control.Param.ID)
                If (Not control.ValidationOK) Then
                    MessageBox.Show("Some scale settings are wrong")
                    ShowSettings(eSettingsPanels.Scales)
                    Return False
                End If
            Next
            For Each id In scalesID
                Dim duplicates = scalesID.FindAll(Function(c) c = id).ToList()
                If (duplicates.Count > 1) Then
                    MessageBox.Show("No scale ID duplicates allowed")
                    ShowSettings(eSettingsPanels.Scales)
                    Return False
                End If
            Next

            For Each control In FlowLayoutPanel_TempSensorPrm.Controls.OfType(Of UC_TempSensor)
                If (Not control.ValidationOK) Then
                    MessageBox.Show("Some temperature sensor settings are wrong")
                    ShowSettings(eSettingsPanels.TemperatureSensor)
                    Return False
                End If
            Next
        End If

        For Each control In FlowLayoutPanel_DatabasePrm.Controls.OfType(Of UC_DataBase)
            If (Not control.ValidationOK) Then
                MessageBox.Show("Some database settings are wrong")
                ShowSettings(eSettingsPanels.Database)
                Return False
            End If
        Next

        Return True
    End Function

#End Region

    Private Sub SetUpSettings()
        For Each control In FlowLayoutPanel_AppTypePrm.Controls.OfType(Of UC_ApplicationBehaviour)
            AppGlobals.Prm.ApplicationBehaviour = control.Param
        Next
        If (AppGlobals.Prm.ApplicationBehaviour.Type = ApplicationTypePrm.ApplicationType.UserRole) Then
            For Each control In FlowLayoutPanel_ScalePrm.Controls.OfType(Of UC_Scale)
                For i As Integer = 0 To AppGlobals.Prm.Hardware.Scales.Count - 1
                    If (AppGlobals.Prm.Hardware.Scales(i).ID = control.Scale_OriginalID) Then
                        AppGlobals.Prm.Hardware.Scales(i) = control.Param
                        Exit For
                    End If
                Next
            Next
            For Each control In FlowLayoutPanel_TempSensorPrm.Controls.OfType(Of UC_TempSensor)
                AppGlobals.Prm.Hardware.TemperatureSensor = control.Param
            Next
        End If
        For Each control In FlowLayoutPanel_DatabasePrm.Controls.OfType(Of UC_DataBase)
            AppGlobals.Prm.DB = control.Param
        Next
    End Sub

#End Region

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If (ValidationOK()) Then
            If (MessageBox.Show("Are you sure accept settings?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes) Then
                SetUpSettings()
                Try
                    XMLserialization.Serialize(IO.Path.Combine(IO.Path.GetTempPath, AppGlobals.PARAM_FILE), AppGlobals.Prm)
                    Me.DialogResult = DialogResult.OK
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

End Class