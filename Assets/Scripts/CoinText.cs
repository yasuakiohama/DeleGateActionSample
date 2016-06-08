using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinText : MonoBehaviour
{
    public void OnCoinChange(int coin)
    {
        GetComponent<Text> ().text = "所持金:" + coin.ToString ();
    }
}
