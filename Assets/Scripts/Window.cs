using UnityEngine;
using System.Collections;

public class Window : MonoBehaviour
{
    public CoinManager coinManager;
    public ShopManager ShopManager;
    public CoinText coinText;

    void Awake()
    {
        coinManager.Init ();
        coinManager.OnChangeCoin += coinText.OnCoinChange;
        coinManager.OnChangeCoin = ShopManager.Init (coinManager.OnChangeCoin, coinManager.BuyItem);
    }

}
