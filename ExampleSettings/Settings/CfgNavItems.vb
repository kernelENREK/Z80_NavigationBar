Imports ExampleSettings.Z80NavBar

Public Class CfgNavItems

    Public myNavItems As List(Of NavBarItem)

    Public Sub New()
        myNavItems = New List(Of NavBarItem)() From {
            New NavBarItem With {.ID = 1, .Text = "Application", .Icon = New ItemIcon() With {.Default = My.Resources.wpUsers, .Hover = My.Resources.wpUsersH, .Selected = My.Resources.wpUsersS}},
            New NavBarItem With {.ID = 2, .Text = "Hardware", .Icon = New ItemIcon() With {.Default = My.Resources.wpDesktop, .Hover = My.Resources.wpDesktopH, .Selected = My.Resources.wpDesktopS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 2001, .ParentID = 2, .Text = "Scales", .Height = 30},
                    New NavBarItem() With {.ID = 2002, .ParentID = 2, .Text = "Temperature sensor", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 3, .Text = "Database", .Icon = New ItemIcon() With {.Default = My.Resources.navdb, .Hover = My.Resources.navdbH, .Selected = My.Resources.navdbS}}
        }

    End Sub

End Class
