<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelApplicationTypePrm = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel_AppTypePrm = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelScalePrm = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel_ScalePrm = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelTempSensorPrm = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel_TempSensorPrm = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelDatabasePrm = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel_DatabasePrm = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Z80_Navigation1 = New ExampleSettings.Z80_Navigation()
        Me.Panel1.SuspendLayout()
        Me.PanelApplicationTypePrm.SuspendLayout()
        Me.PanelScalePrm.SuspendLayout()
        Me.PanelTempSensorPrm.SuspendLayout()
        Me.PanelDatabasePrm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PanelApplicationTypePrm)
        Me.Panel1.Controls.Add(Me.PanelScalePrm)
        Me.Panel1.Controls.Add(Me.PanelTempSensorPrm)
        Me.Panel1.Controls.Add(Me.PanelDatabasePrm)
        Me.Panel1.Location = New System.Drawing.Point(191, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 462)
        Me.Panel1.TabIndex = 1
        '
        'PanelApplicationTypePrm
        '
        Me.PanelApplicationTypePrm.Controls.Add(Me.FlowLayoutPanel_AppTypePrm)
        Me.PanelApplicationTypePrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelApplicationTypePrm.Location = New System.Drawing.Point(0, 0)
        Me.PanelApplicationTypePrm.Name = "PanelApplicationTypePrm"
        Me.PanelApplicationTypePrm.Size = New System.Drawing.Size(593, 462)
        Me.PanelApplicationTypePrm.TabIndex = 0
        Me.PanelApplicationTypePrm.Tag = "1"
        '
        'FlowLayoutPanel_AppTypePrm
        '
        Me.FlowLayoutPanel_AppTypePrm.AutoScroll = True
        Me.FlowLayoutPanel_AppTypePrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel_AppTypePrm.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel_AppTypePrm.Name = "FlowLayoutPanel_AppTypePrm"
        Me.FlowLayoutPanel_AppTypePrm.Size = New System.Drawing.Size(593, 462)
        Me.FlowLayoutPanel_AppTypePrm.TabIndex = 0
        '
        'PanelScalePrm
        '
        Me.PanelScalePrm.Controls.Add(Me.Label1)
        Me.PanelScalePrm.Controls.Add(Me.FlowLayoutPanel_ScalePrm)
        Me.PanelScalePrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelScalePrm.Location = New System.Drawing.Point(0, 0)
        Me.PanelScalePrm.Name = "PanelScalePrm"
        Me.PanelScalePrm.Size = New System.Drawing.Size(593, 462)
        Me.PanelScalePrm.TabIndex = 1
        Me.PanelScalePrm.Tag = "2001"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scales configuration"
        '
        'FlowLayoutPanel_ScalePrm
        '
        Me.FlowLayoutPanel_ScalePrm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel_ScalePrm.AutoScroll = True
        Me.FlowLayoutPanel_ScalePrm.Location = New System.Drawing.Point(0, 73)
        Me.FlowLayoutPanel_ScalePrm.Name = "FlowLayoutPanel_ScalePrm"
        Me.FlowLayoutPanel_ScalePrm.Size = New System.Drawing.Size(593, 389)
        Me.FlowLayoutPanel_ScalePrm.TabIndex = 0
        '
        'PanelTempSensorPrm
        '
        Me.PanelTempSensorPrm.Controls.Add(Me.Label2)
        Me.PanelTempSensorPrm.Controls.Add(Me.FlowLayoutPanel_TempSensorPrm)
        Me.PanelTempSensorPrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTempSensorPrm.Location = New System.Drawing.Point(0, 0)
        Me.PanelTempSensorPrm.Name = "PanelTempSensorPrm"
        Me.PanelTempSensorPrm.Size = New System.Drawing.Size(593, 462)
        Me.PanelTempSensorPrm.TabIndex = 2
        Me.PanelTempSensorPrm.Tag = "2002"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(570, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Temperature sensor configuration"
        '
        'FlowLayoutPanel_TempSensorPrm
        '
        Me.FlowLayoutPanel_TempSensorPrm.AutoScroll = True
        Me.FlowLayoutPanel_TempSensorPrm.Location = New System.Drawing.Point(0, 73)
        Me.FlowLayoutPanel_TempSensorPrm.Name = "FlowLayoutPanel_TempSensorPrm"
        Me.FlowLayoutPanel_TempSensorPrm.Size = New System.Drawing.Size(593, 389)
        Me.FlowLayoutPanel_TempSensorPrm.TabIndex = 0
        '
        'PanelDatabasePrm
        '
        Me.PanelDatabasePrm.Controls.Add(Me.FlowLayoutPanel_DatabasePrm)
        Me.PanelDatabasePrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDatabasePrm.Location = New System.Drawing.Point(0, 0)
        Me.PanelDatabasePrm.Name = "PanelDatabasePrm"
        Me.PanelDatabasePrm.Size = New System.Drawing.Size(593, 462)
        Me.PanelDatabasePrm.TabIndex = 3
        Me.PanelDatabasePrm.Tag = "3"
        '
        'FlowLayoutPanel_DatabasePrm
        '
        Me.FlowLayoutPanel_DatabasePrm.AutoScroll = True
        Me.FlowLayoutPanel_DatabasePrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel_DatabasePrm.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel_DatabasePrm.Name = "FlowLayoutPanel_DatabasePrm"
        Me.FlowLayoutPanel_DatabasePrm.Size = New System.Drawing.Size(593, 462)
        Me.FlowLayoutPanel_DatabasePrm.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Image = Global.ExampleSettings.My.Resources.Resources.button_cancel
        Me.BtnCancel.Location = New System.Drawing.Point(692, 509)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 40)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Image = Global.ExampleSettings.My.Resources.Resources.button_ok
        Me.BtnOK.Location = New System.Drawing.Point(606, 509)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(80, 40)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Z80_Navigation1
        '
        Me.Z80_Navigation1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Z80_Navigation1.Location = New System.Drawing.Point(0, 0)
        Me.Z80_Navigation1.Name = "Z80_Navigation1"
        Me.Z80_Navigation1.Size = New System.Drawing.Size(190, 562)
        Me.Z80_Navigation1.TabIndex = 0
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Z80_Navigation1)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingsForm"
        Me.Panel1.ResumeLayout(False)
        Me.PanelApplicationTypePrm.ResumeLayout(False)
        Me.PanelScalePrm.ResumeLayout(False)
        Me.PanelScalePrm.PerformLayout()
        Me.PanelTempSensorPrm.ResumeLayout(False)
        Me.PanelTempSensorPrm.PerformLayout()
        Me.PanelDatabasePrm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Z80_Navigation1 As Z80_Navigation
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelApplicationTypePrm As Panel
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents PanelScalePrm As Panel
    Friend WithEvents PanelDatabasePrm As Panel
    Friend WithEvents PanelTempSensorPrm As Panel
    Friend WithEvents FlowLayoutPanel_DatabasePrm As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel_TempSensorPrm As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel_ScalePrm As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel_AppTypePrm As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
