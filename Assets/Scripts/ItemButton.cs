using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemButton : MonoBehaviour
{
    public int id;
    private ItemList.ItemData itemData;

    private Button itemButton;

    public int GetPrice {
        get {
            return itemData.price;
        }
    }

    void Awake ()
    {
        itemButton = transform.GetComponent<Button> ();
        itemData = ItemList.Data [id];
        transform.FindChild ("name").GetComponent<Text> ().text = itemData.name;
        transform.FindChild ("price").GetComponent<Text> ().text = itemData.price + "円";
    }

    public void OnCoinChange(int coin)
    {
        itemButton.interactable = coin >= itemData.price ? true : false;
    }
}
