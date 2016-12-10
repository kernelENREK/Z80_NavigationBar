<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ApplicationBehaviour
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.RbtnUser = New System.Windows.Forms.RadioButton()
        Me.RbtnAdmin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtWCFHost = New ExampleSettings.Z80_TextBox()
        Me.SuspendLayout()
        '
        'RbtnUser
        '
        Me.RbtnUser.AutoSize = True
        Me.RbtnUser.Location = New System.Drawing.Point(3, 3)
        Me.RbtnUser.Name = "RbtnUser"
        Me.RbtnUser.Size = New System.Drawing.Size(47, 17)
        Me.RbtnUser.TabIndex = 0
        Me.RbtnUser.TabStop = True
        Me.RbtnUser.Text = "User"
        Me.RbtnUser.UseVisualStyleBackColor = True
        '
        'RbtnAdmin
        '
        Me.RbtnAdmin.AutoSize = True
        Me.RbtnAdmin.Location = New System.Drawing.Point(3, 26)
        Me.RbtnAdmin.Name = "RbtnAdmin"
        Me.RbtnAdmin.Size = New System.Drawing.Size(124, 17)
        Me.RbtnAdmin.TabIndex = 1
        Me.RbtnAdmin.TabStop = True
        Me.RbtnAdmin.Text = "Admin (no Hardware)"
        Me.RbtnAdmin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Host IP:"
        '
        'TxtWCFHost
        '
        Me.TxtWCFHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtWCFHost.Location = New System.Drawing.Point(74, 43)
        Me.TxtWCFHost.MaxLength = 15
        Me.TxtWCFHost.Name = "TxtWCFHost"
        Me.TxtWCFHost.Size = New System.Drawing.Size(146, 20)
        Me.TxtWCFHost.TabIndex = 3
        Me.TxtWCFHost.Z80_BackColorChangeWhenEmptyText = False
        Me.TxtWCFHost.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtWCFHost.Z80_DecimalNumbers = 0
        Me.TxtWCFHost.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.TxtWCFHost.Z80_OnlyNumbers = False
        Me.TxtWCFHost.Z80_Text = "IP address xxx.xxx.xxx.xxx"
        '
        'UC_ApplicationBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtWCFHost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbtnAdmin)
        Me.Controls.Add(Me.RbtnUser)
        Me.Name = "UC_ApplicationBehaviour"
        Me.Size = New System.Drawing.Size(225, 69)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RbtnUser As RadioButton
    Friend WithEvents RbtnAdmin As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtWCFHost As Z80_TextBox
End Class
