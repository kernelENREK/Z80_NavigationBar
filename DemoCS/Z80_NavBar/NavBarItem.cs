using System.Collections.Generic;
using System.Drawing;

namespace Z80NavBar
{
    /// <summary>
    /// Z80_Navigation control Model for each item
    /// </summary>
    public class NavBarItem
    {
        /// <summary>
        /// Item ID. All items must have unique ID number
        /// </summary>
        /// <returns></returns>
        public int ID { get; set; }
        /// <summary>
        /// Text we see for our item
        /// </summary>
        /// <returns></returns>
        public string Text { get; set; }
        /// <summary>
        /// Icon for our item. Only Root (depth = 0) icons are displayed
        /// </summary>
        /// <returns></returns>
        public ItemIcon Icon { get; set; }
        /// <summary>
        /// Item enability.
        /// </summary>
        /// <returns></returns>
        public bool Enabled { get; set; }
        /// <summary>
        /// Item visibility
        /// </summary>
        /// <returns></returns>
        public bool Visible { get; set; }
        /// <summary>
        /// Item is selected
        /// </summary>
        /// <returns></returns>
        public bool Selected { get; set; }
        /// <summary>
        /// Item is expanded
        /// </summary>
        /// <returns></returns>
        public bool Expanded { get; set; }
        /// <summary>
        /// Item has really selected. Only one item must have content = true at once
        /// </summary>
        /// <returns></returns>
        public bool Content { get; set; }
        /// <summary>
        /// Parent ID for this item. It is root item (depth = 0) parent ID will bi nothing
        /// </summary>
        /// <returns></returns>
        public int? ParentID { get; set; }
        /// <summary>
        /// Child collection for that item
        /// </summary>
        public List<NavBarItem> Childs;
        /// <summary>
        /// Height (Panel) for that item
        /// </summary>
        /// <returns></returns>
        public int Height { get; set; }
        /// <summary>
        /// Act like a Identation on childs items
        /// </summary>
        /// <returns></returns>
        public int? LeftChild { get; set; }
        /// <summary>
        /// Color for glyph to match with content container (outside from Navigation control)
        /// </summary>
        /// <returns></returns>
        public Color ContentBackColor { get; set; }

        /// <summary>
        /// Default values
        /// </summary>
        public NavBarItem()
        {
            Enabled = true;
            Visible = true;
            Height = 34;
            LeftChild = 10;
            ContentBackColor = Color.FromArgb(241, 241, 241);
        }
    }

    /// <summary>
    /// Item icons. Only for root items  (depth = 0)
    /// </summary>
    public class ItemIcon
    {
        /// <summary>
        /// Default icon
        /// </summary>
        /// <returns></returns>
        public Image Default { get; set; }
        /// <summary>
        /// Icon when hover on item
        /// </summary>
        /// <returns></returns>
        public Image Hover { get; set; }
        /// <summary>
        /// Icon when item has been selected
        /// </summary>
        /// <returns></returns>
        public Image Selected { get; set; }
    }
}

