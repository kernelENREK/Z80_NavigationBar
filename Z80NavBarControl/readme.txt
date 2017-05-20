					  Navigation User Control
 WinForm User Control for manage settings screens with nice look & feel

=====================================================================

USAGE
  Build your application, and then use the toolbox to add the control
  to your forms.

KNOWN ISSUE WITH VISUAL STUDIO TOOLBOX
  If you couldn't find this control in the  toolbox and you failed to
  add it from the NuGet package directly, try using the copies of the
  library in your project's `Debug` or `Release` directories. 

  The  problem  with the  toolbox is  that it is  part of  the Visual 
  Studio and not your  project, and as the  result, it can't  resolve
  some dependencies, although they are already part of your project. 

  For fixing, select General tab in your toolbox, press mouse right
  click and select `Choose items...`.
  Then, press `Browse` button and select 'Z80NavBarControl.dll'
  located in your `Debug` folder. Accept the changes and control
  should be displayed on your toolbox.
  
  Pro-tip:  However, you can always write the code manually and bypass
  the use of toolbox altogether.
  
SAMPLES
  You can check full samples on GitHub repo (https://github.com/kernelENREK/Z80_NavigationBar)
  
  Here the minimal stuff you need
  
  C# ----------------------------------------------------------------
  
  1) Create a class, for example DemoItems.cs with this content:
  
  using Z80NavBarControl.Z80NavBar
  public class DemoItems
  {
    public List<NavBarItem> sample1;  
	public DemoItems()
	{
	  sample1 = new List(NavBarItem) {
	    new NavBarItem {ID = 1, Text = "Item1"},
		new NavBarItem {ID = 2, Text = "Item2"},
		new NavBarItem {ID = 3, Text = "Item3"}
	  }
	}
  }

  2) In the form where you are using the Navigation Control:
  
  using System;
  using System.Windows.Forms;
  using Z80NavBarControl.Z80NavBar;
  using Z80NavBarControl.Z80NavBar.Themes;
  public partial class Form1 : Form
  {
    public Form1()
	{
	  InitializeComponent();
	  z80_Navigation1.Initialize(new DemoItems().sample1, new ThemeSelector(Theme.Dark).CurrentTheme);
	}  
  }
	
  VB.NET ------------------------------------------------------------
  
  1) Create a class, for example DemoItems.vb with this content:
  
  Imports [put_your_NameSpace_here].Z80NavBarControl
  Public Class DemoItems
    Public sample1 as List(Of NavBarItem)
	Public Sub New()
	  sample1 = New List(Of NavBarItem)() From {
	    New NavBarItem With {.ID = 1, .Text = "Item1"},
		New NavBarItem With {.ID = 2, .Text = "Item2"},
		New NavBarItem With {.ID = 3, .Text = "Item3"}
	  }
	End Sub  
  End Class
  
  2) In the form where you are using the Navigation Control:
  
  Imports [put_your_NameSpace_here].Z80NavBar
  Imports [put_your_NameSpace_here].Z80NavBar.Themes
  Public Class Form1
	Public Sub New()
	  InitializeComponent()
	  Z80_Navigation1.Initialize(New DemoItems().sample1, New ThemeSelector(Theme.Dark).CurrentTheme)
	End Sub
  End Class
  
  