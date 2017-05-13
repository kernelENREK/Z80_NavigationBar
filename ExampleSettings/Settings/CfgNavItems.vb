Imports ExampleSettings.Z80NavBar

Public Class CfgNavItems

    Public myNavItems As List(Of NavBarItem)

    Public Sub New()
        myNavItems = New List(Of NavBarItem)() From {
            New NavBarItem With {.ID = eSettingsPanels.AppType, .Text = "Application", .Icon = New ItemIcon() With {.Default = My.Resources.wpUsers, .Hover = My.Resources.wpUsersH, .Selected = My.Resources.wpUsersS}},
            New NavBarItem With {.ID = eSettingsPanels.Hardware, .Text = "Hardware", .Icon = New ItemIcon() With {.Default = My.Resources.wpDesktop, .Hover = My.Resources.wpDesktopH, .Selected = My.Resources.wpDesktopS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = eSettingsPanels.Scales, .ParentID = eSettingsPanels.Hardware, .Text = "Scales", .Height = 30},
                    New NavBarItem() With {.ID = eSettingsPanels.TemperatureSensor, .ParentID = eSettingsPanels.Hardware, .Text = "Temperature sensor", .Height = 30}
                }
            },
            New NavBarItem With {.ID = eSettingsPanels.Database, .Text = "Database", .Icon = New ItemIcon() With {.Default = My.Resources.navdb, .Hover = My.Resources.navdbH, .Selected = My.Resources.navdbS}}
        }

    End Sub

End Class

Public Enum eSettingsPanels
    AppType = 1
    Hardware = 2
    Scales = 2001
    TemperatureSensor = 2002
    Database = 3
End Enum
