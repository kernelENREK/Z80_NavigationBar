<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Scale
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtID = New ExampleSettings.Z80_TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProtocol = New ExampleSettings.Z80_TextBox()
        Me.BtnTestComm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scale:"
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtID.Location = New System.Drawing.Point(74, 3)
        Me.TxtID.MaxLength = 2
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(41, 20)
        Me.TxtID.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtID, "Scale ID. (range 1-99)")
        Me.TxtID.Z80_BackColorChangeWhenEmptyText = True
        Me.TxtID.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtID.Z80_DecimalNumbers = 0
        Me.TxtID.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.TxtID.Z80_OnlyNumbers = True
        Me.TxtID.Z80_Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Protocol:"
        '
        'TxtProtocol
        '
        Me.TxtProtocol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtProtocol.Location = New System.Drawing.Point(74, 29)
        Me.TxtProtocol.Name = "TxtProtocol"
        Me.TxtProtocol.Size = New System.Drawing.Size(235, 20)
        Me.TxtProtocol.TabIndex = 3
        Me.TxtProtocol.Z80_BackColorChangeWhenEmptyText = True
        Me.TxtProtocol.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtProtocol.Z80_DecimalNumbers = 0
        Me.TxtProtocol.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.TxtProtocol.Z80_OnlyNumbers = False
        Me.TxtProtocol.Z80_Text = "Scale protocol"
        '
        'BtnTestComm
        '
        Me.BtnTestComm.Location = New System.Drawing.Point(74, 55)
        Me.BtnTestComm.Name = "BtnTestComm"
        Me.BtnTestComm.Size = New System.Drawing.Size(75, 23)
        Me.BtnTestComm.TabIndex = 4
        Me.BtnTestComm.Text = "Test"
        Me.BtnTestComm.UseVisualStyleBackColor = True
        '
        'UC_Scale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnTestComm)
        Me.Controls.Add(Me.TxtProtocol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_Scale"
        Me.Size = New System.Drawing.Size(314, 82)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtID As Z80_TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtProtocol As Z80_TextBox
    Friend WithEvents BtnTestComm As Button
End Class
