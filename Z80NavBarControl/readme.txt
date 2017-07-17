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
  Then, press `Browse` button under the `.NET Framework Components` tab
  (probably the default tab) and select 'Z80NavBarControl.dll'
  located in your Project`Debug` folder. Accept the changes and control
  should be displayed on your toolbox.

  ALTERNATIVE METHOD: 
  Drag & Drop your `Debug` Z80NavBarControl.dll to your toolbox General tab
  
  Pro-tip:  However, you can always write the code manually and bypass
  the use of toolbox altogether.
  
SAMPLES
  You can check full samples on GitHub repo (https://github.com/kernelENREK/Z80_NavigationBar)
  
  Here the minimal stuff you need
  
  C# ----------------------------------------------------------------
  
  1) Drag the navigation control to your Form and use this code
  
  using System;
  using System.Windows.Forms;
  using Z80NavBarControl.Z80NavBar;
  using Z80NavBarControl.Z80NavBar.Themes;
  public partial class Form1 : Form
  {
    public Form1()
	{
	  InitializeComponent();
      List<NavBarItem> demoItems = new List<NavBarItem>
      {
        new NavBarItem {ID = 1, Text = "Item1"},
        new NavBarItem {ID = 2, Text = "Item2"},
        new NavBarItem {ID = 3, Text = "Item3"}
      };
      z80_Navigation1.Initialize(demoItems, new ThemeSelector(Theme.Dark).CurrentTheme);
	}  
  }
	
  VB.NET ------------------------------------------------------------
  
  1) Drag the navigation control to your Form and use this code
    
  Imports Z80NavBarControl.Z80NavBar
  Imports Z80NavBarControl.Z80NavBar.Themes

  Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim demoItems As List(Of NavBarItem) = New List(Of NavBarItem) From {
        New NavBarItem With {.ID = 1, .Text = "Item1"},
        New NavBarItem With {.ID = 2, .Text = "Item2"},
        New NavBarItem With {.ID = 3, .Text = "Item3"}
          }

      Z80_Navigation1.Initialize(demoItems, New ThemeSelector(Theme.Dark).CurrentTheme)
    End Sub
  End Class
  