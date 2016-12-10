<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_TempSensor
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMin = New ExampleSettings.Z80_TextBox()
        Me.TxtMax = New ExampleSettings.Z80_TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Minimun range:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Maximun range:"
        '
        'TxtMin
        '
        Me.TxtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMin.Location = New System.Drawing.Point(102, 3)
        Me.TxtMin.MaxLength = 8
        Me.TxtMin.Name = "TxtMin"
        Me.TxtMin.Size = New System.Drawing.Size(58, 20)
        Me.TxtMin.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TxtMin, "ºC value")
        Me.TxtMin.Z80_BackColorChangeWhenEmptyText = True
        Me.TxtMin.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMin.Z80_DecimalNumbers = 0
        Me.TxtMin.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.TxtMin.Z80_OnlyNumbers = True
        Me.TxtMin.Z80_Text = "value"
        '
        'TxtMax
        '
        Me.TxtMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMax.Location = New System.Drawing.Point(102, 29)
        Me.TxtMax.MaxLength = 8
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.Size = New System.Drawing.Size(58, 20)
        Me.TxtMax.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TxtMax, "ºC value")
        Me.TxtMax.Z80_BackColorChangeWhenEmptyText = True
        Me.TxtMax.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMax.Z80_DecimalNumbers = 0
        Me.TxtMax.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.TxtMax.Z80_OnlyNumbers = True
        Me.TxtMax.Z80_Text = "value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ºC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ºC"
        '
        'UC_TempSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMax)
        Me.Controls.Add(Me.TxtMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_TempSensor"
        Me.Size = New System.Drawing.Size(184, 52)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMin As Z80_TextBox
    Friend WithEvents TxtMax As Z80_TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
