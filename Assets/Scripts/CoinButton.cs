using UnityEngine;
using System.Collections;

public class CoinButton : MonoBehaviour
{
    public void DownAddCoin100Button()
    {
        DeleGateAction.Add (100);
    }

    public void DownCoin0Button()
    {
        DeleGateAction.Sub (DeleGateAction.Get ());
    }

    public void DownCoinSub100Button()
    {
        DeleGateAction.Sub (100);
    }

    public void DownCoinSub500Buttn()
    {
        DeleGateAction.Sub (500);
    }

    public void DownCoinSub1000Button()
    {
        DeleGateAction.Sub (1000);
    }
}
