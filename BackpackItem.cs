using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackpackItem 
{
    ///Item Types
    public enum ItemType
    {
        UnKnown = -1,
        Equip,
        Food,
        Mineral,
    }
    /// <summary>
    /// Unique item ID
    /// </summary>

    public int ItemID;

    public ItemType MItemType = ItemType.UnKnown;

    ///item name
    public string ItemName;

    /// <summary>
    /// desciption of item
    /// </summary>

    public string ItemDesc;

    /// <summary>
    /// Item image
    /// </summary>
    public string ItemIcon;
    ///Count number of Item
    public int ItemCount;

    /// <summary>
    /// item operation, craft, etc
    /// </summary>
    public int ItemOpreation;

    /// <summary>
    /// creat an item
    /// </summary>
    /// <param name="itemid"></param>
    /// <param name="name"></param>
    /// <param name="desc"></param>
    /// <param name="itemType"> -1:all 0: equip 1: food</param>
    /// <param name="icon"></param>
    /// <param name="itemcount"></param>
    /// <param name="itemoperation"></param>
    public BackpackItem(int itemid, string name, 
        string desc, int itemType, string icon, int itemcount, int itemoperation)
       {
        this.ItemID = itemid;
        this.ItemName = name;
        this.ItemDesc = desc;
        switch (itemType)
        {
            case -1:
                this MItemType = ItemType.UnKnown;
                break;
            case 0:
                this MItemType = ItemType.Equip;
                break;
            case 1:
                this MItemType = ItemType.Food;
                break;
            case 2:
                this MItemType = ItemType.Mineral;
                break;
            default:
                break:
        }
        this.ItemIcon = icon;
        this.ItemCount = itemcount;
        this.ItemOpreation = itemoperation;
    }

    
}
