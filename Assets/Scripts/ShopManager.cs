using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;

public class ShopManager : MonoBehaviour
{
    public int[] itemIds;

    public Action<int> Init(Action<int> OnChangeCoin, UnityAction<ItemButton> buyItem)
    {
        foreach (int id in itemIds) {
            GameObject clone = Instantiate (Resources.Load ("Item")) as GameObject;
            clone.transform.SetParent (transform, false);
            var itemButton = clone.GetComponent<ItemButton> ();
            itemButton.id = id;
            OnChangeCoin += itemButton.OnCoinChange;
            clone.GetComponent<Button> ().onClick.AddListener (() => {});
            Debug.Log ("itemButton" + itemButton.id);
        }
        return OnChangeCoin;
    }

}
