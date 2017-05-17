Namespace Z80NavBar

    ''' <summary>
    ''' Z80_Navigation control Model for each item
    ''' </summary>
    Public Class NavBarItem
        ''' <summary>
        ''' Item ID. All items must have unique ID number
        ''' </summary>
        ''' <returns></returns>
        Public Property ID As Integer
        ''' <summary>
        ''' Text we see for our item
        ''' </summary>
        ''' <returns></returns>
        Public Property Text As String
        ''' <summary>
        ''' Icon for our item. Only Root (depth = 0) icons are displayed
        ''' </summary>
        ''' <returns></returns>
        Public Property Icon As ItemIcon
        ''' <summary>
        ''' Item enability.
        ''' </summary>
        ''' <returns></returns>
        Public Property Enabled As Boolean
        ''' <summary>
        ''' Item visibility
        ''' </summary>
        ''' <returns></returns>
        Public Property Visible As Boolean
        ''' <summary>
        ''' Item is selected
        ''' </summary>
        ''' <returns></returns>
        Public Property Selected As Boolean
        ''' <summary>
        ''' Item is expanded
        ''' </summary>
        ''' <returns></returns>
        Public Property Expanded As Boolean
        ''' <summary>
        ''' Item has really selected. Only one item must have content = true at once
        ''' </summary>
        ''' <returns></returns>
        Public Property Content As Boolean
        ''' <summary>
        ''' Parent ID for this item. It is root item (depth = 0) parent ID will bi nothing
        ''' </summary>
        ''' <returns></returns>
        Public Property ParentID As Integer?
        ''' <summary>
        ''' Child collection for that item
        ''' </summary>
        Public Childs As List(Of NavBarItem)
        ''' <summary>
        ''' Height (Panel) for that item
        ''' </summary>
        ''' <returns></returns>
        Public Property Height As Integer
        ''' <summary>
        ''' Act like a Identation on childs items
        ''' </summary>
        ''' <returns></returns>
        Public Property LeftChild As Integer?
        ''' <summary>
        ''' Color for glyph to match with content container (outside from Navigation control)
        ''' </summary>
        ''' <returns></returns>
        Public Property ContentBackColor As Color
        ''' <summary>
        ''' Item tooltip
        ''' </summary>
        ''' <returns></returns>
        Public Property ToolTip As String

        ''' <summary>
        ''' Default values
        ''' </summary>
        Public Sub New()
            Enabled = True
            Visible = True
            Height = 34
            LeftChild = 10
            ContentBackColor = Color.FromArgb(241, 241, 241)
        End Sub
    End Class

    ''' <summary>
    ''' Item icons. Only for root items  (depth = 0)
    ''' </summary>
    Public Class ItemIcon
        ''' <summary>
        ''' Default icon
        ''' </summary>
        ''' <returns></returns>
        Public Property [Default] As Image
        ''' <summary>
        ''' Icon when hover on item
        ''' </summary>
        ''' <returns></returns>
        Public Property Hover As Image
        ''' <summary>
        ''' Icon when item has been selected
        ''' </summary>
        ''' <returns></returns>
        Public Property Selected As Image
    End Class

End Namespace
