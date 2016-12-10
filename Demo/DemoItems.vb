Imports Demo.Z80NavBar

Public Class DemoItems

    Public sample1 As List(Of NavBarItem)
    Public sample2 As List(Of NavBarItem)
    Public sample3 As List(Of NavBarItem)

    Public Sub New()

        ' Sample 1. Only Root items. No childs ----------------------------------------------------
        sample1 = New List(Of NavBarItem)() From {
            New NavBarItem With {.ID = 1, .Text = "Desktop", .Icon = New ItemIcon() With {.Default = My.Resources.wpDesktop, .Hover = My.Resources.wpDesktopH, .Selected = My.Resources.wpDesktopS}},
            New NavBarItem With {.ID = 2, .Text = "Store", .Icon = New ItemIcon() With {.Default = My.Resources.wpStore, .Hover = My.Resources.wpStoreH, .Selected = My.Resources.wpStoreS}},
            New NavBarItem With {.ID = 3, .Text = "Posts", .Icon = New ItemIcon() With {.Default = My.Resources.wpPost, .Hover = My.Resources.wpPostH, .Selected = My.Resources.wpPostS}},
            New NavBarItem With {.ID = 4, .Text = "Media", .Icon = New ItemIcon() With {.Default = My.Resources.wpMedia, .Hover = My.Resources.wpMediaH, .Selected = My.Resources.wpMediaS}},
            New NavBarItem With {.ID = 5, .Text = "Links", .Icon = New ItemIcon() With {.Default = My.Resources.wpLinks, .Hover = My.Resources.wpLinksH, .Selected = My.Resources.wpLinksS}}
        }

        ' Sample 2. Only 1 level childs items -------------------------------------------------
        sample2 = New List(Of NavBarItem)() From {
            New NavBarItem With {.ID = 1, .Text = "Desktop", .Icon = New ItemIcon() With {.Default = My.Resources.wpDesktop, .Hover = My.Resources.wpDesktopH, .Selected = My.Resources.wpDesktopS},
                .Childs = New List(Of NavBarItem)() From {
                        New NavBarItem() With {.ID = 1001, .ParentID = 1, .Text = "Start", .Height = 30},
                        New NavBarItem() With {.ID = 1002, .ParentID = 1, .Text = "My comments", .Height = 30},
                        New NavBarItem() With {.ID = 1003, .ParentID = 1, .Text = "Site Statistics", .Height = 30},
                        New NavBarItem() With {.ID = 1004, .ParentID = 1, .Text = "My blogs", .Height = 30},
                        New NavBarItem() With {.ID = 1005, .ParentID = 1, .Text = "Blogs I follow", .Height = 30},
                        New NavBarItem() With {.ID = 1006, .ParentID = 1, .Text = "Akismed statistics", .Height = 30},
                        New NavBarItem() With {.ID = 1007, .ParentID = 1, .Text = "Omnisearch", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 2, .Text = "Store", .Icon = New ItemIcon() With {.Default = My.Resources.wpStore, .Hover = My.Resources.wpStoreH, .Selected = My.Resources.wpStoreS},
                .Childs = New List(Of NavBarItem)() From {
                        New NavBarItem() With {.ID = 2001, .ParentID = 2, .Text = "Main", .Height = 30},
                        New NavBarItem() With {.ID = 2002, .ParentID = 2, .Text = "Premium Themes", .Height = 30},
                        New NavBarItem() With {.ID = 2003, .ParentID = 2, .Text = "My domains", .Height = 30},
                        New NavBarItem() With {.ID = 2004, .ParentID = 2, .Text = "Manage purchases", .Height = 30},
                        New NavBarItem() With {.ID = 2005, .ParentID = 2, .Text = "Billing history", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 3, .Text = "Posts", .Icon = New ItemIcon() With {.Default = My.Resources.wpPost, .Hover = My.Resources.wpPostH, .Selected = My.Resources.wpPostS},
                .Childs = New List(Of NavBarItem)() From {
                        New NavBarItem() With {.ID = 3001, .ParentID = 3, .Text = "All", .Height = 30},
                        New NavBarItem() With {.ID = 3002, .ParentID = 3, .Text = "Add new", .Height = 30},
                        New NavBarItem() With {.ID = 3003, .ParentID = 3, .Text = "Categories", .Height = 30},
                        New NavBarItem() With {.ID = 3004, .ParentID = 3, .Text = "Tags", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 4, .Text = "Media", .Icon = New ItemIcon() With {.Default = My.Resources.wpMedia, .Hover = My.Resources.wpMediaH, .Selected = My.Resources.wpMediaS},
                .Childs = New List(Of NavBarItem)() From {
                        New NavBarItem() With {.ID = 4001, .ParentID = 4, .Text = "Library", .Height = 30},
                        New NavBarItem() With {.ID = 4002, .ParentID = 4, .Text = "Add new", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 5, .Text = "Links", .Icon = New ItemIcon() With {.Default = My.Resources.wpLinks, .Hover = My.Resources.wpLinksH, .Selected = My.Resources.wpLinksS},
                .Childs = New List(Of NavBarItem)() From {
                        New NavBarItem() With {.ID = 5001, .ParentID = 5, .Text = "All", .Height = 30},
                        New NavBarItem() With {.ID = 5002, .ParentID = 5, .Text = "Add new", .Height = 30},
                        New NavBarItem() With {.ID = 5003, .ParentID = 5, .Text = "Link categories", .Height = 30}
                }
            }
        }

        ' Sample 3. Very 'complex tree-node items'. Until 5th depth childs
        sample3 = New List(Of NavBarItem)() From {
            New NavBarItem With {.ID = 1, .Text = "Desktop", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpDesktop, .Hover = My.Resources.wpDesktopH, .Selected = My.Resources.wpDesktopH},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 1001, .ParentID = 1, .Text = "Start", .Height = 30},
                    New NavBarItem() With {.ID = 1002, .ParentID = 1, .Text = "My comments", .Height = 30},
                    New NavBarItem() With {.ID = 1003, .ParentID = 1, .Text = "Site Statistics", .Height = 30},
                    New NavBarItem() With {.ID = 1004, .ParentID = 1, .Text = "My blogs", .Height = 30,
                        .Childs = New List(Of NavBarItem)() From {
                            New NavBarItem() With {.ID = 10041, .ParentID = 1004, .Text = "Custom #1", .Height = 30, .LeftChild = 24},
                            New NavBarItem() With {.ID = 10042, .ParentID = 1004, .Text = "Custom #2", .Height = 30, .LeftChild = 24,
                                .Childs = New List(Of NavBarItem)() From {
                                    New NavBarItem() With {.ID = 100421, .ParentID = 10042, .Text = "XXX1", .Height = 30, .LeftChild = 44},
                                    New NavBarItem() With {.ID = 100422, .ParentID = 10042, .Text = "XXX2", .Height = 30, .LeftChild = 44}
                                }
                            },
                            New NavBarItem() With {.ID = 10043, .ParentID = 1004, .Text = "Custom #3", .Height = 30, .LeftChild = 24}
                        }
                    },
                    New NavBarItem() With {.ID = 1005, .ParentID = 1, .Text = "Blogs I follow", .Height = 30,
                       .Childs = New List(Of NavBarItem)() From {
                            New NavBarItem() With {.ID = 10051, .ParentID = 1005, .Text = "xxx blog x1", .Height = 30, .LeftChild = 24},
                            New NavBarItem() With {.ID = 10052, .ParentID = 1005, .Text = "xxx blog x2", .Height = 30, .LeftChild = 24},
                            New NavBarItem() With {.ID = 10053, .ParentID = 1005, .Text = "xxx blog x3", .Height = 30, .LeftChild = 24},
                            New NavBarItem() With {.ID = 10054, .ParentID = 1005, .Text = "xxx blog x4", .Height = 30, .LeftChild = 24}
                        }
                    },
                    New NavBarItem() With {.ID = 1006, .ParentID = 1, .Text = "Akismed statistics", .Height = 30},
                    New NavBarItem() With {.ID = 1007, .ParentID = 1, .Text = "Omnisearch", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 2, .Text = "Store", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpStore, .Hover = My.Resources.wpStoreH, .Selected = My.Resources.wpStoreS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 2001, .ParentID = 2, .Text = "Main", .Height = 30},
                    New NavBarItem() With {.ID = 2002, .ParentID = 2, .Text = "Premium Themes", .Height = 30},
                    New NavBarItem() With {.ID = 2003, .ParentID = 2, .Text = "My domains", .Height = 30},
                    New NavBarItem() With {.ID = 2004, .ParentID = 2, .Text = "Manage purchases", .Height = 30},
                    New NavBarItem() With {.ID = 2005, .ParentID = 2, .Text = "Billing history", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 3, .Text = "Posts", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpPost, .Hover = My.Resources.wpPostH, .Selected = My.Resources.wpPostS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 3001, .ParentID = 3, .Text = "All", .Height = 30},
                    New NavBarItem() With {.ID = 3002, .ParentID = 3, .Text = "Add new", .Height = 30},
                    New NavBarItem() With {.ID = 3003, .ParentID = 3, .Text = "Categories", .Height = 30},
                    New NavBarItem() With {.ID = 3004, .ParentID = 3, .Text = "Tags", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 4, .Text = "Media", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpMedia, .Hover = My.Resources.wpMediaH, .Selected = My.Resources.wpMediaS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 4001, .ParentID = 4, .Text = "Library", .Height = 30},
                    New NavBarItem() With {.ID = 4002, .ParentID = 4, .Text = "Add new", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 5, .Text = "Links", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpLinks, .Hover = My.Resources.wpLinksH, .Selected = My.Resources.wpLinksS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 5001, .ParentID = 5, .Text = "All", .Height = 30},
                    New NavBarItem() With {.ID = 5002, .ParentID = 5, .Text = "Add new", .Height = 30},
                    New NavBarItem() With {.ID = 5003, .ParentID = 5, .Text = "Link categories", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 6, .Text = "Pages", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpPages, .Hover = My.Resources.wpPagesH, .Selected = My.Resources.wpPagesS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 6001, .ParentID = 6, .Text = "All", .Height = 30},
                    New NavBarItem() With {.ID = 6002, .ParentID = 6, .Text = "Add new", .Height = 30},
                    New NavBarItem() With {.ID = 6003, .ParentID = 6, .Text = "Copy page", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 7, .Text = "Comments", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpComments, .Hover = My.Resources.wpCommentsH, .Selected = My.Resources.wpCommentsS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 7001, .ParentID = 7, .Text = "Test", .Height = 30,
                        .Childs = New List(Of NavBarItem)() From {
                            New NavBarItem() With {.ID = 70011, .ParentID = 7001, .Text = "Custom #1", .Height = 30, .LeftChild = 24,
                                .Childs = New List(Of NavBarItem)() From {
                                    New NavBarItem() With {.ID = 700111, .ParentID = 70011, .Text = "Custom #1x1", .Height = 30, .LeftChild = 44},
                                    New NavBarItem() With {.ID = 700112, .ParentID = 70011, .Text = "Custom #1x2", .Height = 30, .LeftChild = 44},
                                    New NavBarItem() With {.ID = 700113, .ParentID = 70011, .Text = "Custom #1x3", .Height = 30, .LeftChild = 44},
                                    New NavBarItem() With {.ID = 700114, .ParentID = 70011, .Text = "Custom #1x4", .Height = 30, .LeftChild = 44}
                                }
                            },
                            New NavBarItem() With {.ID = 70012, .ParentID = 7001, .Text = "Custom #2", .Height = 30, .LeftChild = 24},
                            New NavBarItem() With {.ID = 70013, .ParentID = 7001, .Text = "Custom #3", .Height = 30, .LeftChild = 24}
                        }
                    },
                    New NavBarItem() With {.ID = 7002, .ParentID = 7, .Text = "Remove", .Height = 30,
                        .Childs = New List(Of NavBarItem)() From {
                            New NavBarItem() With {.ID = 70021, .ParentID = 7002, .Text = "something #1", .Height = 30, .LeftChild = 24,
                                .Childs = New List(Of NavBarItem)() From {
                                    New NavBarItem() With {.ID = 700211, .ParentID = 70021, .Text = "xxxxxx1", .Height = 30, .LeftChild = 44,
                                        .Childs = New List(Of NavBarItem)() From {
                                            New NavBarItem() With {.ID = 7002111, .ParentID = 700211, .Text = "5th child #1", .Height = 24, .LeftChild = 59},
                                            New NavBarItem() With {.ID = 7002112, .ParentID = 700211, .Text = "5th child #2", .Height = 24, .LeftChild = 59},
                                            New NavBarItem() With {.ID = 7002113, .ParentID = 700211, .Text = "5th child #3", .Height = 24, .LeftChild = 59},
                                            New NavBarItem() With {.ID = 7002114, .ParentID = 700211, .Text = "5th child #4", .Height = 24, .LeftChild = 59}
                                        }
                                    },
                                    New NavBarItem() With {.ID = 700212, .ParentID = 70021, .Text = "xxxxxx2", .Height = 30, .LeftChild = 44},
                                    New NavBarItem() With {.ID = 700213, .ParentID = 70021, .Text = "xxxxxx3", .Height = 30, .LeftChild = 44},
                                    New NavBarItem() With {.ID = 700214, .ParentID = 70021, .Text = "xxxxxx4", .Height = 30, .LeftChild = 44}
                                }
                            },
                            New NavBarItem() With {.ID = 70022, .ParentID = 7002, .Text = "somehting #2", .Height = 30, .LeftChild = 24}
                        }
                    },
                    New NavBarItem() With {.ID = 7003, .ParentID = 7, .Text = "Attach", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 8, .Text = "Suggestions", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpSuggestions, .Hover = My.Resources.wpSuggestionsH, .Selected = My.Resources.wpSuggestionsS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 8001, .ParentID = 8, .Text = "Polls", .Height = 30},
                    New NavBarItem() With {.ID = 8002, .ParentID = 8, .Text = "Qualifications", .Height = 30},
                    New NavBarItem() With {.ID = 8003, .ParentID = 8, .Text = "Send mark", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 9, .Text = "Appearance", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpAppearance, .Hover = My.Resources.wpAppearanceH, .Selected = My.Resources.wpAppearanceS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 9001, .ParentID = 9, .Text = "Themes", .Height = 30},
                    New NavBarItem() With {.ID = 9002, .ParentID = 9, .Text = "Customize", .Height = 30},
                    New NavBarItem() With {.ID = 9003, .ParentID = 9, .Text = "Widgets", .Height = 30},
                    New NavBarItem() With {.ID = 9004, .ParentID = 9, .Text = "Menus", .Height = 30},
                    New NavBarItem() With {.ID = 9005, .ParentID = 9, .Text = "Header", .Height = 30},
                    New NavBarItem() With {.ID = 9006, .ParentID = 9, .Text = "Background", .Height = 30},
                    New NavBarItem() With {.ID = 9007, .ParentID = 9, .Text = "AMP", .Height = 30},
                    New NavBarItem() With {.ID = 9008, .ParentID = 9, .Text = "Theme settings", .Height = 30},
                    New NavBarItem() With {.ID = 9009, .ParentID = 9, .Text = "Smartphone", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 10, .Text = "Users", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpUsers, .Hover = My.Resources.wpUsersH, .Selected = My.Resources.wpUsersS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 10001, .ParentID = 10, .Text = "All", .Height = 30},
                    New NavBarItem() With {.ID = 10002, .ParentID = 10, .Text = "Invite user", .Height = 30},
                    New NavBarItem() With {.ID = 10003, .ParentID = 10, .Text = "My profile", .Height = 30},
                    New NavBarItem() With {.ID = 10004, .ParentID = 10, .Text = "Settings", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 11, .Text = "Tools", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpTools, .Hover = My.Resources.wpToolsH, .Selected = My.Resources.wpToolsS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 11001, .ParentID = 11, .Text = "Available tools", .Height = 30},
                    New NavBarItem() With {.ID = 11002, .ParentID = 11, .Text = "Import", .Height = 30},
                    New NavBarItem() With {.ID = 11003, .ParentID = 11, .Text = "Export", .Height = 30},
                    New NavBarItem() With {.ID = 11004, .ParentID = 11, .Text = "Delete site", .Height = 30}
                }
            },
            New NavBarItem With {.ID = 12, .Text = "Settings", .Icon = New ItemIcon() With {.[Default] = My.Resources.wpSettings, .Hover = My.Resources.wpSettingsH, .Selected = My.Resources.wpSettingsS},
                .Childs = New List(Of NavBarItem)() From {
                    New NavBarItem() With {.ID = 12001, .ParentID = 12, .Text = "Main", .Height = 30},
                    New NavBarItem() With {.ID = 12002, .ParentID = 12, .Text = "Writing", .Height = 30},
                    New NavBarItem() With {.ID = 12003, .ParentID = 12, .Text = "Reading", .Height = 30},
                    New NavBarItem() With {.ID = 12004, .ParentID = 12, .Text = "Comments", .Height = 30},
                    New NavBarItem() With {.ID = 12005, .ParentID = 12, .Text = "Media", .Height = 30},
                    New NavBarItem() With {.ID = 12006, .ParentID = 12, .Text = "Share", .Height = 30},
                    New NavBarItem() With {.ID = 12007, .ParentID = 12, .Text = "AdControl", .Height = 30},
                    New NavBarItem() With {.ID = 12008, .ParentID = 12, .Text = "OpenID", .Height = 30},
                    New NavBarItem() With {.ID = 12009, .ParentID = 12, .Text = "Webhooks", .Height = 30}
                }
            }
        }
    End Sub
End Class