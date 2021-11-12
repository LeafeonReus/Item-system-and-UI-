using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Text;

public class ItemManager 
{
   private static ItemManager instance;

   public static ItemManager Instance
    {
        get
        {
            if (instance == null) instance = new ItemManager();
            return instance;
        }
    }
   /// <summary>
   /// save the BackPackItem List
   /// </summary>
   public List<BackpackItem> BackPackItemList;
   private JsonData ItemConfig;

   // load json item file
   public void LoadItemConfigData()
    {
        if (this.BackPackItemList == null)
        {
            this.BackPackItemList = new List<BackpackItem>();
        }
        this.ItemConfig = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Config/BackPackItems.json"));
        this.DecodeJson();   
    }

    private void DecodeJson()
    {
        for (int i=0; i<this.ItemConfig.Count; i++)
        {
            int itemID = (int)this.ItemConfig[i]["ItemID"];
            string itemName = this.ItemConfig[i]["ItemName"].ToString();
            string itemDesc = this.ItemConfig[i]["ItemDesc"].ToString();
            int itemType = this.ItemConfig[i]["ItemType"];
            string itemIcon = this.ItemConfig[i]["ItemIcon"].ToString();
            int itemCount = (int)this.ItemConfig[i]["ItemCount"];
            int itemOperation = (int)this.ItemConfig[i]["ItemOperation"];

            Debug.LogError(itemID + "" + itemName + "" + itemDesc + "" + itemType + "" + itemIcon + ""
                + itemCount + "" + itemOperation+"");
            BackpackItem item = new BackpackItem(itemID, itemName, 
                itemDesc, itemType, itemIcon, itemCount, itemOperation);
            this.BackPackItemList.Add(item);
        }
    }

}
