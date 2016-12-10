Imports ExampleSettings.ParamModels

Public Class UC_DataBase

    Private _validationOK As Boolean
    Public ReadOnly Property ValidationOK As Boolean
        Get
            Return _validationOK
        End Get
    End Property

    Private _param As SQLServerPrm
    Public Property Param As SQLServerPrm
        Get
            Return _param
        End Get
        Set(value As SQLServerPrm)
            _param = value
            If (value.Credentials.Authentication = SQLServerCredentials.AuthenticationType.SQLServer) Then
                cboSQLAutenticationTypes.SelectedIndex = cboSQLAutenticationTypes.FindString("SQL Server")
                txtSQLAutenticationUserID.Text = value.Credentials.UserId
                txtSQLAutenticationPassword.Text = value.Credentials.Password
            Else
                cboSQLAutenticationTypes.SelectedIndex = cboSQLAutenticationTypes.FindString("Windows")
            End If
            txtSQLDataSource.Text = value.DataSource
            txtSQLCatalog.Text = value.Catalog
        End Set
    End Property

    Private Sub OnValidation()
        _validationOK = True

        If (Not String.IsNullOrWhiteSpace(txtSQLDataSource.Text)) Then
            _param.DataSource = txtSQLDataSource.Text.Trim
        Else
            _validationOK = False
        End If

        If (Not String.IsNullOrWhiteSpace(txtSQLCatalog.Text)) Then
            _param.Catalog = txtSQLCatalog.Text.Trim
        Else
            _validationOK = False
        End If

        If (cboSQLAutenticationTypes.Text = "SQL Server") Then
            _param.Credentials.Authentication = SQLServerCredentials.AuthenticationType.SQLServer

            If (Not String.IsNullOrWhiteSpace(txtSQLAutenticationUserID.Text)) Then
                _param.Credentials.UserId = txtSQLAutenticationUserID.Text.Trim
            Else
                _validationOK = False
            End If

            If (Not String.IsNullOrWhiteSpace(txtSQLAutenticationPassword.Text)) Then
                _param.Credentials.Password = txtSQLAutenticationPassword.Text.Trim
                txtSQLAutenticationPassword.BackColor = SystemColors.Window
            Else
                _validationOK = False
                txtSQLAutenticationPassword.BackColor = txtSQLAutenticationPassword.Z80_BackColorEmptyText
            End If
        Else
            _param.Credentials.Authentication = SQLServerCredentials.AuthenticationType.Windows
        End If

        btnTestSQLServer.Enabled = SQLcanTest()
    End Sub

    Private Function SQLcanTest() As Boolean
        If String.IsNullOrEmpty(txtSQLDataSource.Text.Trim()) Then
            Return False
        End If

        If String.IsNullOrEmpty(txtSQLCatalog.Text.Trim()) Then
            Return False
        End If

        If cboSQLAutenticationTypes.Text = "SQL Server" Then
            If String.IsNullOrEmpty(txtSQLAutenticationUserID.Text.Trim()) Then
                Return False
            End If

            If String.IsNullOrEmpty(txtSQLAutenticationPassword.Text.Trim()) Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub cboSQLAutenticationTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSQLAutenticationTypes.SelectedIndexChanged
        If cboSQLAutenticationTypes.Text = "SQL Server" Then
            txtSQLAutenticationUserID.Enabled = True
            txtSQLAutenticationPassword.Enabled = True
            txtSQLAutenticationUserID.Text = String.Format("{0}", _param.Credentials.UserId)
            txtSQLAutenticationPassword.Text = String.Format("{0}", _param.Credentials.Password)
        Else
            txtSQLAutenticationUserID.Enabled = False
            txtSQLAutenticationPassword.Enabled = False
            txtSQLAutenticationUserID.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
            txtSQLAutenticationPassword.Text = String.Empty
            txtSQLAutenticationPassword.BackColor = SystemColors.Window
        End If

        btnTestSQLServer.Enabled = SQLcanTest()
    End Sub

    Private Sub btnTestSQLServer_Click(sender As Object, e As EventArgs) Handles btnTestSQLServer.Click
        'TODO: implement Database connection test

        MessageBox.Show("TODO connection test: Test done", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub New()

        InitializeComponent()

        _param = New SQLServerPrm()

        cboSQLAutenticationTypes.Items.Clear()
        cboSQLAutenticationTypes.Items.Add("SQL Server")
        cboSQLAutenticationTypes.Items.Add("Windows")

        AddHandler txtSQLDataSource.TextChanged, AddressOf OnValidation
        AddHandler txtSQLCatalog.TextChanged, AddressOf OnValidation
        AddHandler txtSQLAutenticationUserID.TextChanged, AddressOf OnValidation
        AddHandler txtSQLAutenticationPassword.TextChanged, AddressOf OnValidation

    End Sub
End Class
