using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemButton : MonoBehaviour
{
    public int id;
    private ItemList.ItemData itemData;

    public int GetPrice {
        get {
            return itemData.price;
        }
    }

    void Start ()
    {
        itemData = ItemList.Data [id];
        transform.FindChild ("name").GetComponent<Text> ().text = itemData.name;
        transform.FindChild ("price").GetComponent<Text> ().text = itemData.price + "円";
    }

    public void OnCoinChange(int coin)
    {
        Debug.Log ("coin" + coin);
        GetComponent<Button> ().interactable = coin >= itemData.price ? true : false;
    }
}
