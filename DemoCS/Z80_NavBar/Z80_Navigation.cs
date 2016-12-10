using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Change --- (this NameSpace to your current project NameSpace)
//          |
//          |
//          V
namespace DemoCS.Z80_NavBar
{
    /// <summary>
    /// Z80_Navigation user control working as 'navigation control' (C# Version)
    ///     ChangeLog:
    ///         - Version: 1.0.0.0 / Release 12-09-2016
    ///     
    /// MIT license.
    /// 
    /// Copyright (c) 2016 Zilog80 (https://hackforums.net)
    /// 
    /// Permission is hereby granted, free of charge, to any person obtaining a copy of this 
    /// software and associated documentation files (the "Software"), to deal in the Software 
    /// without restriction, including without limitation the rights to use, copy, modify, 
    /// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to 
    /// permit persons to whom the Software is furnished to do so, subject to the following 
    /// conditions:
    /// 
    /// The above copyright notice and this permission notice shall be included in all copies 
    /// or substantial portions of the Software.
    ///
    /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
    /// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
    /// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
    /// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
    /// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
    /// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
    /// </summary>
    public partial class Z80_Navigation : UserControl
    {

        #region Variables

        /// <summary>
        /// tree-node containing the whole item hierarchy
        /// Injected in Initialize() method
        /// </summary>

        private List<Z80NavBar.NavBarItem> _navBarItems;
        /// <summary>
        /// Theme used by drawing the control
        /// Injected in Initialize() method
        /// </summary>

        private Z80NavBar.Themes.ITheme _theme;
        /// <summary>
        /// Sometimes when click on item the 'real' selected is the 1st available chilc
        /// </summary>

        private Z80NavBar.NavBarItem finalSelectedItem;
        /// <summary>
        /// Event that triggers when a item was clicked (MyPanel)
        /// </summary>
        /// <param name="item"></param>
        public event SelectedItemEventHandler SelectedItem;
        public delegate void SelectedItemEventHandler(Z80NavBar.NavBarItem item);

        #endregion

        #region Constructor

        public Z80_Navigation()
        {
            Resize += Z80_Navigation_Resize;
            InitializeComponent();

            // With this stuff the Panel1 behaviour works fine when we have too many items 
            // that don't fit in control height and don't want show the vertical (and horizontal)
            // scroll bar. We can use mouse wheel for scroll up & down
            // -----------------------------------------------------------------------------------------
            Panel1.VerticalScroll.Maximum = 0;
            Panel1.HorizontalScroll.Maximum = 0;
            Panel1.AutoScroll = false;
            Panel1.VerticalScroll.Visible = false;
            Panel1.HorizontalScroll.Visible = false;
            Panel1.AutoScroll = true;
            // -----------------------------------------------------------------------------------------

        }


        #endregion

        #region UC private events: Resize()

        private void Z80_Navigation_Resize(object sender, EventArgs e)
        {
            if (_navBarItems != null)            
                DrawControlItems();            
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Initialize (and draws) the control.
        /// This method should de called only one time
        /// </summary>
        /// <param name="navbar">list of our navigation items</param>
        /// <param name="theme">theme applied to control</param>
        public void Initialize(List<Z80NavBar.NavBarItem> navbar, Z80NavBar.Themes.ITheme theme)
        {
            _navBarItems = navbar;
            _theme = theme;
            DrawControlItems();
        }

        /// <summary>
        /// Add a new item (always a child) in run-time to navigation control
        /// </summary>
        /// <param name="parentID">Parent ID</param>
        /// <param name="text">Text for this new item</param>
        /// <param name="itemID">The new item ID. Make sure that new item no longer exist in any other ithem</param>
        /// <param name="leftChild">Optional value for left text position</param>
        public void AddItem(int parentID, string text, int itemID, int leftChild = 10)
        {
            foreach (var nbi in _navBarItems)
            {
                if (nbi.ID == parentID)
                {
                    if (nbi.Childs == null)
                        nbi.Childs = new List<Z80NavBar.NavBarItem>();
                    
                    Z80NavBar.NavBarItem newItem = new Z80NavBar.NavBarItem {ID = itemID, ParentID = parentID, Text = text};

                    nbi.Childs.Add(newItem);
                }
                else
                {
                    if (nbi.Childs != null && nbi.Childs.Count > 0)
                        AddChild(nbi, parentID, text, itemID, leftChild);
                }
            }

            DrawControlItems();
        }

        /// <summary>
        /// Set item as enable or disable in run-time
        /// </summary>
        /// <param name="enable">if you set enable to false the item can not be clicked and also display as 'grayed'</param>
        /// <param name="itemID">item ID we want to enable or disable</param>
        public void ItemChangeEnable(bool enable, int itemID)
        {
            foreach (var nbi in _navBarItems)
            {
                if (nbi.ID == itemID)
                    nbi.Enabled = enable;

                if (nbi.Childs != null && nbi.Childs.Count > 0)
                    EnableItemChild(nbi, enable, itemID);
            }

            DrawControlItems();
        }

        /// <summary>
        /// Set item visibility in run-time
        /// </summary>
        /// <param name="visible">visibility value</param>
        /// <param name="itemID">item ID we want to setup it visibility</param>
        public void ItemChangeVisibility(bool visible, int itemID)
        {

            foreach (var nbi in _navBarItems)
            {
                if (nbi.ID == itemID)
                    nbi.Visible = visible;

                if (nbi.Childs != null && nbi.Childs.Count > 0)
                    VisibilityItemChild(nbi, visible, itemID);
            }

            DrawControlItems();
        }

        private Z80NavBar.NavBarItem _JRIT_item;
        /// <summary>
        /// Select item in run-time
        /// </summary>
        /// <param name="itemID">item ID we want to select</param>
        public void ItemSelect(int itemID)
        {
            foreach (var nbi in _navBarItems)
            {
                nbi.Selected = false;
                nbi.Expanded = false;
                nbi.Content = false;
                if (nbi.ID == itemID)
                    _JRIT_item = nbi;

                if (nbi.Childs != null && nbi.Childs.Count > 0)
                    ResetAllSelect(nbi, itemID);
            }

            OnItemClick(_JRIT_item);
        }

        /// <summary>
        /// This property can be use for change the current theme in Run-Time
        /// </summary>
        public void SetTheme(Z80NavBar.Themes.ITheme theme)
        {
            _theme = theme;
            DrawControlItems();
        }

        /// <summary>
        /// This method unselect all items. Can be used in Run-Time
        /// </summary>
        public void ItemUnselectAll()
        {
            foreach (var nbi in _navBarItems)
            {
                nbi.Selected = false;
                nbi.Expanded = false;
                nbi.Content = false;
                if (nbi.Childs != null && nbi.Childs.Count > 0)
                    ResetAll(nbi);
            }
            DrawControlItems();
        }

        #endregion

        #region Private methods

        #region Draw items

        /// <summary>
        /// Auxiliary variable for right Y Location value for each item when we draw all items
        /// </summary>

        private int _item_yLocation = 0;

        private int _childDepth = 0;
        /// <summary>
        /// Draw child items (Recursive)
        /// </summary>
        /// <param name="item"></param>
        private void DrawChilds(Z80NavBar.NavBarItem item)
        {
            if (item.Expanded & item.Visible)
            {
                foreach (var c in item.Childs)
                {
                    if (c.Visible)
                    {
                        NavBarItemPanel mPanel = new NavBarItemPanel();
                        mPanel.Location = new Point(0, _item_yLocation);
                        mPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                        _item_yLocation += c.Height;
                        mPanel.Initialize(c, this.Width, _theme, _childDepth);

                        mPanel.ItemClick += OnItemClick;
                        Panel1.Controls.Add(mPanel);

                        if (c.Childs != null && c.Childs.Count > 0)
                        {
                            _childDepth += 1;
                            DrawChilds(c);
                            _childDepth -= 1;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 'MAIN' method that draws all the items
        /// </summary>
        private void DrawControlItems()
        {
            this.BackColor = _theme.BackgroundColor(0);

            Panel1.Controls.Clear();
            Panel1.BackColor = _theme.BackgroundColor(0);

            foreach (var item in _navBarItems)
            {
                _childDepth = 0;

                if (item.Visible)
                {
                    NavBarItemPanel mPanel = new NavBarItemPanel();
                    mPanel.Location = new Point(0, _item_yLocation);
                    mPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    _item_yLocation += item.Height;
                    mPanel.Initialize(item, this.Width, _theme, _childDepth);

                    mPanel.ItemClick += OnItemClick;
                    Panel1.Controls.Add(mPanel);

                    if (item.Childs != null && item.Childs.Count > 0)
                    {
                        _childDepth += 1;
                        DrawChilds(item);
                    }
                }
            }

            _item_yLocation = 0;

            foreach (var p in Panel1.Controls.OfType<NavBarItemPanel>())
            {
                if (finalSelectedItem != null)
                {
                    if (p._navItem.ID == finalSelectedItem.ID)
                    {
                        if (p.Location.Y > (this.Height / 2) + (this.Height / 4))
                            Panel1.AutoScrollPosition = new Point(0, p.Location.Y);
                    }
                }
            }

            // YES, you are right, this 2 lines are a completely shit:
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        #endregion

        #region OnItemClick Event

        private List<int> _parentID_List;
        private int _parentID_index = 0;

        private bool _bChildFound = false;
        #region "Reset all Childs"

        private void ResetAll(Z80NavBar.NavBarItem item)
        {
            foreach (var c in item.Childs)
            {
                c.Selected = false;
                c.Expanded = false;
                c.Content = false;

                if (c.Childs != null && c.Childs.Count > 0)
                    ResetAll(c);
            }
        }

        private void ResetAllSelect(Z80NavBar.NavBarItem item, int itemID)
        {
            foreach (var c in item.Childs)
            {
                c.Selected = false;
                c.Expanded = false;
                c.Content = false;

                if (c.ID == itemID)
                    _JRIT_item = c;

                if (c.Childs != null && c.Childs.Count > 0)
                    ResetAllSelect(c, itemID);
            }
        }

        #endregion

        #region "Get all parents of the clicked item and autoexpand node"

        private void GetAllParentsChild(Z80NavBar.NavBarItem clickedItem, Z80NavBar.NavBarItem item, int? parentID)
        {
            foreach (var c in item.Childs)
            {
                if (c.ID == clickedItem.ID)
                {
                    if (c.Childs != null && c.Childs.Count > 0)
                        _parentID_List.Add(c.ID);
                    else if (parentID != null)
                        _parentID_List.Add((int)parentID);

                    _bChildFound = true;
                    return;
                }

                if (c.Childs != null && c.Childs.Count > 0)
                {
                    GetAllParentsChild(clickedItem, c, c.ID);
                    if (_bChildFound)
                    {
                        _parentID_List.Add(c.ID);
                        break; // foreach Exit For
                    }
                }
            }
        }

        private void GetAllParents(Z80NavBar.NavBarItem clickedItem)
        {
            foreach (var nbi in _navBarItems)
            {
                _parentID_List = new List<int>();
                if (nbi.ID == clickedItem.ID)
                {
                    _bChildFound = true;
                    _parentID_List.Add(nbi.ID);
                    break; // foreach Exit For
                }
                else
                {
                    if (nbi.Childs != null && nbi.Childs.Count > 0)
                    {
                        GetAllParentsChild(clickedItem, nbi, nbi.ParentID);
                        if (_bChildFound)
                        {
                            _parentID_List.Add(nbi.ID);
                            break; // foreach Exit For
                        }
                    }
                }
            }
        }

        private void GetFirsAvailable(Z80NavBar.NavBarItem clickedItem)
        {
            if (clickedItem.Childs[0].Childs != null && clickedItem.Childs.Count > 0)
            {
                _parentID_List.Add(clickedItem.Childs[0].ID);
                GetFirsAvailable(clickedItem.Childs[0]);
            }
        }

        private void AutoExpand(Z80NavBar.NavBarItem clickedItem, Z80NavBar.NavBarItem item)
        {
            foreach (var nbi in item.Childs)
            {
                if (_parentID_index == _parentID_List.Count)
                    break; // foreach Exit For

                if (nbi.ID == _parentID_List[_parentID_index])
                {
                    _parentID_index += 1;
                    nbi.Selected = true;
                    nbi.Expanded = true;
                    if (_parentID_index < _parentID_List.Count)
                        AutoExpand(clickedItem, nbi);
                    else
                    {
                        if (nbi.ParentID == clickedItem.ParentID | (clickedItem.ParentID == null))
                        {
                            nbi.Content = true;
                            nbi.Childs[0].Selected = true;
                            finalSelectedItem = nbi.Childs[0];
                            SelectedItem?.Invoke(nbi.Childs[0]);
                        }
                        else
                        {
                            bool selected = false;
                            foreach (var nbic in nbi.Childs)
                            {
                                if ((nbic.ID == clickedItem.ID))
                                {
                                    nbi.Content = true;
                                    nbic.Selected = true;
                                    nbi.Expanded = true;
                                    finalSelectedItem = clickedItem;
                                    selected = true;
                                    SelectedItem?.Invoke(clickedItem);
                                    break; // foreach Exit For
                                }
                            }

                            if (!selected)
                            {
                                nbi.Content = true;
                                nbi.Childs[0].Selected = true;
                                finalSelectedItem = nbi.Childs[0];
                                SelectedItem?.Invoke(nbi.Childs[0]);
                            }
                        }
                        break; // foreach Exit For
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// This item is fired when we click on a NavBarItemPanel UserControl
        /// </summary>
        /// <param name="item"></param>
        private void OnItemClick(Z80NavBar.NavBarItem item)
        {
            // By default we 'reset' all items as:
            // Not selected
            // Not expanded
            // Not Content
            // -----------------------------------------------------------------------------------------
            foreach (var nbi in _navBarItems)
            {
                nbi.Selected = false;
                nbi.Expanded = false;
                nbi.Content = false;
                if (nbi.Childs != null && nbi.Childs.Count > 0)
                    ResetAll(nbi);
            }
            // -----------------------------------------------------------------------------------------

            _parentID_List = new List<int>();
            GetAllParents(item);
            _parentID_List = _parentID_List.Distinct().ToList();
            _parentID_List.Reverse();

            _bChildFound = false;

            // Get the 1st available item :
            if (item.Childs != null && item.Childs.Count > 0)
                GetFirsAvailable(item);

            _parentID_index = 0;

            foreach (var nbi in _navBarItems)
            {
                if (nbi.ID == _parentID_List[0])
                {
                    _parentID_index += 1;
                    nbi.Selected = true;
                    nbi.Expanded = true;
                    if (_parentID_List.Count == 1)
                    {
                        nbi.Content = true;

                        if (item.ParentID != null)
                        {
                            var p = _navBarItems.Find(c => c.ID == item.ParentID);
                            p.Selected = true;
                            p.Expanded = true;

                            item.Selected = true;
                            finalSelectedItem = item;
                            SelectedItem?.Invoke(item);
                            break; // foreach Exit For                                   
                        }
                        else // autoexpand first child or root
                        {
                            if (nbi.Childs != null && nbi.Childs.Count > 0)
                            {
                                nbi.Childs[0].Selected = true;
                                finalSelectedItem = nbi.Childs[0];
                                SelectedItem?.Invoke(nbi.Childs[0]);
                            }
                            else
                            {
                                finalSelectedItem = item;
                                SelectedItem?.Invoke(item);
                            }
                        }
                    }
                    else
                        AutoExpand(item, nbi);
                }
            }

            _parentID_index = 0;

            DrawControlItems();
        }

        #endregion

        #region Add item (childs) (Recursive)

        private void AddChild(Z80NavBar.NavBarItem item, int parentID, string text, int itemID, int leftChild = 10)
        {
            foreach (var c in item.Childs)
            {
                if (c.ID == parentID)
                {
                    if (c.Childs == null)
                        c.Childs = new List<Z80NavBar.NavBarItem>();

                    Z80NavBar.NavBarItem newItem = new Z80NavBar.NavBarItem {ID = itemID, ParentID = parentID, Text = text, LeftChild = leftChild};

                    c.Childs.Add(newItem);
                }

                if (c.Childs != null && c.Childs.Count > 0)
                    AddChild(c, parentID, text, itemID, leftChild);
            }
        }

        #endregion

        #region Item enable or disable (childs) (Recursive)

        private void EnableItemChild(Z80NavBar.NavBarItem item, bool enable, int itemID)
        {
            foreach (var c in item.Childs)
            {                
                if (c.ID == itemID)
                    c.Enabled = enable;

                if (c.Childs != null && c.Childs.Count > 0)
                    EnableItemChild(c, enable, itemID);
            }
        }

        #endregion

        #region Item visibility (childs) (Recursive)

        private void VisibilityItemChild(Z80NavBar.NavBarItem item, bool visible, int itemID)
        {
            foreach (var c in item.Childs)
            {
                if (c.ID == itemID)
                    c.Visible = visible;

                if (c.Childs != null && c.Childs.Count > 0)
                    VisibilityItemChild(c, visible, itemID);
            }
        }

        #endregion

        #endregion

        #region ### CUSTOM Panel ###

        /// <summary>
        /// Each item is 'draw' in this custom control (Panel)
        /// This custom control is what we 'see' on screen
        /// </summary>
        private class NavBarItemPanel : Panel
        {

            #region "Variables"

            /// <summary>
            /// Flag to check if Initialize method has been called
            /// </summary>

            private bool _initialized = false;
            /// <summary>
            /// Flag to check Hover efect
            /// </summary>

            private bool _hover = false;
            /// <summary>
            /// Item theme injected in Initialize() method
            /// </summary>

            private Z80NavBar.Themes.ITheme _theme;
            /// <summary>
            /// Item depth injected in Initialize() method
            /// </summary>

            private int _depth;
            /// <summary>
            /// Item we are drawing
            /// </summary>

            public Z80NavBar.NavBarItem _navItem;
            /// <summary>
            /// Event we trigger when click on the panel control.
            /// </summary>
            /// <param name="item"></param>
            public event ItemClickEventHandler ItemClick;
            public delegate void ItemClickEventHandler(Z80NavBar.NavBarItem item);

            #endregion

            #region "Initialization"

            public void Initialize(Z80NavBar.NavBarItem navItem, int width, Z80NavBar.Themes.ITheme theme, int depth)
            {
                _navItem = navItem;
                _theme = theme;
                _depth = depth;

                this.Height = navItem.Height;
                this.Width = width;
                this.BackColor = theme.BackgroundColor(depth);

                _initialized = true;
            }

            #endregion

            #region "Paint. Voodoo goes here"

            protected override void OnPaint(PaintEventArgs e)
            {
                if (_initialized)
                {
                    float yPos = this.Height / 2 - (_theme.FontItem(_depth).Height / 2);
                    float xPos = 34;

                    if (_navItem.ParentID != null)
                        xPos = (float)_navItem.LeftChild;

                    if (_navItem.Enabled)
                    {
                        if (_hover)
                        {
                            if (_navItem.Icon != null)
                                e.Graphics.DrawImage(_navItem.Icon.Hover, new PointF(8, 8));

                            e.Graphics.DrawString(_navItem.Text, _theme.FontItem(_depth), _theme.BrushFontHover(_depth), new PointF(xPos, yPos));
                            //hover backcolor only in root nodes and items with 'childs'
                            if ((_navItem.ParentID == null) || (_navItem.Childs != null && _navItem.Childs.Count > 0))
                            {
                                this.BackColor = _theme.HoverBackgroundColor(_depth);
                                // v glyph only in childs (not root nodes)
                                if (_navItem.ParentID != null && _navItem.Childs != null)
                                {
                                    Point p1 = new Point(this.Width - 4, this.Height / 2);
                                    Point p2 = new Point(this.Width - 12, this.Height / 2);
                                    Point p3 = new Point(this.Width - 8, ((this.Height / 2) + 4));
                                    Point[] p = {p1, p2, p3 };
                                    SolidBrush b = _theme.BrushFontHover(_depth);
                                    e.Graphics.FillPolygon(b, p);
                                }
                            }                            
                        }
                        else //not hover
                        {
                            if (!_navItem.Selected)
                            {
                                if (_navItem.Icon != null)
                                    e.Graphics.DrawImage(_navItem.Icon.Default, new PointF(8, 8));

                                e.Graphics.DrawString(_navItem.Text, _theme.FontItem(_depth), _theme.BrushFontItemNotSelected(_depth), new PointF(xPos, yPos));
                                this.BackColor = _theme.BackgroundColor(_depth);
                                // v glyph only in childs (not root nodes)
                                if (_navItem.ParentID != null && _navItem.Childs != null)
                                {
                                    Point p1 = new Point(this.Width - 4, this.Height / 2);
                                    Point p2 = new Point(this.Width - 12, this.Height / 2);
                                    Point p3 = new Point(this.Width - 8, ((this.Height / 2) + 4));
                                    Point[] p = {p1, p2, p3};
                                    SolidBrush b = _theme.BrushFontItemNotSelected(_depth);
                                    e.Graphics.FillPolygon(b, p);
                                }                                
                            }
                            else //selected Item
                            {
                                if (_navItem.Icon != null)
                                    e.Graphics.DrawImage(_navItem.Icon.Selected, new PointF(8, 8));

                                e.Graphics.DrawString(_navItem.Text, _theme.FontItemSelected(_depth), _theme.BrushFontItemSelected(_depth), new PointF(xPos, yPos));
                                if ((_navItem.ParentID == null) || (_navItem.Childs != null && _navItem.Childs.Count > 0))
                                {
                                    this.BackColor = _theme.SelectedBackgroundColor(_depth);
                                    // < glyph:
                                    if (_navItem.Content)
                                    {
                                        Point p1 = new Point(this.Width - 8, this.Height / 2);
                                        Point p2 = new Point(this.Width, ((this.Height / 2) - 8));
                                        Point p3 = new Point(this.Width, ((this.Height / 2) + 8));
                                        Point[] p = {p1, p2, p3};
                                        SolidBrush b = new SolidBrush(_navItem.ContentBackColor);
                                        e.Graphics.FillPolygon(b, p);
                                    }
                                }
                            }
                        }
                    }
                    else //Item disabled
                    {
                        this.Enabled = false;

                        //if you want to display icon when item was unselected, uncomment this If sentence:
                        //if (_navItem.Icon != null)
                        //    e.Graphics.DrawImage(_navItem.Icon.Selected, new PointF(8, 8));
                        
                        e.Graphics.DrawString(_navItem.Text, _theme.FontItem(_depth), _theme.BrushFontItemDisable, new PointF(xPos, yPos));
                        this.BackColor = _theme.ItemDisableBackgroudColor;
                    }
                }
                base.OnPaint(e);
            }

            #endregion

            private void MyPanel_MouseEnter(object sender, EventArgs e)
            {
                if (!_navItem.Selected)
                {
                    _hover = true;
                    this.Invalidate();
                }
            }

            private void MyPanel_MouseLeave(object sender, EventArgs e)
            {
                if (!_navItem.Selected)
                {
                    _hover = false;
                    this.Invalidate();
                }
            }

            private void MyPanel_Click(object sender, EventArgs e)
            {
                if (!_navItem.Selected)
                {
                    _hover = false;
                    _navItem.Selected = true;
                    this.Invalidate();
                    ItemClick?.Invoke(_navItem);
                }
            }
            public NavBarItemPanel()
            {
                Click += MyPanel_Click;
                MouseLeave += MyPanel_MouseLeave;
                MouseEnter += MyPanel_MouseEnter;
            }
        }

        #endregion

    }
}
