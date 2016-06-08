using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinText : MonoBehaviour
{
    private Text coinText;

    void Awake ()
    {
        coinText = transform.GetComponent<Text> ();
    }

    public void OnCoinChange(int coin)
    {
        coinText.text = "所持金:" + coin.ToString ();
    }
}
