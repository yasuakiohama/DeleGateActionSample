using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinText : MonoBehaviour
{
    private Text coinText;

    void Awake ()
    {
        DeleGateAction.OnCoinChange += OnCoinChange;
        coinText = transform.GetComponent<Text> ();
        DeleGateAction.CoinChange ();
    }

    private void OnCoinChange(int coin)
    {
        coinText.text = "coin:" + coin.ToString ();
    }
}
