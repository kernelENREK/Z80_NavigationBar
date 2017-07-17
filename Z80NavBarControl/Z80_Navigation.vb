''' <summary>
''' Z80_Navigation user control working as 'navigation control'
'''     ChangeLog:
'''         - Version: 1.0.0.0 / Release 11-08-2016
'''         - Version: 1.0.0.1 / Release 05-17-2017 (Tooltip behaviour)
'''         - Version: 1.0.0.2 / Release 05-18-2017 (AutoVerticalScrollBar propery)
'''         - Version: 1.0.0.3 / Release 05-19-2017 (ShowItemsBorder propery)
'''         - Version: 1.0.0.4 / Release 05-19-2017 (Nuget version and Default event attribute)
'''         - Version: 1.0.0.5 / Release 07-19-2017
'''     
''' MIT license.
''' 
''' Copyright (c) 2016 Zilog80 (https://hackforums.net)
''' 
''' Permission is hereby granted, free of charge, to any person obtaining a copy of this 
''' software and associated documentation files (the "Software"), to deal in the Software 
''' without restriction, including without limitation the rights to use, copy, modify, 
''' merge, publish, distribute, sublicense, and/or sell copies of the Software, and to 
''' permit persons to whom the Software is furnished to do so, subject to the following 
''' conditions:
''' 
''' The above copyright notice and this permission notice shall be included in all copies 
''' or substantial portions of the Software.
'''
''' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
''' INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
''' PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
''' HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
''' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
''' OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
''' </summary>
<ComponentModel.ToolboxItem(True)>
<ComponentModel.DefaultBindingProperty("AutoVerticalScrollBar")>
<ComponentModel.DefaultEvent("SelectedItem")>
<ToolboxBitmap(GetType(Z80_Navigation), "ToolboxZ80Navbar.bmp")>
Public Class Z80_Navigation

#Region "Variables"

    ''' <summary>
    ''' tree-node containing the whole item hierarchy
    ''' Injected in Initialize() method
    ''' </summary>
    Private _navBarItems As List(Of Z80NavBar.NavBarItem)

    ''' <summary>
    ''' Theme used by drawing the control
    ''' Injected in Initialize() method
    ''' </summary>
    Private _theme As Z80NavBar.Themes.ITheme

    ''' <summary>
    ''' Sometimes when click on item the 'real' selected is the 1st available chilc
    ''' </summary>
    Private finalSelectedItem As Z80NavBar.NavBarItem

    ''' <summary>
    ''' Event that triggers when a item was clicked (MyPanel)
    ''' </summary>
    ''' <param name="item"></param>
    Public Event SelectedItem(item As Z80NavBar.NavBarItem)

#End Region

#Region "Constructor"

    Public Sub New()

        InitializeComponent()

        'Reduce blinking
        Me.DoubleBuffered = True

        Me.ShowSelectedGlyph = True

        IconLocation = New Point(8, 8)

        ' With this stuff the Panel1 behaviour works fine when we have too many items 
        ' that don't fit in control height and don't want show the vertical (and horizontal)
        ' scroll bar. We can use mouse wheel for scroll up & down
        ' -----------------------------------------------------------------------------------------
        Panel1.VerticalScroll.Maximum = 0
        Panel1.HorizontalScroll.Maximum = 0
        Panel1.AutoScroll = False
        Panel1.VerticalScroll.Visible = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.AutoScroll = True
        ' -----------------------------------------------------------------------------------------

    End Sub


#End Region

#Region "UC private events: Resize()"

    Private Sub Z80_Navigation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If (_navBarItems IsNot Nothing) Then
            DrawControlItems()
        End If
    End Sub

#End Region

#Region "Public methods"

    ''' <summary>
    ''' Initialize (and draws) the control.
    ''' This method should de called only one time
    ''' </summary>
    ''' <param name="navbar">list of our navigation items</param>
    ''' <param name="theme">theme applied to control</param>
    Public Sub Initialize(navbar As List(Of Z80NavBar.NavBarItem), theme As Z80NavBar.Themes.ITheme)
        _navBarItems = navbar
        _theme = theme
        DrawControlItems()
    End Sub

    ''' <summary>
    ''' Add a new item (always a child) in run-time to navigation control
    ''' </summary>
    ''' <param name="parentID">Parent ID</param>
    ''' <param name="text">Text for this new item</param>
    ''' <param name="itemID">The new item ID. Make sure that new item no longer exist in any other ithem</param>
    ''' <param name="leftChild">Optional value for left text position</param>
    Public Sub AddItem(parentID As Integer, text As String, itemID As Integer, Optional leftChild As Integer = 10)
        For Each nbi In _navBarItems
            If (nbi.ID = parentID) Then
                If (IsNothing(nbi.Childs)) Then
                    nbi.Childs = New List(Of Z80NavBar.NavBarItem)()
                End If
                Dim newItem As Z80NavBar.NavBarItem = New Z80NavBar.NavBarItem() With {.ID = itemID, .ParentID = parentID, .Text = text}

                nbi.Childs.Add(newItem)
            Else
                If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                    AddChild(nbi, parentID, text, itemID, leftChild)
                End If
            End If
        Next

        DrawControlItems()
    End Sub

    ''' <summary>
    ''' Set item as enable or disable in run-time
    ''' </summary>
    ''' <param name="enable">if you set enable to false the item can not be clicked and also display as 'grayed'</param>
    ''' <param name="itemID">item ID we want to enable or disable</param>
    Public Sub ItemChangeEnable(enable As Boolean, itemID As Integer)
        For Each nbi In _navBarItems
            If (nbi.ID = itemID) Then
                nbi.Enabled = enable
            End If

            If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                EnableItemChild(nbi, enable, itemID)
            End If
        Next

        DrawControlItems()
    End Sub

    ''' <summary>
    ''' Set item visibility in run-time
    ''' </summary>
    ''' <param name="visible">visibility value</param>
    ''' <param name="itemID">item ID we want to setup it visibility</param>
    Public Sub ItemChangeVisibility(visible As Boolean, itemID As Integer)
        For Each nbi In _navBarItems

            If (nbi.ID = itemID) Then
                nbi.Visible = visible
            End If

            If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                VisibilityItemChild(nbi, visible, itemID)
            End If
        Next

        DrawControlItems()
    End Sub

    Private _JRIT_item As Z80NavBar.NavBarItem
    ''' <summary>
    ''' Select item in run-time
    ''' </summary>
    ''' <param name="itemID">item ID we want to select</param>
    Public Sub ItemSelect(itemID As Integer)
        For Each nbi In _navBarItems
            nbi.Selected = False
            nbi.Expanded = False
            nbi.Content = False
            If (nbi.ID = itemID) Then
                _JRIT_item = nbi
            End If
            If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                ResetAllSelect(nbi, itemID)
            End If
        Next

        OnItemClick(_JRIT_item)
    End Sub

    ''' <summary>
    ''' This property can be use for change the current theme in Run-Time
    ''' </summary>
    Public Sub SetTheme(theme As Z80NavBar.Themes.ITheme)
        _theme = theme
        DrawControlItems()
    End Sub

    ''' <summary>
    ''' This method unselect all items. Can be used in Run-Time
    ''' </summary>
    Public Sub ItemUnselectAll()
        For Each nbi In _navBarItems
            nbi.Selected = False
            nbi.Expanded = False
            nbi.Content = False
            If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                ResetAll(nbi)
            End If
        Next
        DrawControlItems()
    End Sub

#End Region

#Region "Private methods"

#Region "Draw items"

    ''' <summary>
    ''' Auxiliary variable for right Y Location value for each item when we draw all items
    ''' </summary>
    Private _item_yLocation As Integer = 0

    Private _childDepth As Integer = 0

    ''' <summary>
    ''' Auxiliary variable for sum all items heights. Usefull for displaying VerticalScrollBar
    ''' </summary>
    Private _itemsTotalHeight As Integer

    Private offsetVerticalScrollBar As Integer = 0

#Region "AutoVerticalScrollBar"

    Private Sub Panel1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Panel1.MouseWheel
        If (Me.AutoVerticalScrollBar) Then
            'Debug.Print($"Panel1_MouseWheel:{Now} Panel1.VertialScroll.Value:{Panel1.VerticalScroll.Value}   Delta:{e.Delta} Y:{e.Y}")
            Try
                VScrollBar1.Value = Panel1.VerticalScroll.Value
            Catch ex As Exception
                Debug.Print($"EX:Panel1_MouseWheel{Now} Panel1.VerticalScroll.Value:{Panel1.VerticalScroll.Value}, VScrollBar1.Maximum: {VScrollBar1.Maximum}")
            End Try
        End If
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Debug.Print($"VScrollBar1_Scroll:{Now} Value:{e.NewValue}")
        Try
            Panel1.AutoScrollPosition = New Point(0, VScrollBar1.Value)
        Catch ex As Exception
            Debug.Print($"EX:VScrollBar1_Scroll:{Now}")
        End Try
    End Sub

    Private Sub PreDrawChilds(item As Z80NavBar.NavBarItem)
        If (item.Expanded And item.Visible) Then
            For Each c In item.Childs
                If (c.Visible) Then
                    _itemsTotalHeight += c.Height
                    If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                        PreDrawChilds(c)
                    End If
                End If
            Next
        End If
    End Sub

    Private Function VerticalScrollVisible(panelHeight As Integer) As Boolean
        _itemsTotalHeight = 0

        For Each item In _navBarItems
            If (item.Visible) Then
                _itemsTotalHeight += item.Height
                If (item.Childs IsNot Nothing AndAlso item.Childs.Count > 0) Then
                    PreDrawChilds(item)
                End If
            End If
        Next
        Return (_itemsTotalHeight > panelHeight)
    End Function

#End Region

    ''' <summary>
    ''' Draw child items (Recursive)
    ''' </summary>
    ''' <param name="item"></param>
    Private Sub DrawChilds(item As Z80NavBar.NavBarItem)
        If (item.Expanded And item.Visible) Then
            For Each c In item.Childs
                If (c.Visible) Then
                    Dim mPanel As New NavBarItemPanel
                    mPanel.Location = New Point(0, _item_yLocation)
                    mPanel.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                    _item_yLocation += c.Height
                    mPanel.Initialize(c, Me.Width, _theme, _childDepth, Me.ShowItemsBorder, Me.ShowSelectedGlyph, Me.IconLocation)

                    AddHandler mPanel.ItemClick, AddressOf OnItemClick
                    Panel1.Controls.Add(mPanel)

                    If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                        _childDepth += 1
                        DrawChilds(c)
                        _childDepth -= 1
                    End If
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' 'MAIN' method that draws all the items
    ''' </summary>
    Private Sub DrawControlItems()

        Dim bar = VerticalScrollVisible(Me.Height)
        VScrollBar1.Visible = bar AndAlso Me.AutoVerticalScrollBar

        If (VScrollBar1.Visible) Then
            VScrollBar1.Maximum = _itemsTotalHeight
            VScrollBar1.LargeChange = Me.Height
        End If

        Me.BackColor = _theme.BackgroundColor(0)
        Panel1.Controls.Clear()
        Panel1.BackColor = _theme.BackgroundColor(0)

        For Each item In _navBarItems
            _childDepth = 0

            If (item.Visible) Then
                Dim mPanel As New NavBarItemPanel
                mPanel.Location = New Point(0, _item_yLocation)
                mPanel.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                _item_yLocation += item.Height
                mPanel.Initialize(item, Me.Width, _theme, _childDepth, Me.ShowItemsBorder, Me.ShowSelectedGlyph, Me.IconLocation)

                AddHandler mPanel.ItemClick, AddressOf OnItemClick
                Panel1.Controls.Add(mPanel)

                If (item.Childs IsNot Nothing AndAlso item.Childs.Count > 0) Then
                    _childDepth += 1
                    DrawChilds(item)
                End If
            End If
        Next

        _item_yLocation = 0

#If NETFX2_0 Then
        For Each control As Control In Panel1.Controls
            If (TypeOf control Is NavBarItemPanel) Then
                Dim p As NavBarItemPanel = DirectCast(control, NavBarItemPanel)
                If (finalSelectedItem IsNot Nothing) Then
                    If (p._navItem.ID = finalSelectedItem.ID) Then
                        If (p.Location.Y > (Me.Height / 2) + (Me.Height / 4)) Then
                            Panel1.AutoScrollPosition = New Point(0, p.Location.Y)
                            If (VScrollBar1.Visible) Then
                                VScrollBar1.Value = p.Location.Y
                            End If
                        Else
                            If (VScrollBar1.Visible) Then VScrollBar1.Value = 0
                        End If
                    End If
                End If
            End If
        Next
#Else
        For Each p In Panel1.Controls.OfType(Of NavBarItemPanel)
            If (finalSelectedItem IsNot Nothing) Then
                If (p._navItem.ID = finalSelectedItem.ID) Then
                    If (p.Location.Y > (Me.Height / 2) + (Me.Height / 4)) Then
                        Panel1.AutoScrollPosition = New Point(0, p.Location.Y)
                        If (VScrollBar1.Visible) Then
                            VScrollBar1.Value = p.Location.Y
                        End If
                    Else
                        If (VScrollBar1.Visible) Then VScrollBar1.Value = 0
                    End If
                End If
            End If
        Next
#End If

        ' YES, you are right, this 2 lines are a completely shit:
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

#End Region

#Region "OnItemClick Event"

    Private _parentID_List As List(Of Integer)
    Private _parentID_index As Integer = 0
    Private _bChildFound As Boolean = False

#Region "Reset all Childs"

    Private Sub ResetAll(item As Z80NavBar.NavBarItem)
        For Each c In item.Childs
            c.Selected = False
            c.Expanded = False
            c.Content = False

            If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                ResetAll(c)
            End If
        Next
    End Sub

    Private Sub ResetAllSelect(item As Z80NavBar.NavBarItem, itemID As Integer)
        For Each c In item.Childs
            c.Selected = False
            c.Expanded = False
            c.Content = False

            If (c.ID = itemID) Then
                _JRIT_item = c
            End If

            If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                ResetAllSelect(c, itemID)
            End If
        Next
    End Sub


#End Region

#Region "Get all parents of the clicked item and autoexpand node"

    Private Sub GetAllParentsChild(clickedItem As Z80NavBar.NavBarItem, item As Z80NavBar.NavBarItem, parentID As Integer?)
        For Each c In item.Childs
            If (c.ID = clickedItem.ID) Then
                If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                    _parentID_List.Add(c.ID)
                ElseIf (parentID IsNot Nothing) Then
                    _parentID_List.Add(parentID)
                End If
                _bChildFound = True
                Exit Sub
            End If

            If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                GetAllParentsChild(clickedItem, c, c.ID)
                If (_bChildFound) Then
                    _parentID_List.Add(c.ID)
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub GetAllParents(clickedItem As Z80NavBar.NavBarItem)
        For Each nbi In _navBarItems
            _parentID_List = New List(Of Integer)()
            If (nbi.ID = clickedItem.ID) Then
                _bChildFound = True
                _parentID_List.Add(nbi.ID)
                Exit For
            Else
                If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                    GetAllParentsChild(clickedItem, nbi, nbi.ParentID)
                    If (_bChildFound) Then
                        _parentID_List.Add(nbi.ID)
                        Exit For
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub GetFirsAvailable(clickedItem As Z80NavBar.NavBarItem)
        If (clickedItem.Childs(0).Childs IsNot Nothing AndAlso clickedItem.Childs.Count > 0) Then
            _parentID_List.Add(clickedItem.Childs(0).ID)
            GetFirsAvailable(clickedItem.Childs(0))
        End If
    End Sub

    Private Sub AutoExpand(clickedItem As Z80NavBar.NavBarItem, item As Z80NavBar.NavBarItem)
        For Each nbi In item.Childs
            If (_parentID_index = _parentID_List.Count) Then
                Exit For
            End If
            If (nbi.ID = _parentID_List(_parentID_index)) Then
                _parentID_index += 1
                nbi.Selected = True
                nbi.Expanded = True
                If (_parentID_index < _parentID_List.Count) Then
                    AutoExpand(clickedItem, nbi)
                Else
                    If (nbi.ParentID = clickedItem.ParentID Or IsNothing(clickedItem.ParentID)) Then
                        nbi.Content = True
                        nbi.Childs(0).Selected = True
                        finalSelectedItem = nbi.Childs(0)
                        RaiseEvent SelectedItem(nbi.Childs(0))
                    Else
                        Dim selected As Boolean = False
                        For Each nbic In nbi.Childs
                            If (nbic.ID = clickedItem.ID) Then
                                nbi.Content = True
                                nbic.Selected = True
                                nbi.Expanded = True
                                finalSelectedItem = clickedItem
                                selected = True
                                RaiseEvent SelectedItem(clickedItem)
                                Exit For
                            End If
                        Next

                        If (Not selected) Then
                            nbi.Content = True
                            nbi.Childs(0).Selected = True
                            finalSelectedItem = nbi.Childs(0)
                            RaiseEvent SelectedItem(nbi.Childs(0))
                        End If

                    End If
                    Exit For
                End If
            End If
        Next
    End Sub

#End Region

    ''' <summary>
    ''' This item is fired when we click on a NavBarItemPanel UserControl
    ''' </summary>
    ''' <param name="item"></param>
    Private Sub OnItemClick(item As Z80NavBar.NavBarItem)

        ' By default we 'reset' all items as:
        ' Not selected
        ' Not expanded
        ' Not Content
        ' -----------------------------------------------------------------------------------------
        For Each nbi In _navBarItems
            nbi.Selected = False
            nbi.Expanded = False
            nbi.Content = False
            If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                ResetAll(nbi)
            End If
        Next
        ' -----------------------------------------------------------------------------------------

        _parentID_List = New List(Of Integer)()
        GetAllParents(item)

#If NETFX2_0 Then
        Dim tmp As New List(Of Integer)
        For Each id As Integer In _parentID_List
            Dim bInserted As Boolean = False
            For k As Integer = 0 To tmp.Count - 1
                If (tmp(k) = id) Then
                    bInserted = True
                    Exit For
                End If
            Next
            If (Not bInserted) Then tmp.Add(id)
        Next

        _parentID_List = New List(Of Integer)()
        For Each tmpId As Integer In tmp
            _parentID_List.Add(tmpId)
        Next
#Else
        _parentID_List = _parentID_List.Distinct().ToList()
#End If
        _parentID_List.Reverse()

        _bChildFound = False

        ' Get the 1st available item :
        If (item.Childs IsNot Nothing AndAlso item.Childs.Count > 0) Then
            GetFirsAvailable(item)
        End If

        _parentID_index = 0

        For Each nbi In _navBarItems
            If (nbi.ID = _parentID_List(0)) Then
                _parentID_index += 1
                nbi.Selected = True
                nbi.Expanded = True
                If (_parentID_List.Count = 1) Then
                    nbi.Content = True

                    If (item.ParentID IsNot Nothing) Then
                        Dim p = _navBarItems.Find(Function(c) c.ID = item.ParentID)
                        p.Selected = True
                        p.Expanded = True

                        item.Selected = True
                        finalSelectedItem = item
                        RaiseEvent SelectedItem(item)
                        Exit For
                    Else ' autoexpand first child or root
                        If (nbi.Childs IsNot Nothing AndAlso nbi.Childs.Count > 0) Then
                            nbi.Childs(0).Selected = True
                            finalSelectedItem = nbi.Childs(0)
                            RaiseEvent SelectedItem(nbi.Childs(0))
                        Else
                            finalSelectedItem = item
                            RaiseEvent SelectedItem(item)
                        End If
                    End If
                Else
                    AutoExpand(item, nbi)
                End If
            End If
        Next

        _parentID_index = 0

        DrawControlItems()

    End Sub

#End Region

#Region "Add item (childs) (Recursive)"

    Private Sub AddChild(item As Z80NavBar.NavBarItem, parentID As Integer, text As String, itemID As Integer, Optional leftChild As Integer = 10)
        For Each c In item.Childs
            If (c.ID = parentID) Then
                If (IsNothing(c.Childs)) Then
                    c.Childs = New List(Of Z80NavBar.NavBarItem)()
                End If
                Dim newItem As Z80NavBar.NavBarItem = New Z80NavBar.NavBarItem() With {.ID = itemID, .ParentID = parentID, .Text = text, .LeftChild = leftChild}

                c.Childs.Add(newItem)
            End If

            If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                AddChild(c, parentID, text, itemID, leftChild)
            End If
        Next
    End Sub

#End Region

#Region "Item enable or disable (childs) (Recursive)"

    Private Sub EnableItemChild(item As Z80NavBar.NavBarItem, enable As Boolean, itemID As Integer)
        For Each c In item.Childs
            If (c.ID = itemID) Then
                c.Enabled = enable
            End If

            If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                EnableItemChild(c, enable, itemID)
            End If
        Next
    End Sub

#End Region

#Region "Item visibility (childs) (Recursive)"

    Private Sub VisibilityItemChild(item As Z80NavBar.NavBarItem, visible As Boolean, itemID As Integer)
        For Each c In item.Childs
            If (c.ID = itemID) Then
                c.Visible = visible
            End If

            If (c.Childs IsNot Nothing AndAlso c.Childs.Count > 0) Then
                VisibilityItemChild(c, visible, itemID)
            End If
        Next
    End Sub

#End Region

#End Region

#Region "Custom properties"

    Private _autoVerticalScrollBar As Boolean

    ''' <summary>
    ''' If the sum of navigation items heights is greater than navigation control height it shows a vertical scroll bar
    ''' </summary>
    ''' <returns></returns>
    <ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    <ComponentModel.Category("Appearance")>
    <ComponentModel.Description("If the sum of navigation items heights is greater than navigation control height it shows a vertical scroll bar")>
    Public Property AutoVerticalScrollBar As Boolean
        Get
            Return _autoVerticalScrollBar
        End Get
        Set(value As Boolean)
            _autoVerticalScrollBar = value
            If (value) Then
                Panel1.AutoScroll = False
                Panel1.VerticalScroll.Maximum = Me.Height
                Panel1.AutoScroll = True
            Else
                Panel1.AutoScroll = False
                Panel1.VerticalScroll.Maximum = 0
                Panel1.HorizontalScroll.Maximum = 0
                Panel1.VerticalScroll.Visible = False
                Panel1.HorizontalScroll.Visible = False
                Panel1.AutoScroll = True
            End If
        End Set
    End Property

    ''' <summary>
    ''' Show border for each navigation items
    ''' </summary>
    ''' <returns></returns>
    <ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    <ComponentModel.Category("Appearance")>
    <ComponentModel.Description("Show border for each navigation items")>
    Public Property ShowItemsBorder As Boolean

    ''' <summary>
    ''' Show glyph for selected item. Introduced in 1.0.0.5
    ''' </summary>
    ''' <returns></returns>
    <ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    <ComponentModel.Category("Appearance")>
    <ComponentModel.Description("Show < glyph for a selected item")>
    Public Property ShowSelectedGlyph As Boolean

    ''' <summary>
    ''' Default icon location. Introduced in 1.0.0.5
    ''' </summary>
    ''' <returns></returns>
    <ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    <ComponentModel.Category("Appearance")>
    <ComponentModel.Description("Default icon location")>
    Public Property IconLocation As Point

#End Region

#Region "### CUSTOM Panel ###"

    ''' <summary>
    ''' Each item is 'draw' in this custom control (Panel)
    ''' This custom control is what we 'see' on screen
    ''' </summary>
    Private Class NavBarItemPanel
        Inherits Panel

#Region "Variables"

        ''' <summary>
        ''' Flag to check if Initialize method has been called
        ''' </summary>
        Private _initialized As Boolean = False

        ''' <summary>
        ''' Flag to check Hover efect
        ''' </summary>
        Private _hover As Boolean = False

        ''' <summary>
        ''' Item theme injected in Initialize() method
        ''' </summary>
        Private _theme As Z80NavBar.Themes.ITheme

        ''' <summary>
        ''' Item depth injected in Initialize() method
        ''' </summary>
        Private _depth As Integer

        ''' <summary>
        ''' Item we are drawing
        ''' </summary>
        Public _navItem As Z80NavBar.NavBarItem

        ''' <summary>
        ''' Event we trigger when click on the panel control.
        ''' </summary>
        ''' <param name="item"></param>
        Public Event ItemClick(ByVal item As Z80NavBar.NavBarItem)

        ''' <summary>
        ''' Tooltip control
        ''' </summary>
        Private _tooltip As ToolTip

        ''' <summary>
        ''' New property introduced in 1.0.0.3
        ''' </summary>
        Private _showItemBorder As Boolean

        ''' <summary>
        ''' New property introduced in 1.0.0.5
        ''' </summary>
        Private _showSelectedGlyph As Boolean

        ''' <summary>
        ''' New property introduced in 1.0.0.5
        ''' </summary>
        Private _iconLocation As Point

#End Region

#Region "Initialization"

        Public Sub Initialize(navItem As Z80NavBar.NavBarItem, width As Integer, theme As Z80NavBar.Themes.ITheme, depth As Integer, showItemBorder As Boolean, showGlyph As Boolean, iconLocation As Point)
            _navItem = navItem
            _theme = theme
            _depth = depth
            _showItemBorder = showItemBorder
            _showSelectedGlyph = showGlyph
            _iconLocation = iconLocation

            Me.Height = navItem.Height
            Me.Width = width
            Me.BackColor = theme.BackgroundColor(depth)

            Me._tooltip = New ToolTip()

            'Reduce blinking
            Me.DoubleBuffered = True

            _initialized = True
        End Sub

#End Region

#Region "Paint. Voodoo goes here"

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            If (_initialized) Then
                Dim yPos As Single = Me.Height / 2 - (_theme.FontItem(_depth).Height / 2)
                Dim xPos As Single = 34

                If (_navItem.ParentID IsNot Nothing) Then
                    xPos = _navItem.LeftChild
                End If

                If (_navItem.Enabled) Then
                    If (_hover) Then
                        If (_navItem.Icon IsNot Nothing) Then
                            e.Graphics.DrawImage(_navItem.Icon.Hover, Me._iconLocation)
                        End If
                        e.Graphics.DrawString(_navItem.Text, _theme.FontItem(_depth), _theme.BrushFontHover(_depth), New PointF(xPos, yPos))
                        'hover backcolor only in root nodes and items with 'childs'
                        If (IsNothing(_navItem.ParentID) OrElse (_navItem.Childs IsNot Nothing AndAlso _navItem.Childs.Count > 0)) Then
                            Me.BackColor = _theme.HoverBackgroundColor(_depth)
                            ' v glyph only in childs (not root nodes)
                            If (_navItem.ParentID IsNot Nothing AndAlso _navItem.Childs IsNot Nothing) Then
                                Dim p1 As New Point(Me.Width - 4, Me.Height / 2)
                                Dim p2 As New Point(Me.Width - 12, Me.Height / 2)
                                Dim p3 As New Point(Me.Width - 8, ((Me.Height / 2) + 4))
                                Dim p As Point() = {p1, p2, p3}
                                Dim b As SolidBrush = _theme.BrushFontHover(_depth)
                                e.Graphics.FillPolygon(b, p)
                            End If
                        End If
                        If (_showItemBorder) Then e.Graphics.DrawRectangle(_theme.BorderSolidColor(_depth), 0, 0, Me.Width - 1, Me.Height)
                    Else 'not hover
                        If (Not _navItem.Selected) Then
                            If (_navItem.Icon IsNot Nothing) Then
                                e.Graphics.DrawImage(_navItem.Icon.Default, Me._iconLocation)
                            End If

                            e.Graphics.DrawString(_navItem.Text, _theme.FontItem(_depth), _theme.BrushFontItemNotSelected(_depth), New PointF(xPos, yPos))
                            Me.BackColor = _theme.BackgroundColor(_depth)
                            If (_showItemBorder) Then e.Graphics.DrawRectangle(_theme.BorderSolidColor(_depth), 0, 0, Me.Width - 1, Me.Height)
                            ' v glyph only in childs (not root nodes)
                            If (_navItem.ParentID IsNot Nothing AndAlso _navItem.Childs IsNot Nothing) Then
                                Dim p1 As New Point(Me.Width - 4, Me.Height / 2)
                                Dim p2 As New Point(Me.Width - 12, Me.Height / 2)
                                Dim p3 As New Point(Me.Width - 8, ((Me.Height / 2) + 4))
                                Dim p As Point() = {p1, p2, p3}
                                Dim b As SolidBrush = _theme.BrushFontItemNotSelected(_depth)
                                e.Graphics.FillPolygon(b, p)
                            End If
                        Else 'selected Item
                            If (_navItem.Icon IsNot Nothing) Then
                                e.Graphics.DrawImage(_navItem.Icon.Selected, Me._iconLocation)
                            End If
                            e.Graphics.DrawString(_navItem.Text, _theme.FontItemSelected(_depth), _theme.BrushFontItemSelected(_depth), New PointF(xPos, yPos))
                            If (IsNothing(_navItem.ParentID) OrElse (_navItem.Childs IsNot Nothing AndAlso _navItem.Childs.Count > 0)) Then
                                Me.BackColor = _theme.SelectedBackgroundColor(_depth)
                                If (_showItemBorder) Then e.Graphics.DrawRectangle(_theme.BorderSolidColor(_depth), 0, 0, Me.Width - 1, Me.Height)
                                ' < glyph:
                                If (_navItem.Content AndAlso _showSelectedGlyph) Then
                                    Dim p1 As New Point(Me.Width - 8, Me.Height / 2)
                                    Dim p2 As New Point(Me.Width, ((Me.Height / 2) - 8))
                                    Dim p3 As New Point(Me.Width, ((Me.Height / 2) + 8))
                                    Dim p As Point() = {p1, p2, p3}
                                    Dim b As SolidBrush = New SolidBrush(_navItem.ContentBackColor)
                                    e.Graphics.FillPolygon(b, p)
                                End If
                            Else
                                If (_showItemBorder) Then e.Graphics.DrawRectangle(_theme.BorderSolidColor(_depth), 0, 0, Me.Width - 1, Me.Height)
                            End If
                        End If
                    End If
                Else 'Item disabled
                    Me.Enabled = False

                    'if you want to display icon when item was unselected, uncomment this If sentence:
                    'If (_navItem.Icon IsNot Nothing) Then
                    '    e.Graphics.DrawImage(_navItem.Icon.Selected, New PointF(8, 8))
                    'End If

                    e.Graphics.DrawString(_navItem.Text, _theme.FontItem(_depth), _theme.BrushFontItemDisable, New PointF(xPos, yPos))
                    Me.BackColor = _theme.ItemDisableBackgroudColor
                End If

            End If
            MyBase.OnPaint(e)
        End Sub

#End Region

        Private Sub MyPanel_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
#If NETFX2_0 Or NETFX3_5 Then
            If (Not String.IsNullOrEmpty(_navItem.ToolTip)) Then
                _tooltip.SetToolTip(Me, _navItem.ToolTip)
            End If
#Else
            If (Not String.IsNullOrWhiteSpace(_navItem.ToolTip)) Then
                _tooltip.SetToolTip(Me, _navItem.ToolTip)
            End If
#End If
            If (Not _navItem.Selected) Then
                _hover = True
                Me.Invalidate()
            End If
        End Sub

        Private Sub MyPanel_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            If (Not _navItem.Selected) Then
                _hover = False
                Me.Invalidate()
            End If
        End Sub

        Private Sub MyPanel_Click(sender As Object, e As EventArgs) Handles Me.Click
            If (Not _navItem.Selected) Then
                _hover = False
                _navItem.Selected = True
                Me.Invalidate()
                RaiseEvent ItemClick(_navItem)
            End If
        End Sub

    End Class

#End Region

End Class
