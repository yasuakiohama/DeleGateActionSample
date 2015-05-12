using UnityEngine;
using System.Collections;
using System;

public class DeleGateAction
{
    private const string COIN_KEY = "Coin";
    public static Action<int> OnCoinChange = delegate {};

    public static int Get()
    {
        return PlayerPrefs.GetInt (COIN_KEY, 0);
    }

    public static bool Add(int coin)
    {
        if (coin < 0) {
            return false;
        }
        CoinChange (Get () + coin);
        return true;
    }

    public static bool Sub(int coin)
    {
        if (coin < 0) {
            return false;
        }

        if (Get () - coin < 0) {
            return false;
        }

        CoinChange (Get () - coin);
        return true;
    }

    private static void CoinChange(int coin)
    {
        PlayerPrefs.SetInt (COIN_KEY, coin);
        PlayerPrefs.Save ();
        OnCoinChange (PlayerPrefs.GetInt (COIN_KEY, 0));
    }

    public static void CoinChange()
    {
        OnCoinChange (PlayerPrefs.GetInt (COIN_KEY, 0));
    }
}
