using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 1 load data from json
/// 2 creat an item with data
/// 3 
/// </summary>
public class BackpackUI : MonoBehaviour
{
    /// <summary>
    /// item template
    /// </summary>
    public Transform ItemTemp;
    public ScrollRect ItemScrollRect;
    private List<BackpackItem> itemList;
    // Start is called before the first frame update
    void Awake()
    {
        //1
        ItemManager.Instance.LoadItemConfigData();
        this.itemList = ItemManager.Instance.BackPackItemList;
    }
    /// <summary>
    /// creat one item
    /// </summary>
    /// <returns></returns>
    private GameObject CreatItem()
    {
        GameObject go = GameObject.Instantiate(this.ItemTemp.gameObject, this.ItemScrollRect.content);
        return go;
    }
    /// <summary>
    /// creat all items
    /// </summary>
    public void CreatAllItem()
    {
        for (int i=0; i<this.itemlist.Count;i++)
        {
            GameObject go = this.CreatItem();
        }
    }

