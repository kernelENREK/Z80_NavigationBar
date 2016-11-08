<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemo3
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Z80_Navigation1 = New Demo.Z80_Navigation()
        Me.BtnSwitchTheme = New System.Windows.Forms.Button()
        Me.BtnUnselect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Z80_Navigation1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSwitchTheme)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnUnselect)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblInfo)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 561)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 1
        '
        'Z80_Navigation1
        '
        Me.Z80_Navigation1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Z80_Navigation1.Location = New System.Drawing.Point(0, 0)
        Me.Z80_Navigation1.Name = "Z80_Navigation1"
        Me.Z80_Navigation1.Size = New System.Drawing.Size(160, 561)
        Me.Z80_Navigation1.TabIndex = 0
        '
        'BtnSwitchTheme
        '
        Me.BtnSwitchTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwitchTheme.Location = New System.Drawing.Point(107, 119)
        Me.BtnSwitchTheme.Name = "BtnSwitchTheme"
        Me.BtnSwitchTheme.Size = New System.Drawing.Size(75, 35)
        Me.BtnSwitchTheme.TabIndex = 39
        Me.BtnSwitchTheme.Text = "Switch theme"
        Me.BtnSwitchTheme.UseVisualStyleBackColor = True
        '
        'BtnUnselect
        '
        Me.BtnUnselect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnselect.Location = New System.Drawing.Point(18, 119)
        Me.BtnUnselect.Name = "BtnUnselect"
        Me.BtnUnselect.Size = New System.Drawing.Size(75, 35)
        Me.BtnUnselect.TabIndex = 38
        Me.BtnUnselect.Text = "Unselect all"
        Me.BtnUnselect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Demo #3"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(13, 61)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(146, 25)
        Me.LblInfo.TabIndex = 21
        Me.LblInfo.Text = "Content Sample"
        '
        'FrmDemo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmDemo3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zilog80 NavigationControl Demo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Z80_Navigation1 As Z80_Navigation
    Friend WithEvents Label1 As Label
    Friend WithEvents LblInfo As Label
    Friend WithEvents BtnSwitchTheme As Button
    Friend WithEvents BtnUnselect As Button
End Class
