Public Class FrmMain
    Public Sub New()

        InitializeComponent()

        Dim newSettings As Boolean = False
        Try
            If (IO.File.Exists(System.IO.Path.Combine(IO.Path.GetTempPath, AppGlobals.PARAM_FILE))) Then
                AppGlobals.Prm = XMLserialization.Deserialize(Of Settings)(System.IO.Path.Combine(IO.Path.GetTempPath, AppGlobals.PARAM_FILE))
            Else
                AppGlobals.Prm = New Settings()
                newSettings = True
            End If
            If (newSettings) Then
                Dim f As SettingsForm = New SettingsForm()
                If (f.ShowDialog = DialogResult.Cancel) Then
                    MessageBox.Show("Canceled settings in first run")
                    End
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim f As SettingsForm = New SettingsForm()
        AddHandler f.TestCommScale, AddressOf OnTestCommScale
        If (f.ShowDialog = DialogResult.OK) Then
            MessageBox.Show("TODO something when accepted settings")
        End If
    End Sub

    Private Sub OnTestCommScale(id As Integer)
        MessageBox.Show($"TODO something with scale {id}. Communication test performed from Settings form")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
