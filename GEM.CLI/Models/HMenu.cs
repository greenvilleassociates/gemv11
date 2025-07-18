using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HMenu
{
    public int Id { get; set; }

    /// <summary>
    /// The type of menu this item belongs to. FK to #__menu_types.menutype
    /// </summary>
    public string Menutype { get; set; } = null!;

    /// <summary>
    /// The display title of the menu item.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// The SEF alias of the menu item.
    /// </summary>
    public string Alias { get; set; } = null!;

    public string Note { get; set; } = null!;

    /// <summary>
    /// The computed path of the menu item based on the alias field.
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// The actually link the menu item refers to.
    /// </summary>
    public string Link { get; set; } = null!;

    /// <summary>
    /// The type of link: Component, URL, Alias, Separator
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// The published state of the menu link.
    /// </summary>
    public short Published { get; set; }

    /// <summary>
    /// The parent menu item in the menu tree.
    /// </summary>
    public int ParentId { get; set; }

    /// <summary>
    /// The relative level in the tree.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// FK to #__extensions.id
    /// </summary>
    public int ComponentId { get; set; }

    /// <summary>
    /// FK to #__users.id
    /// </summary>
    public int CheckedOut { get; set; }

    /// <summary>
    /// The time the menu item was checked out.
    /// </summary>
    public DateTime CheckedOutTime { get; set; }

    /// <summary>
    /// The click behaviour of the link.
    /// </summary>
    public short BrowserNav { get; set; }

    /// <summary>
    /// The access level required to view the menu item.
    /// </summary>
    public long Access { get; set; }

    /// <summary>
    /// The image of the menu item.
    /// </summary>
    public string Img { get; set; } = null!;

    public int TemplateStyleId { get; set; }

    /// <summary>
    /// JSON encoded data for the menu item.
    /// </summary>
    public string Params { get; set; } = null!;

    /// <summary>
    /// Nested set lft.
    /// </summary>
    public long Lft { get; set; }

    /// <summary>
    /// Nested set rgt.
    /// </summary>
    public long Rgt { get; set; }

    /// <summary>
    /// Indicates if this menu item is the home or default page.
    /// </summary>
    public short Home { get; set; }

    public string Language { get; set; } = null!;

    public short ClientId { get; set; }
}
