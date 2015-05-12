using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemButton : MonoBehaviour
{
    public int price = 1000;
    private Button itemButton;

    void Awake ()
    {
        DeleGateAction.OnCoinChange += OnCoinChange;
        itemButton = transform.GetComponent<Button> ();
        DeleGateAction.CoinChange ();
    }

    private void OnCoinChange(int coin)
    {
        itemButton.interactable = coin >= price ? true : false;
    }
}
