using System.Collections.Generic;
using Z80NavBarControl.Z80NavBar;

namespace DemoControlCS
{
    public class DemoItems
    {

        public List<NavBarItem> sample1;
        public List<NavBarItem> sample2;
        public List<NavBarItem> sample3;
        public List<NavBarItem> sample4Orion;

        public DemoItems()
        {
            // Sample 1. Only Root items. No childs ----------------------------------------------------
            sample1 = new List<NavBarItem> {
                new NavBarItem {ID = 1, Text = "Desktop", Icon = new ItemIcon {Default =  DemoControlCS.Properties.Resources.wpDesktop, Hover = DemoControlCS.Properties.Resources.wpDesktopH, Selected = DemoControlCS.Properties.Resources.wpDesktopS}, ToolTip = "tooltip Desktop"},
                new NavBarItem {ID = 2, Text = "Store", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpStore, Hover = DemoControlCS.Properties.Resources.wpStoreH, Selected = DemoControlCS.Properties.Resources.wpStoreS}},
                new NavBarItem {ID = 3, Text = "Posts", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpPost, Hover = DemoControlCS.Properties.Resources.wpPostH, Selected = DemoControlCS.Properties.Resources.wpPostS}},
                new NavBarItem {ID = 4, Text = "Media", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpMedia, Hover = DemoControlCS.Properties.Resources.wpMediaH, Selected = DemoControlCS.Properties.Resources.wpMediaS}},
                new NavBarItem {ID = 5, Text = "Links", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpLinks, Hover = DemoControlCS.Properties.Resources.wpLinksH, Selected = DemoControlCS.Properties.Resources.wpLinksS}, ToolTip = "tooltip Links"}
            };

            sample4Orion = new List<NavBarItem> {
                new NavBarItem {ID = 1, Text = "Main Menu", Icon = new ItemIcon {Default =  DemoControlCS.Properties.Resources.nav_home, Hover = DemoControlCS.Properties.Resources.nav_home, Selected = DemoControlCS.Properties.Resources.nav_home}, ToolTip = "tooltip Main Menu", Height = 40 },
                new NavBarItem {ID = 2, Text = "Settings", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.nav_settings, Hover = DemoControlCS.Properties.Resources.nav_settings, Selected = DemoControlCS.Properties.Resources.nav_settings}, Height = 40},
                new NavBarItem {ID = 3, Text = "Startup", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.nav_bulb, Hover = DemoControlCS.Properties.Resources.nav_bulb, Selected = DemoControlCS.Properties.Resources.nav_bulb}, Height = 40},
                new NavBarItem {ID = 4, Text = "File Assembly", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.nav_new, Hover = DemoControlCS.Properties.Resources.nav_new, Selected = DemoControlCS.Properties.Resources.nav_new}, Height = 40,
                    Childs = new List<NavBarItem> {
                        new NavBarItem {ID = 4001, ParentID = 4, Text = "Attach", Height = 30},
                        new NavBarItem {ID = 4002, ParentID = 4, Text = "CodeDom", Height = 30},
                        new NavBarItem {ID = 4003, ParentID = 4, Text = "Clean", Height = 30},
                        new NavBarItem {ID = 4004, ParentID = 4, Text = "Run", Height = 30}
                    }
                },
                new NavBarItem {ID = 5, Text = "Build", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.nav_tool, Hover = DemoControlCS.Properties.Resources.nav_tool, Selected = DemoControlCS.Properties.Resources.nav_tool}, ToolTip = "tooltip Build", Height = 40},
                new NavBarItem {ID = 6, Text = "Terms of Service", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.nav_info, Hover = DemoControlCS.Properties.Resources.nav_info, Selected = DemoControlCS.Properties.Resources.nav_info}, ToolTip = "tooltip EULA", Height = 40},
                new NavBarItem {ID = 7, Text = "Extra", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.nav_extra, Hover = DemoControlCS.Properties.Resources.nav_extra, Selected = DemoControlCS.Properties.Resources.nav_extra}, Height = 40}
            };

            // Sample 2. Only 1 level childs items -------------------------------------------------
            sample2 = new List<NavBarItem> {
            new NavBarItem {ID = 1, Text = "Desktop", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpDesktop, Hover = DemoControlCS.Properties.Resources.wpDesktopH, Selected = DemoControlCS.Properties.Resources.wpDesktopS}, ToolTip = "tooltip Desktop",
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 1001, ParentID = 1, Text = "Start",Height = 30, ToolTip = "tooltip Start"},
                    new NavBarItem {ID = 1002, ParentID = 1, Text = "My comments", Height = 30},
                    new NavBarItem {ID = 1003, ParentID = 1, Text = "Site Statistics", Height = 30},
                    new NavBarItem {ID = 1004, ParentID = 1, Text = "My blogs", Height = 30, ToolTip = "tooltip My blogs"},
                    new NavBarItem {ID = 1005, ParentID = 1, Text = "Blogs I follow", Height = 30},
                    new NavBarItem {ID = 1006, ParentID = 1, Text = "Akismed statistics", Height = 30},
                    new NavBarItem {ID = 1007, ParentID = 1, Text = "Omnisearch", Height = 30}
                }
            },
            new NavBarItem {ID = 2, Text = "Store", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpStore, Hover = DemoControlCS.Properties.Resources.wpStoreH, Selected = DemoControlCS.Properties.Resources.wpStoreS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 2001, ParentID = 2, Text = "Main", Height = 30},
                    new NavBarItem {ID = 2002, ParentID = 2, Text = "Premium Themes", Height = 30},
                    new NavBarItem {ID = 2003, ParentID = 2, Text = "My domains", Height = 30},
                    new NavBarItem {ID = 2004, ParentID = 2, Text = "Manage purchases", Height = 30},
                    new NavBarItem {ID = 2005, ParentID = 2, Text = "Billing history", Height = 30}
                }
            },
            new NavBarItem {ID = 3, Text = "Posts", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpPost, Hover = DemoControlCS.Properties.Resources.wpPostH, Selected = DemoControlCS.Properties.Resources.wpPostS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 3001, ParentID = 3, Text = "All", Height = 30},
                    new NavBarItem {ID = 3002, ParentID = 3, Text = "Add new", Height = 30},
                    new NavBarItem {ID = 3003, ParentID = 3, Text = "Categories", Height = 30},
                    new NavBarItem {ID = 3004, ParentID = 3, Text = "Tags", Height = 30}
                }
            },
            new NavBarItem {ID = 4, Text = "Media", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpMedia, Hover = DemoControlCS.Properties.Resources.wpMediaH, Selected = DemoControlCS.Properties.Resources.wpMediaS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 4001, ParentID = 4, Text = "Library", Height = 30},
                    new NavBarItem {ID = 4002, ParentID = 4, Text = "Add new", Height = 30}
                }
            },
            new NavBarItem {ID = 5, Text = "Links", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpLinks, Hover = DemoControlCS.Properties.Resources.wpLinksH, Selected = DemoControlCS.Properties.Resources.wpLinksS}, ToolTip = "tooltip Links",
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 5001, ParentID = 5, Text = "All", Height = 30},
                    new NavBarItem {ID = 5002, ParentID = 5, Text = "Add new", Height = 30},
                    new NavBarItem {ID = 5003, ParentID = 5, Text = "Link categories", Height = 30}
                }
            }
        };

            // Sample 3. Very 'complex tree-node items'. Until 5th depth childs
            sample3 = new List<NavBarItem> {
            new NavBarItem {ID = 1, Text = "Desktop", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpDesktop, Hover = DemoControlCS.Properties.Resources.wpDesktopH, Selected = DemoControlCS.Properties.Resources.wpDesktopH}, ToolTip = "tooltip Desktop",
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 1001, ParentID = 1, Text = "Start", Height = 30, ToolTip = "tooltip Start"},
                    new NavBarItem {ID = 1002, ParentID = 1, Text = "My comments", Height = 30},
                    new NavBarItem {ID = 1003, ParentID = 1, Text = "Site Statistics", Height = 30},
                    new NavBarItem {ID = 1004, ParentID = 1, Text = "My blogs", Height = 30, ToolTip = "tooltip My blogs",
                        Childs = new List<NavBarItem> {
                            new NavBarItem {ID = 10041, ParentID = 1004, Text = "Custom #1", Height = 30, LeftChild = 24, ToolTip = "tooltip Custom #1"},
                            new NavBarItem {ID = 10042, ParentID = 1004, Text = "Custom #2", Height = 30, LeftChild = 24, ToolTip = "tooltip Custom #2",
                                Childs = new List<NavBarItem> {
                                    new NavBarItem {ID = 100421, ParentID = 10042, Text = "XXX1", Height = 30, LeftChild = 44, ToolTip = "tooltip XXX1"},
                                    new NavBarItem {ID = 100422, ParentID = 10042, Text = "XXX2", Height = 30, LeftChild = 44}
                                }
                            },
                            new NavBarItem {ID = 10043, ParentID = 1004, Text = "Custom #3", Height = 30, LeftChild = 24}
                        }
                    },
                    new NavBarItem {ID = 1005, ParentID = 1, Text = "Blogs I follow", Height = 30,
                        Childs = new List<NavBarItem> {
                            new NavBarItem {ID = 10051, ParentID = 1005, Text = "xxx blog x1", Height = 30, LeftChild = 24},
                            new NavBarItem {ID = 10052, ParentID = 1005, Text = "xxx blog x2", Height = 30, LeftChild = 24},
                            new NavBarItem {ID = 10053, ParentID = 1005, Text = "xxx blog x3", Height = 30, LeftChild = 24},
                            new NavBarItem {ID = 10054, ParentID = 1005, Text = "xxx blog x4", Height = 30, LeftChild = 24}
                        }
                    },
                    new NavBarItem {ID = 1006, ParentID = 1, Text = "Akismed statistics", Height = 30},
                    new NavBarItem {ID = 1007, ParentID = 1, Text = "Omnisearch", Height = 30}
                }
            },
            new NavBarItem {ID = 2, Text = "Store", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpStore, Hover = DemoControlCS.Properties.Resources.wpStoreH, Selected = DemoControlCS.Properties.Resources.wpStoreS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 2001, ParentID = 2, Text = "Main", Height = 30},
                    new NavBarItem {ID = 2002, ParentID = 2, Text = "Premium Themes", Height = 30},
                    new NavBarItem {ID = 2003, ParentID = 2, Text = "My domains", Height = 30},
                    new NavBarItem {ID = 2004, ParentID = 2, Text = "Manage purchases", Height = 30},
                    new NavBarItem {ID = 2005, ParentID = 2, Text = "Billing history", Height = 30}
                }
            },
            new NavBarItem {ID = 3, Text = "Posts", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpPost, Hover = DemoControlCS.Properties.Resources.wpPostH, Selected = DemoControlCS.Properties.Resources.wpPostS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 3001, ParentID = 3, Text = "All", Height = 30},
                    new NavBarItem {ID = 3002, ParentID = 3, Text = "Add new", Height = 30},
                    new NavBarItem {ID = 3003, ParentID = 3, Text = "Categories", Height = 30},
                    new NavBarItem {ID = 3004, ParentID = 3, Text = "Tags", Height = 30}
                }
            },
            new NavBarItem {ID = 4, Text = "Media", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpMedia, Hover = DemoControlCS.Properties.Resources.wpMediaH, Selected = DemoControlCS.Properties.Resources.wpMediaS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 4001, ParentID = 4, Text = "Library", Height = 30},
                    new NavBarItem {ID = 4002, ParentID = 4, Text = "Add new", Height = 30}
                }
            },
            new NavBarItem {ID = 5, Text = "Links", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpLinks, Hover = DemoControlCS.Properties.Resources.wpLinksH, Selected = DemoControlCS.Properties.Resources.wpLinksS}, ToolTip = "tooltip Links",
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 5001, ParentID = 5, Text = "All", Height = 30},
                    new NavBarItem {ID = 5002, ParentID = 5, Text = "Add new", Height = 30},
                    new NavBarItem {ID = 5003, ParentID = 5, Text = "Link categories", Height = 30}
                }
            },
            new NavBarItem {ID = 6, Text = "Pages", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpPages, Hover = DemoControlCS.Properties.Resources.wpPagesH, Selected = DemoControlCS.Properties.Resources.wpPagesS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 6001, ParentID = 6, Text = "All", Height = 30},
                    new NavBarItem {ID = 6002, ParentID = 6, Text = "Add new", Height = 30},
                    new NavBarItem {ID = 6003, ParentID = 6, Text = "Copy page", Height = 30}
                }
            },
            new NavBarItem {ID = 7, Text = "Comments", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpComments, Hover = DemoControlCS.Properties.Resources.wpCommentsH, Selected = DemoControlCS.Properties.Resources.wpCommentsS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 7001, ParentID = 7, Text = "Test", Height = 30,
                        Childs = new List<NavBarItem> {
                            new NavBarItem {ID = 70011, ParentID = 7001, Text = "Custom #1", Height = 30, LeftChild = 24,
                                Childs = new List<NavBarItem> {
                                    new NavBarItem {ID = 700111, ParentID = 70011, Text = "Custom #1x1", Height = 30, LeftChild = 44},
                                    new NavBarItem {ID = 700112, ParentID = 70011, Text = "Custom #1x2", Height = 30, LeftChild = 44},
                                    new NavBarItem {ID = 700113, ParentID = 70011, Text = "Custom #1x3", Height = 30, LeftChild = 44},
                                    new NavBarItem {ID = 700114, ParentID = 70011, Text = "Custom #1x4", Height = 30, LeftChild = 44}
                                }
                            },
                            new NavBarItem {ID = 70012, ParentID = 7001, Text = "Custom #2", Height = 30, LeftChild = 24},
                            new NavBarItem {ID = 70013, ParentID = 7001, Text = "Custom #3", Height = 30, LeftChild = 24}
                        }
                    },
                    new NavBarItem {ID = 7002, ParentID = 7, Text = "Remove", Height = 30,
                        Childs = new List<NavBarItem> {
                            new NavBarItem {ID = 70021, ParentID = 7002, Text = "something #1", Height = 30, LeftChild = 24,
                                Childs = new List<NavBarItem> {
                                    new NavBarItem {ID = 700211, ParentID = 70021, Text = "xxxxxx1", Height = 30, LeftChild = 44,
                                        Childs = new List<NavBarItem> {
                                            new NavBarItem {ID = 7002111, ParentID = 700211, Text = "5th child #1", Height = 24, LeftChild = 59},
                                            new NavBarItem {ID = 7002112, ParentID = 700211, Text = "5th child #2", Height = 24, LeftChild = 59},
                                            new NavBarItem {ID = 7002113, ParentID = 700211, Text = "5th child #3", Height = 24, LeftChild = 59},
                                            new NavBarItem {ID = 7002114, ParentID = 700211, Text = "5th child #4", Height = 24, LeftChild = 59}
                                        }
                                    },
                                    new NavBarItem {ID = 700212, ParentID = 70021, Text = "xxxxxx2", Height = 30, LeftChild = 44},
                                    new NavBarItem {ID = 700213, ParentID = 70021, Text = "xxxxxx3", Height = 30, LeftChild = 44},
                                    new NavBarItem {ID = 700214, ParentID = 70021, Text = "xxxxxx4", Height = 30, LeftChild = 44}
                                }
                            },
                            new NavBarItem {ID = 70022, ParentID = 7002, Text = "somehting #2", Height = 30, LeftChild = 24}
                        }
                    },
                    new NavBarItem {ID = 7003, ParentID = 7, Text = "Attach", Height = 30}
                }
            },
            new NavBarItem {ID = 8, Text = "Suggestions", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpSuggestions, Hover = DemoControlCS.Properties.Resources.wpSuggestionsH, Selected = DemoControlCS.Properties.Resources.wpSuggestionsS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 8001, ParentID = 8, Text = "Polls", Height = 30},
                    new NavBarItem {ID = 8002, ParentID = 8, Text = "Qualifications", Height = 30},
                    new NavBarItem {ID = 8003, ParentID = 8, Text = "Send mark", Height = 30}
                }
            },
            new NavBarItem {ID = 9, Text = "Appearance", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpAppearance, Hover = DemoControlCS.Properties.Resources.wpAppearanceH, Selected = DemoControlCS.Properties.Resources.wpAppearanceS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 9001, ParentID = 9, Text = "Themes", Height = 30},
                    new NavBarItem {ID = 9002, ParentID = 9, Text = "Customize", Height = 30},
                    new NavBarItem {ID = 9003, ParentID = 9, Text = "Widgets", Height = 30},
                    new NavBarItem {ID = 9004, ParentID = 9, Text = "Menus", Height = 30},
                    new NavBarItem {ID = 9005, ParentID = 9, Text = "Header", Height = 30},
                    new NavBarItem {ID = 9006, ParentID = 9, Text = "Background", Height = 30},
                    new NavBarItem {ID = 9007, ParentID = 9, Text = "AMP", Height = 30},
                    new NavBarItem {ID = 9008, ParentID = 9, Text = "Theme settings", Height = 30},
                    new NavBarItem {ID = 9009, ParentID = 9, Text = "Smartphone", Height = 30}
                }
            },
            new NavBarItem {ID = 10, Text = "Users", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpUsers, Hover = DemoControlCS.Properties.Resources.wpUsersH, Selected = DemoControlCS.Properties.Resources.wpUsersS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 10001, ParentID = 10, Text = "All", Height = 30},
                    new NavBarItem {ID = 10002, ParentID = 10, Text = "Invite user", Height = 30},
                    new NavBarItem {ID = 10003, ParentID = 10, Text = "My profile", Height = 30},
                    new NavBarItem {ID = 10004, ParentID = 10, Text = "Settings", Height = 30}
                }
            },
            new NavBarItem {ID = 11, Text = "Tools", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpTools, Hover = DemoControlCS.Properties.Resources.wpToolsH, Selected = DemoControlCS.Properties.Resources.wpToolsS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 11001, ParentID = 11, Text = "Available tools", Height = 30},
                    new NavBarItem {ID = 11002, ParentID = 11, Text = "Import", Height = 30},
                    new NavBarItem {ID = 11003, ParentID = 11, Text = "Export", Height = 30},
                    new NavBarItem {ID = 11004, ParentID = 11, Text = "Delete site", Height = 30}
                }
            },
            new NavBarItem {ID = 12, Text = "Settings", Icon = new ItemIcon {Default = DemoControlCS.Properties.Resources.wpSettings, Hover = DemoControlCS.Properties.Resources.wpSettingsH, Selected = DemoControlCS.Properties.Resources.wpSettingsS},
                Childs = new List<NavBarItem> {
                    new NavBarItem {ID = 12001, ParentID = 12, Text = "Main", Height = 30},
                    new NavBarItem {ID = 12002, ParentID = 12, Text = "Writing", Height = 30},
                    new NavBarItem {ID = 12003, ParentID = 12, Text = "Reading", Height = 30},
                    new NavBarItem {ID = 12004, ParentID = 12, Text = "Comments", Height = 30},
                    new NavBarItem {ID = 12005, ParentID = 12, Text = "Media", Height = 30},
                    new NavBarItem {ID = 12006, ParentID = 12, Text = "Share", Height = 30},
                    new NavBarItem {ID = 12007, ParentID = 12, Text = "AdControl", Height = 30},
                    new NavBarItem {ID = 12008, ParentID = 12, Text = "OpenID", Height = 30},
                    new NavBarItem {ID = 12009, ParentID = 12, Text = "Webhooks", Height = 30}
                }
            }
        };
        }
    }
}
