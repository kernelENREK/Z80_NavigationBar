<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDemo2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Z80_Navigation1 = New Demo.Z80_Navigation()
        Me.BtnSelect1004 = New System.Windows.Forms.Button()
        Me.BtnSwitchTheme = New System.Windows.Forms.Button()
        Me.ChkBoxHide2 = New System.Windows.Forms.CheckBox()
        Me.ChkBoxDisable1 = New System.Windows.Forms.CheckBox()
        Me.ChkBoxHideStore = New System.Windows.Forms.CheckBox()
        Me.ChkBoxDisableStore = New System.Windows.Forms.CheckBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSelect1004)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSwitchTheme)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkBoxHide2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkBoxDisable1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkBoxHideStore)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkBoxDisableStore)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnAdd)
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
        'BtnSelect1004
        '
        Me.BtnSelect1004.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelect1004.Location = New System.Drawing.Point(99, 310)
        Me.BtnSelect1004.Name = "BtnSelect1004"
        Me.BtnSelect1004.Size = New System.Drawing.Size(181, 35)
        Me.BtnSelect1004.TabIndex = 38
        Me.BtnSelect1004.Text = "Select Desktop >> My blogs"
        Me.BtnSelect1004.UseVisualStyleBackColor = True
        '
        'BtnSwitchTheme
        '
        Me.BtnSwitchTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwitchTheme.Location = New System.Drawing.Point(286, 310)
        Me.BtnSwitchTheme.Name = "BtnSwitchTheme"
        Me.BtnSwitchTheme.Size = New System.Drawing.Size(75, 35)
        Me.BtnSwitchTheme.TabIndex = 37
        Me.BtnSwitchTheme.Text = "Switch theme"
        Me.BtnSwitchTheme.UseVisualStyleBackColor = True
        '
        'ChkBoxHide2
        '
        Me.ChkBoxHide2.AutoSize = True
        Me.ChkBoxHide2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxHide2.Location = New System.Drawing.Point(18, 245)
        Me.ChkBoxHide2.Name = "ChkBoxHide2"
        Me.ChkBoxHide2.Size = New System.Drawing.Size(202, 21)
        Me.ChkBoxHide2.TabIndex = 36
        Me.ChkBoxHide2.Text = "Hide Desktop >> NewItem #2"
        Me.ChkBoxHide2.UseVisualStyleBackColor = True
        '
        'ChkBoxDisable1
        '
        Me.ChkBoxDisable1.AutoSize = True
        Me.ChkBoxDisable1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxDisable1.Location = New System.Drawing.Point(18, 171)
        Me.ChkBoxDisable1.Name = "ChkBoxDisable1"
        Me.ChkBoxDisable1.Size = New System.Drawing.Size(218, 21)
        Me.ChkBoxDisable1.TabIndex = 35
        Me.ChkBoxDisable1.Text = "Disable Desktop >> NewItem #1"
        Me.ChkBoxDisable1.UseVisualStyleBackColor = True
        '
        'ChkBoxHideStore
        '
        Me.ChkBoxHideStore.AutoSize = True
        Me.ChkBoxHideStore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxHideStore.Location = New System.Drawing.Point(18, 272)
        Me.ChkBoxHideStore.Name = "ChkBoxHideStore"
        Me.ChkBoxHideStore.Size = New System.Drawing.Size(89, 21)
        Me.ChkBoxHideStore.TabIndex = 34
        Me.ChkBoxHideStore.Text = "Hide Store"
        Me.ChkBoxHideStore.UseVisualStyleBackColor = True
        '
        'ChkBoxDisableStore
        '
        Me.ChkBoxDisableStore.AutoSize = True
        Me.ChkBoxDisableStore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxDisableStore.Location = New System.Drawing.Point(18, 198)
        Me.ChkBoxDisableStore.Name = "ChkBoxDisableStore"
        Me.ChkBoxDisableStore.Size = New System.Drawing.Size(105, 21)
        Me.ChkBoxDisableStore.TabIndex = 33
        Me.ChkBoxDisableStore.Text = "Disable Store"
        Me.ChkBoxDisableStore.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(18, 119)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(297, 35)
        Me.BtnAdd.TabIndex = 26
        Me.BtnAdd.Text = "Add new Item: Desktop >> NewItem #1"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnUnselect
        '
        Me.BtnUnselect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnselect.Location = New System.Drawing.Point(18, 310)
        Me.BtnUnselect.Name = "BtnUnselect"
        Me.BtnUnselect.Size = New System.Drawing.Size(75, 35)
        Me.BtnUnselect.TabIndex = 24
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
        Me.Label1.Text = "Demo #2"
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
        'FrmDemo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmDemo2"
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
    Friend WithEvents BtnUnselect As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents ChkBoxHide2 As CheckBox
    Friend WithEvents ChkBoxDisable1 As CheckBox
    Friend WithEvents ChkBoxHideStore As CheckBox
    Friend WithEvents ChkBoxDisableStore As CheckBox
    Friend WithEvents BtnSwitchTheme As Button
    Friend WithEvents BtnSelect1004 As Button
End Class
