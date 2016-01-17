using UnityEngine;
using System.Collections;

public class BaseItem {

    private string itemName;
    private string itemDescription;
    private int price;
    private int encumbrance;
    private int rarity;
    public enum ItemTypes
    {
        WEAPON,
        ARMOR,
        GEAR,
        CUSTOMIZATION
    };

    public ItemTypes itemType;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }
    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
    public int Encumbrance
    {
        get { return price; }
        set { price = value; }
    }
    public int Rarity
    {
        get { return price; }
        set { price = value; }
    }
    public ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}
