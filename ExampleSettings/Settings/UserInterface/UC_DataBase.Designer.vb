<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DataBase
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelAutentication = New System.Windows.Forms.Panel()
        Me.txtSQLAutenticationPassword = New ExampleSettings.Z80_TextBox()
        Me.txtSQLAutenticationUserID = New ExampleSettings.Z80_TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSQLDataSource = New ExampleSettings.Z80_TextBox()
        Me.txtSQLCatalog = New ExampleSettings.Z80_TextBox()
        Me.cboSQLAutenticationTypes = New System.Windows.Forms.ComboBox()
        Me.btnTestSQLServer = New System.Windows.Forms.Button()
        Me.PanelAutentication.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data source:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Database name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Autentication:"
        '
        'PanelAutentication
        '
        Me.PanelAutentication.Controls.Add(Me.txtSQLAutenticationPassword)
        Me.PanelAutentication.Controls.Add(Me.txtSQLAutenticationUserID)
        Me.PanelAutentication.Controls.Add(Me.Label5)
        Me.PanelAutentication.Controls.Add(Me.Label4)
        Me.PanelAutentication.Location = New System.Drawing.Point(0, 79)
        Me.PanelAutentication.Name = "PanelAutentication"
        Me.PanelAutentication.Size = New System.Drawing.Size(327, 58)
        Me.PanelAutentication.TabIndex = 3
        '
        'txtSQLAutenticationPassword
        '
        Me.txtSQLAutenticationPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSQLAutenticationPassword.Location = New System.Drawing.Point(100, 32)
        Me.txtSQLAutenticationPassword.Name = "txtSQLAutenticationPassword"
        Me.txtSQLAutenticationPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSQLAutenticationPassword.Size = New System.Drawing.Size(221, 20)
        Me.txtSQLAutenticationPassword.TabIndex = 3
        Me.txtSQLAutenticationPassword.Z80_BackColorChangeWhenEmptyText = False
        Me.txtSQLAutenticationPassword.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSQLAutenticationPassword.Z80_DecimalNumbers = 0
        Me.txtSQLAutenticationPassword.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.txtSQLAutenticationPassword.Z80_OnlyNumbers = False
        Me.txtSQLAutenticationPassword.Z80_Text = "<No description>"
        '
        'txtSQLAutenticationUserID
        '
        Me.txtSQLAutenticationUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSQLAutenticationUserID.Location = New System.Drawing.Point(100, 6)
        Me.txtSQLAutenticationUserID.Name = "txtSQLAutenticationUserID"
        Me.txtSQLAutenticationUserID.Size = New System.Drawing.Size(221, 20)
        Me.txtSQLAutenticationUserID.TabIndex = 2
        Me.txtSQLAutenticationUserID.Z80_BackColorChangeWhenEmptyText = True
        Me.txtSQLAutenticationUserID.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSQLAutenticationUserID.Z80_DecimalNumbers = 0
        Me.txtSQLAutenticationUserID.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.txtSQLAutenticationUserID.Z80_OnlyNumbers = False
        Me.txtSQLAutenticationUserID.Z80_Text = "<No description>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User ID:"
        '
        'txtSQLDataSource
        '
        Me.txtSQLDataSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSQLDataSource.Location = New System.Drawing.Point(100, 3)
        Me.txtSQLDataSource.Name = "txtSQLDataSource"
        Me.txtSQLDataSource.Size = New System.Drawing.Size(221, 20)
        Me.txtSQLDataSource.TabIndex = 4
        Me.txtSQLDataSource.Z80_BackColorChangeWhenEmptyText = True
        Me.txtSQLDataSource.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSQLDataSource.Z80_DecimalNumbers = 0
        Me.txtSQLDataSource.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.txtSQLDataSource.Z80_OnlyNumbers = False
        Me.txtSQLDataSource.Z80_Text = "<No description>"
        '
        'txtSQLCatalog
        '
        Me.txtSQLCatalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSQLCatalog.Location = New System.Drawing.Point(100, 26)
        Me.txtSQLCatalog.Name = "txtSQLCatalog"
        Me.txtSQLCatalog.Size = New System.Drawing.Size(221, 20)
        Me.txtSQLCatalog.TabIndex = 5
        Me.txtSQLCatalog.Z80_BackColorChangeWhenEmptyText = True
        Me.txtSQLCatalog.Z80_BackColorEmptyText = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSQLCatalog.Z80_DecimalNumbers = 0
        Me.txtSQLCatalog.Z80_ForeColorEmptyText = System.Drawing.Color.Gray
        Me.txtSQLCatalog.Z80_OnlyNumbers = False
        Me.txtSQLCatalog.Z80_Text = "<No description>"
        '
        'cboSQLAutenticationTypes
        '
        Me.cboSQLAutenticationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSQLAutenticationTypes.FormattingEnabled = True
        Me.cboSQLAutenticationTypes.Location = New System.Drawing.Point(100, 52)
        Me.cboSQLAutenticationTypes.Name = "cboSQLAutenticationTypes"
        Me.cboSQLAutenticationTypes.Size = New System.Drawing.Size(221, 21)
        Me.cboSQLAutenticationTypes.TabIndex = 6
        '
        'btnTestSQLServer
        '
        Me.btnTestSQLServer.Location = New System.Drawing.Point(327, 1)
        Me.btnTestSQLServer.Name = "btnTestSQLServer"
        Me.btnTestSQLServer.Size = New System.Drawing.Size(75, 23)
        Me.btnTestSQLServer.TabIndex = 7
        Me.btnTestSQLServer.Text = "Test"
        Me.btnTestSQLServer.UseVisualStyleBackColor = True
        '
        'UC_DataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTestSQLServer)
        Me.Controls.Add(Me.cboSQLAutenticationTypes)
        Me.Controls.Add(Me.txtSQLCatalog)
        Me.Controls.Add(Me.txtSQLDataSource)
        Me.Controls.Add(Me.PanelAutentication)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_DataBase"
        Me.Size = New System.Drawing.Size(404, 140)
        Me.PanelAutentication.ResumeLayout(False)
        Me.PanelAutentication.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelAutentication As Panel
    Friend WithEvents txtSQLAutenticationPassword As Z80_TextBox
    Friend WithEvents txtSQLAutenticationUserID As Z80_TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSQLDataSource As Z80_TextBox
    Friend WithEvents txtSQLCatalog As Z80_TextBox
    Friend WithEvents cboSQLAutenticationTypes As ComboBox
    Friend WithEvents btnTestSQLServer As Button
End Class
