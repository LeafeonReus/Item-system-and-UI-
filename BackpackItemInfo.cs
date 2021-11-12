using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackItemInfo : MonoBehaviour
{
    public Image Icon;
    public Text Count;
    /// <summary>
    /// transfer data
    /// </summary>
    public void SetData(BackpackItem item)
    {
         if (item == null)
        {
            Debug.LogError("item is null");
            return;
        }
        this.item = item;

        this.Icon.sprite = Resources.Load<Sprite>("Textures/"+ this.item.ItemIcon);
        this.Count.text = this.item.ItemCount.ToString();
    }
}
