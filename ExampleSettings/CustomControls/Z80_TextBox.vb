''' <summary>
''' Zilog80 Custom TextBox control
''' VB.NET version
''' rev. 1.0.0.0 (05/29/2016)
''' </summary>
Public Class Z80_TextBox
    Inherits TextBox

#Region "Custom Properties you can change in runtime or Visual Studio Properties Window"

    Private _Z80_BackColorChangeWhenEmptyText As Boolean = False
    <ComponentModel.Description("If you set this property to true, the the textbox backcolor changes to Z80_BackColorEmptyText color when control Text property is String.Empty or null/nothing")>
    Public Property Z80_BackColorChangeWhenEmptyText() As Boolean
        Get
            Return _Z80_BackColorChangeWhenEmptyText
        End Get
        Set(value As Boolean)
            _Z80_BackColorChangeWhenEmptyText = value
        End Set
    End Property

    Private _Z80_BackColorEmptyText As Color = Color.FromArgb(255, 192, 192)
    <ComponentModel.Description("BackColor control to use when control Text property is String.Empty or null/nothing")>
    Public Property Z80_BackColorEmptyText() As Color
        Get
            Return _Z80_BackColorEmptyText
        End Get
        Set(value As Color)
            _Z80_BackColorEmptyText = value
        End Set
    End Property

    Private _Z80_ForeColorEmptyText As Color = Color.Gray
    <ComponentModel.Description("ForeColor for Z80_Text Property")>
    Public Property Z80_ForeColorEmptyText() As Color
        Get
            Return _Z80_ForeColorEmptyText
        End Get
        Set(value As Color)
            _Z80_ForeColorEmptyText = value
            Invalidate()
        End Set
    End Property

    Private _Z80_Text As String = "<No description>"
    <ComponentModel.Description("Text you can display in the control when Text Property is String.Empty or null/nothing. The Z80_Text property is like a 'watermark'")>
    Public Property Z80_Text() As String
        Get
            Return _Z80_Text
        End Get
        Set(value As String)
            _Z80_Text = value
            Invalidate()
        End Set
    End Property

    Private _Z80_OnlyNumbers As Boolean
    <ComponentModel.Description("The text control accepts only numbers for the text entry")>
    Public Property Z80_OnlyNumbers() As Boolean
        Get
            Return _Z80_OnlyNumbers
        End Get
        Set(value As Boolean)
            _Z80_OnlyNumbers = value
            'by default when textbox accepts only numbers set MaxLengh propery to 8
            If (value) Then
                Me.MaxLength = 8
            End If
        End Set
    End Property

    Private _Z80_DecimalNumbers As Integer = 0
    <ComponentModel.Description("This property has only effect if Z80_OnlyNumbers property is set to true. This property represent how many decimals can you enter in the textbox. 0 value = not decimals allowed")>
    Public Property Z80_DecimalNumbers() As Integer
        Get
            Return _Z80_DecimalNumbers
        End Get
        Set(value As Integer)
            _Z80_DecimalNumbers = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        ' Add event handlers
        AddHandler(TextChanged), AddressOf Me.OnZ80TextBox_WaterMark_Toggle
        AddHandler(LostFocus), AddressOf Me.OnZ80TextBox_WaterMark_Toggle
        AddHandler(FontChanged), AddressOf Me.OnZ80TextBox_FontChanged

    End Sub

#End Region

#Region "WaterMark Events Implementation"

    Private oldFont As Font = Nothing
    Private oldBackColor As Color

    Private Sub OnZ80TextBox_FontChanged(sender As Object, args As EventArgs)
        If (String.IsNullOrEmpty(Me.Text)) Then
            'Saves the font used for Text Property to restore when TextBox isn't empty
            oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
            Refresh()
        End If
    End Sub

    Private Sub OnZ80TextBox_WaterMark_Toggle(sender As Object, args As EventArgs)
        If (String.IsNullOrEmpty(Me.Text)) Then
            EnableWaterMark()
        Else
            DisbaleWaterMark()
        End If
    End Sub

    Private Sub EnableWaterMark()
        'Saves the font and backcolor used for Text Property to restore when TextBox isn't empty
        oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        oldBackColor = Me.BackColor

        Me.SetStyle(ControlStyles.UserPaint, True)

        Refresh()
    End Sub

    Private Sub DisbaleWaterMark()
        Me.SetStyle(ControlStyles.UserPaint, False)

        ' Restore original font for non empty text control
        If oldFont IsNot Nothing Then
            Me.Font = New Font(oldFont.FontFamily, oldFont.Size, oldFont.Style, oldFont.Unit)
        End If

        ' Testing: ///////////////////////////////
        'Me.BackColor = Me.oldBackColor
        ' ////////////////////////////////////////
    End Sub

#End Region

#Region "TextBox Overrides Methods"

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        OnZ80TextBox_WaterMark_Toggle(Nothing, Nothing)
    End Sub


    ' This overrides:
    ' 1) Draw Custom BackColor when Text property is empty is String.Empty Or null/Nothing
    ' 2) Draw Z80_Text (watermark text) when Text property is String.Empty or null/nothing
    Protected Overrides Sub OnPaint(args As PaintEventArgs)
        Dim drawFont As New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        Dim drawBrush As New SolidBrush(_Z80_ForeColorEmptyText)

        If (_Z80_BackColorChangeWhenEmptyText) Then
            Dim backBrush As New SolidBrush(_Z80_BackColorEmptyText)
            args.Graphics.FillRectangle(backBrush, 0, 0, Me.Width, Me.Height)
        End If

        args.Graphics.DrawString((If(String.IsNullOrEmpty(Me.Text), _Z80_Text, Text)), drawFont, drawBrush, New PointF(0.0F, 0.0F))

        MyBase.OnPaint(args)
    End Sub


    ' This overrides:
    ' 1) Only numbers are allowed
    ' 2) Only number with decimals are allowed
    ' 3) When key Enter is pressed automatically put focus on next control
    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        If ((Z80_OnlyNumbers) AndAlso (Z80_DecimalNumbers) = 0) Then
            If (Not System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\d+") AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back))) Then
                e.Handled = True
            End If
        ElseIf ((Z80_OnlyNumbers) AndAlso (Z80_DecimalNumbers <> 0)) Then
            If (Not System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\d+") AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) AndAlso (e.KeyChar <> Convert.ToChar(".")) AndAlso (e.KeyChar <> Convert.ToChar(","))) Then
                e.Handled = True
            End If
        End If

        If (e.KeyChar = ChrW(13)) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If

        MyBase.OnKeyPress(e)
    End Sub

    ' This overrides:
    ' How many decimals are allowed to enter in the textbox
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        If ((Z80_OnlyNumbers) AndAlso (Z80_DecimalNumbers <> 0)) Then
            Dim decSymbol As String = New System.Globalization.CultureInfo(Globalization.CultureInfo.CurrentUICulture.Name, False).NumberFormat.CurrencyDecimalSeparator
            Me.Text = Me.Text.Replace(",", decSymbol)
            Me.Text = Me.Text.Replace(".", decSymbol)

            Dim pDecSymbol As Integer = Me.Text.LastIndexOf(decSymbol)
            Dim fDecSymbol As Integer = Me.Text.IndexOf(decSymbol)

            If (pDecSymbol = 0 AndAlso fDecSymbol = 0) Then
                Me.Text = Convert.ToString("0") & decSymbol
            End If

            If (fDecSymbol <> -1 AndAlso pDecSymbol <> -1 AndAlso fDecSymbol <> pDecSymbol) Then
                Dim lastChar As String = Me.Text.Substring(Me.Text.Length - 1)
                If (lastChar = decSymbol) Then
                    Me.Text = Me.Text.Substring(0, Me.Text.Length - 1)
                End If
            End If

            If (pDecSymbol <> -1) Then
                Dim dec As String = Me.Text.Substring(pDecSymbol)
                If (dec.Length > Z80_DecimalNumbers + 1) Then
                    Me.Text = Me.Text.Substring(0, Me.Text.Length - 1)
                End If
            End If
            Me.SelectionStart = Me.Text.Length
        End If

        MyBase.OnTextChanged(e)
    End Sub

#End Region

End Class
