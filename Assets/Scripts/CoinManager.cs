using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;
using System.Reflection;

public class CoinManager : MonoBehaviour
{
    private const string COIN_KEY = "Coin";
    public Action<int> OnChangeCoin = (a) => {};

    public void Init()
    {
        ChangeCoin (0);
    }

    public void ClickCoin0Button()
    {
        SubCoin (LoadCoin ());
    }

    public void BuyItem(ItemButton itemButton)
    {
        SubCoin (itemButton.GetPrice);
    }

    public int LoadCoin()
    {
        return PlayerPrefs.GetInt (COIN_KEY, 0);
    }

    public void AddCoin(int coin)
    {
        if (coin < 0) {
            return;
        }
        ChangeCoin (LoadCoin () + coin);
        return;
    }

    public bool SubCoin(int coin)
    {
        if (coin < 0) {
            return false;
        }

        if (LoadCoin () - coin < 0) {
            return false;
        }

        ChangeCoin (LoadCoin () - coin);
        return true;
    }

    private void ChangeCoin(int coin)
    {
        PlayerPrefs.SetInt (COIN_KEY, coin);
        PlayerPrefs.Save ();
        OnChangeCoin (PlayerPrefs.GetInt (COIN_KEY, 0));
    }
}
